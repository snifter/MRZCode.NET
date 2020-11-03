using System.Collections.Generic;

namespace MRZCodeParser.CodeTypes
{
    internal class MRVASecondLine : MrzLine
    {
        internal MRVASecondLine(string value) : base(value)
        {
        }

        protected override string Pattern =>
            "([A-Z0-9<]{9})([0-9]{1})([A-Z]{3})([0-9]{6})([0-9]{1})([M|F|X|<]{1})([0-9]{6})([0-9]{1})([A-Z0-9<]{16})";

        internal override IEnumerable<FieldType> FieldTypes => new[]
        {
            FieldType.DocumentNumber,
            FieldType.DocumentNumberCheckDigit,
            FieldType.Nationality,
            FieldType.BirthDate,
            FieldType.BirthDateCheckDigit,
            FieldType.Sex,
            FieldType.ExpiryDate,
            FieldType.ExpiryDateCheckDigit,
            FieldType.OptionalData
        };
    }
}