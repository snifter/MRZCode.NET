using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MRZCodeParser
{
    public abstract class MrzLine
    {
        public string Value { get; }

        public int Length => Value?.Length ?? 0;

        public FieldsCollection Fields
        {
            get
            {
                var regex = new Regex(Pattern);
                var match = regex.Match(Value);

                if (!match.Success)
                {
                    throw new MrzCodeException($"Line: {Value} does not match to pattern: {Pattern}");
                }

                var fields = new List<Field>();
                for (var i = 0; i < FieldTypes.Count(); i++)
                {
                    fields.Add(new Field(
                        FieldTypes.ElementAt(i),
                        new ValueCleaner(match.Groups[i + 1].Value).Clean(FieldTypes.ElementAt(i))));
                }

                return new FieldsCollection(fields);
            }
        }

        protected abstract string Pattern { get;}

        internal abstract IEnumerable<FieldType> FieldTypes { get; }

        internal MrzLine(string value)
        {
            Value = value;
        }
    }
}