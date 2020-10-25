using System.Collections.Generic;

namespace MRZCodeParser
{
    internal class UnknownLine : MrzLine
    {
        internal UnknownLine(string value) : base(value)
        {
        }

        protected override string Pattern => "";

        protected override IEnumerable<FieldType> FieldTypes => new FieldType[0];
    }
}