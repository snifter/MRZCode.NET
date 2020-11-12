using System;
using System.Collections.Generic;
using System.Linq;
using MRZCodeParser.CodeTypes;

namespace MRZCodeParser
{
    public abstract class MrzCode
    {
        protected IEnumerable<string> RawLines { get; }

        public abstract CodeType Type { get; }

        public abstract IEnumerable<MrzLine> Lines { get; }

        public IEnumerable<FieldType> FieldTypes => Lines.SelectMany(x => x.FieldTypes);

        public string this[FieldType type]
        {
            get
            {
                var fields = Fields;
                var targetType = ChangeBackwardFieldTypeToCurrent(type);

                if (fields.Fields.All(x => x.Type != targetType))
                {
                    throw new MrzCodeException($"Code {Type} does not contain field {type}");
                }

                return fields[targetType].Value;
            }
        }

        protected virtual FieldType ChangeBackwardFieldTypeToCurrent(FieldType type) => type;

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

        protected MrzCode(IEnumerable<string> lines)
        {
            RawLines = lines;
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

            return type switch
            {
                CodeType.TD1 => new TD1MrzCode(lines),
                CodeType.TD2 => new TD2MrzCode(lines),
                CodeType.TD3 => new TD3MrzCode(lines),
                CodeType.MRVA => new MRVAMrzCode(lines),
                CodeType.MRVB => new MRVBMrzCode(lines),
                _ => null // never occurs because in this case exception is thrown in CodeTypeDetector
            };
        }
    }
}