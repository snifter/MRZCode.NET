using Xunit;

namespace MRZCodeParser.Tests
{
    public class TD3MrzCodeTest
    {
        [Fact]
        public void FirstLineFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.TD3);
            
            Assert.Equal(DocumentType.P.ToString(), target.Fields[FieldType.DocumentType].Value);
            Assert.Equal("UTO", target.Fields[FieldType.CountryCode].Value);
            Assert.Equal("ERIKSSON, ANNA MARIA", target.Fields[FieldType.PrimaryIdentifier].Value);
        }
        
        [Fact]
        public void SecondLineFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.TD3);
            
            Assert.Equal("L898902C3", target.Fields[FieldType.DocumentNumber].Value);
            Assert.Equal("6", target.Fields[FieldType.DocumentNumberCheckDigit].Value);
            Assert.Equal("UTO", target.Fields[FieldType.Nationality].Value);
            Assert.Equal("740812", target.Fields[FieldType.BirthDate].Value);
            Assert.Equal("2", target.Fields[FieldType.BirthDateCheckDigit].Value);
            Assert.Equal("F", target.Fields[FieldType.Sex].Value);
            Assert.Equal("120415", target.Fields[FieldType.ExpiryDate].Value);
            Assert.Equal("9", target.Fields[FieldType.ExpiryDateCheckDigit].Value);
            Assert.Equal("ZE184226B", target.Fields[FieldType.OptionalData2].Value);
            Assert.Equal("1", target.Fields[FieldType.OptionalData2CheckDigit].Value);
            Assert.Equal("0", target.Fields[FieldType.OverallCheckDigit].Value);
        }
    }
}