using System.Linq;
using Xunit;

namespace MRZCodeParser.Tests
{
    public class TD1DocumentLongMrzCodeTest
    {
        [Fact]
        public void CodeFieldsTest_Case1()
        {
            var target = MrzCode.Parse(MrzSamples.TD1_LONGER_DOCUMENT_ID_1);

            Assert.Equal(nameof(DocumentType.ID), target[FieldType.DocumentType]);
            Assert.Equal("BEL", target[FieldType.CountryCode]);
            Assert.Equal("111111111522", target[FieldType.DocumentNumber]);
            Assert.Equal("7", target[FieldType.DocumentNumberCheckDigit]);
            Assert.Equal("", target[FieldType.OptionalData1]);
            Assert.Equal("740812", target[FieldType.BirthDate]);
            Assert.Equal("2", target[FieldType.BirthDateCheckDigit]);
            Assert.Equal("F", target[FieldType.Sex]);
            Assert.Equal("291220", target[FieldType.ExpiryDate]);
            Assert.Equal("7", target[FieldType.ExpiryDateCheckDigit]);
            Assert.Equal("BEL", target[FieldType.Nationality]);
            Assert.Equal("11080155555", target[FieldType.OptionalData2]);
            Assert.Equal("2", target[FieldType.OverallCheckDigit]);
            Assert.Equal("ERIKSSON, ANNA MARIA", target[FieldType.Names]);
        }
        
        [Fact]
        public void CodeFieldsTest_Case2()
        {
            var target = MrzCode.Parse(MrzSamples.TD1_LONGER_DOCUMENT_ID_2);

            Assert.Equal(nameof(DocumentType.ID), target[FieldType.DocumentType]);
            Assert.Equal("UTO", target[FieldType.CountryCode]);
            Assert.Equal("1234567890", target[FieldType.DocumentNumber]);
            Assert.Equal("7", target[FieldType.DocumentNumberCheckDigit]);
            Assert.Equal("", target[FieldType.OptionalData1]);
            Assert.Equal("860101", target[FieldType.BirthDate]);
            Assert.Equal("2", target[FieldType.BirthDateCheckDigit]);
            Assert.Equal("M", target[FieldType.Sex]);
            Assert.Equal("300101", target[FieldType.ExpiryDate]);
            Assert.Equal("9", target[FieldType.ExpiryDateCheckDigit]);
            Assert.Equal("UTO", target[FieldType.Nationality]);
            Assert.Equal("", target[FieldType.OptionalData2]);
            Assert.Equal("6", target[FieldType.OverallCheckDigit]);
            Assert.Equal("SPECIMEN, JANE", target[FieldType.Names]);
        }
        
        [Theory]
        [InlineData(MrzSamples.TD1_LONGER_DOCUMENT_ID_1)]
        [InlineData(MrzSamples.TD1_LONGER_DOCUMENT_ID_2)]
        public void FieldTypeCollectionTest(string td1)
        {
            var target = MrzCode.Parse(td1);

            var expected = new[]
            {
                FieldType.DocumentType,
                FieldType.CountryCode,
                FieldType.DocumentNumber,
                FieldType.DocumentNumberCheckDigit,
                FieldType.OptionalData1,
                FieldType.BirthDate,
                FieldType.BirthDateCheckDigit,
                FieldType.Sex,
                FieldType.ExpiryDate,
                FieldType.ExpiryDateCheckDigit,
                FieldType.Nationality,
                FieldType.OptionalData2,
                FieldType.OverallCheckDigit,
                FieldType.Names
            };

            var actual = target.FieldTypes.ToList();

            Assert.Equal(expected.Length, actual.Count());
            Assert.Equal(expected, actual);
        }
    }
}