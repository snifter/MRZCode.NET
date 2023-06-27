using System.Linq;
using Xunit;

namespace MRZCodeParser.Tests
{
    public class TD2MrzCodeTest
    {
        [Fact]
        public void CodeFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.TD2);

            Assert.Equal(DocumentType.I.ToString(), target[FieldType.DocumentType]);
            Assert.Equal("UTO", target[FieldType.CountryCode]);
            Assert.Equal("ERIKSSON, ANNA MARIA", target[FieldType.PrimaryIdentifier]);
            Assert.Equal("D23145890", target[FieldType.DocumentNumber]);
            Assert.Equal("7", target[FieldType.DocumentNumberCheckDigit]);
            Assert.Equal("UTO", target[FieldType.Nationality]);
            Assert.Equal("740812", target[FieldType.BirthDate]);
            Assert.Equal("2", target[FieldType.BirthDateCheckDigit]);
            Assert.Equal("F", target[FieldType.Sex]);
            Assert.Equal("120415", target[FieldType.ExpiryDate]);
            Assert.Equal("9", target[FieldType.ExpiryDateCheckDigit]);
            Assert.Equal("", target[FieldType.OptionalData]);
            Assert.Equal("6", target[FieldType.OverallCheckDigit]);
        }
        
        [Fact]
        public void CodeFieldsTest_NoExpiryDate()
        {
            var target = MrzCode.Parse(MrzSamples.TD2_NO_EXPIRY_DATE);

            Assert.Equal("", target[FieldType.ExpiryDate]);
            Assert.Equal("0", target[FieldType.ExpiryDateCheckDigit]);
        }

        [Fact]
        public void CodeFieldsTest_CountrySingleLetter()
        {
            var target = MrzCode.Parse(MrzSamples.TD2_SINGLE_LETTER_COUNTRY_CODE);

            Assert.Equal("D", target[FieldType.CountryCode]);
            Assert.Equal("D", target[FieldType.Nationality]);
        }

        [Fact]
        public void CodeFieldsTest_BackwardCompatibility()
        {
            var target = MrzCode.Parse(MrzSamples.TD2);

            Assert.Equal(target[FieldType.OptionalData], target[FieldType.OptionalData2]);
        }

        [Fact]
        public void FieldTypeCollectionTest()
        {
            var target = MrzCode.Parse(MrzSamples.TD2);

            var expected = new[]
            {
                FieldType.DocumentType,
                FieldType.CountryCode,
                FieldType.PrimaryIdentifier,
                FieldType.DocumentNumber,
                FieldType.DocumentNumberCheckDigit,
                FieldType.Nationality,
                FieldType.BirthDate,
                FieldType.BirthDateCheckDigit,
                FieldType.Sex,
                FieldType.ExpiryDate,
                FieldType.ExpiryDateCheckDigit,
                FieldType.OptionalData,
                FieldType.OverallCheckDigit
            };

            var actual = target.FieldTypes.ToList();

            Assert.Equal(expected.Length, actual.Count());
            Assert.Equal(expected, actual);
        }
    }
}