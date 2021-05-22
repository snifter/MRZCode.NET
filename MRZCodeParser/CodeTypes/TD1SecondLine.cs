using System.Collections.Generic;

namespace MRZCodeParser.CodeTypes
{
    internal class TD1SecondLine : MrzLine
    {
        internal TD1SecondLine(string value) : base(value)
        {
        }

        protected override string Pattern =>
            "([0-9]{6})([0-9]{1})([M|F|X|<]{1})([0-9]{6})([0-9]{1})([A-Z<]{3})([A-Z0-9<]{11})([0-9]{1})";

        internal override IEnumerable<FieldType> FieldTypes => new[]
        {
            FieldType.BirthDate,
            FieldType.BirthDateCheckDigit,
            FieldType.Sex,
            FieldType.ExpiryDate,
            FieldType.ExpiryDateCheckDigit,
            FieldType.Nationality,
            FieldType.OptionalData2,
            FieldType.OverallCheckDigit
        };
    }
}
