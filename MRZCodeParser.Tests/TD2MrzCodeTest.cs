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
            Assert.Equal("", target[FieldType.OptionalData2]);
            Assert.Equal("6", target[FieldType.OverallCheckDigit]);
        }
    }
}