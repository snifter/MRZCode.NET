using System.Collections.Generic;

namespace MRZCodeParser.CodeTypes
{
    internal class TD1ThirdLine : MrzLine
    {
        public TD1ThirdLine(string value) : base(value)
        {
        }

        protected override string Pattern => "([A-Z0-9<]{30})";

        internal override IEnumerable<FieldType> FieldTypes => new[] {FieldType.Names};
    }
}