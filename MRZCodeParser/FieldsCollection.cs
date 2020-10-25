using System.Collections.Generic;
using System.Linq;

namespace MRZCodeParser
{
    public class FieldsCollection
    {
        public IEnumerable<Field> Fields { get; }

        internal FieldsCollection(IEnumerable<Field> fields)
        {
            Fields = fields;
        }

        public Field this[FieldType type] => Fields.Single(x => x.Type == type);
    }
}