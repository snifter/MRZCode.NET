using System;

namespace MRZCodeParser
{
    public enum FieldType
    {
        DocumentType,
        CountryCode,
        [ReplaceHelper("")]
        DocumentNumber,
        DocumentNumberCheckDigit,
        OptionalData1,
        BirthDate,
        BirthDateCheckDigit,
        Sex,
        ExpiryDate,
        ExpiryDateCheckDigit,
        Nationality,
        OptionalData2,
        Names,
        OverallCheckDigit,
        PrimaryIdentifier,
        OptionalData,
        OptionalDataCheckDigit
    }
}