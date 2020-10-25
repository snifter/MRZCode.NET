using System.Collections.Generic;

namespace MRZCodeParser
{
    internal class TD1ThirdLine : MrzLine
    {
        public TD1ThirdLine(string value) : base(value)
        {
        }

        protected override string Pattern => "([A-Z0-9<]{30})";
        
        protected override IEnumerable<FieldType> FieldTypes => new[] {FieldType.Names};
    }
}