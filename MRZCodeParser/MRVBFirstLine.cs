using System.Collections.Generic;

namespace MRZCodeParser
{
    internal class MRVBFirstLine : MrzLine
    {
        internal MRVBFirstLine(string value) : base(value)
        {
        }

        protected override string Pattern => "(V[A-Z0-9<]{1})([A-Z]{3})([A-Z0-9<]{31})";

        protected override IEnumerable<FieldType> FieldTypes => new[]
        {
            FieldType.DocumentType,
            FieldType.CountryCode,
            FieldType.PrimaryIdentifier,
        };
    }
}