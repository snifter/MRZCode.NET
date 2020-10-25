using System.Collections.Generic;

namespace MRZCodeParser
{
    internal class TD1FirstLine : MrzLine
    {
        internal TD1FirstLine(string value) : base(value)
        {
        }

        protected override string Pattern => "([A|C|I][A-Z0-9<]{1})([A-Z]{3})([A-Z0-9<]{9})([0-9]{1})([A-Z0-9<]{15})";

        protected override IEnumerable<FieldType> FieldTypes => new[]
        {
            FieldType.DocumentType,
            FieldType.CountryCode,
            FieldType.DocumentNumber,
            FieldType.DocumentNumberCheckDigit,
            FieldType.OptionalData1
        };
    }
}