using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MRZCodeParser.Tests
{
    public class TD1DocumentLongMrzCodeTest
    {
        [Fact]
        public void CodeFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.TD1_LONGER_DOCUMENT_ID);

            Assert.Equal(DocumentType.ID.ToString(), target[FieldType.DocumentType]);
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
        public void FieldTypeCollectionTest()
        {
            var target = MrzCode.Parse(MrzSamples.TD1);

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