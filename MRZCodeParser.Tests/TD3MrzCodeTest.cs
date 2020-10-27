using Xunit;

namespace MRZCodeParser.Tests
{
    public class TD3MrzCodeTest
    {
        [Fact]
        public void CodeFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.TD3);
            
            Assert.Equal(DocumentType.P.ToString(), target[FieldType.DocumentType]);
            Assert.Equal("UTO", target[FieldType.CountryCode]);
            Assert.Equal("ERIKSSON, ANNA MARIA", target[FieldType.PrimaryIdentifier]);
            Assert.Equal("L898902C3", target[FieldType.DocumentNumber]);
            Assert.Equal("6", target[FieldType.DocumentNumberCheckDigit]);
            Assert.Equal("UTO", target[FieldType.Nationality]);
            Assert.Equal("740812", target[FieldType.BirthDate]);
            Assert.Equal("2", target[FieldType.BirthDateCheckDigit]);
            Assert.Equal("F", target[FieldType.Sex]);
            Assert.Equal("120415", target[FieldType.ExpiryDate]);
            Assert.Equal("9", target[FieldType.ExpiryDateCheckDigit]);
            Assert.Equal("ZE184226B", target[FieldType.OptionalData2]);
            Assert.Equal("1", target[FieldType.OptionalData2CheckDigit]);
            Assert.Equal("0", target[FieldType.OverallCheckDigit]);
        }
    }
}