using System.Collections.Generic;

namespace MRZCodeParser.CodeTypes
{
    internal class TD2FirstLine : MrzLine
    {
        internal TD2FirstLine(string value) : base(value)
        {
        }

        protected override string Pattern => "([A|C|I][A-Z0-9<]{1})([A-Z]{3})([A-Z0-9<]{31})";
        
        protected override IEnumerable<FieldType> FieldTypes => new[]
        {
            FieldType.DocumentType,
            FieldType.CountryCode,
            FieldType.PrimaryIdentifier,
        };
    }
}