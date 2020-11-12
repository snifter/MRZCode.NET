using System;
using System.Collections.Generic;
using System.Linq;
using MRZCodeParser.Parsers;

namespace MRZCodeParser
{
    public class MrzCode
    {
        public CodeType Type { get; }

        public IEnumerable<MrzLine> Lines => lines.AsReadOnly();

        public IEnumerable<FieldType> FieldTypes => Lines.SelectMany(x => x.FieldTypes);

        public string this[FieldType type]
        {
            get
            {
                var fields = Fields;
                var targetType = type;

                if (fields.Fields.All(x => x.Type != targetType))
                {
                    throw new MrzCodeException($"Code {Type} does not contain field {type}");
                }

                return fields[targetType].Value;
            }
        }

        private FieldsCollection Fields
        {
            get
            {
                var fields = new List<Field>();
                foreach (var line in Lines)
                {
                    fields.AddRange(line.Fields.Fields);
                }

                return new FieldsCollection(fields);
            }
        }

        private readonly List<MrzLine> lines = new List<MrzLine>(3);

        private MrzCode(CodeType codeType)
        {
            Type = codeType;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Lines.Select(x => x.Value));
        }

        public static MrzCode Parse(string code)
        {
            var lines = new LineSplitter(code)
                .Split()
                .ToList();
            var type = new CodeTypeDetector(lines).DetectType();

            var parser = MrzCodeParserFactory.Create(type);
            return parser.Parse(lines);
        }

        internal class Builder
        {
            private readonly MrzCode mrzCode;

            internal Builder(CodeType codeType)
            {
                mrzCode = new MrzCode(codeType);
            }

            internal Builder AddLine(MrzLine line)
            {
                mrzCode.lines.Add(line);
                return this;
            }

            internal MrzCode Build()
            {
                return mrzCode;
            }
        }
    }
}