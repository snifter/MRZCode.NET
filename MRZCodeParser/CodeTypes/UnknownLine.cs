using System.Collections.Generic;

namespace MRZCodeParser.CodeTypes
{
    internal class UnknownLine : MrzLine
    {
        internal UnknownLine(string value) : base(value)
        {
        }

        protected override string Pattern => "";

        internal override IEnumerable<FieldType> FieldTypes => new FieldType[0];
    }
}