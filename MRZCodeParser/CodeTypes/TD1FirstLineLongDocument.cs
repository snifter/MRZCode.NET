using System.Collections.Generic;

namespace MRZCodeParser.CodeTypes
{
    internal class TD1FirstLineLongDocument : MrzLine
    {
        internal TD1FirstLineLongDocument(string value) : base(value)
        { }

        protected override string Pattern => "([A|C|I][A-Z0-9<]{1})([A-Z<]{3})([A-Z0-9<]{13})([0-9]{1})([A-Z0-9<]{11})";


        internal override IEnumerable<FieldType> FieldTypes => new[]
        {
            FieldType.DocumentType,
            FieldType.CountryCode,
            FieldType.DocumentNumber,
            FieldType.DocumentNumberCheckDigit,
            FieldType.OptionalData1
        };
    }
}
