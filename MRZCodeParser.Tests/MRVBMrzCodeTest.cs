using Xunit;

namespace MRZCodeParser.Tests
{
    public class MRVBMrzCodeTest
    {
        [Fact]
        public void FirstLineFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.MRVB);
            
            Assert.Equal(DocumentType.V.ToString(), target.Fields[FieldType.DocumentType].Value);
            Assert.Equal("UTO", target.Fields[FieldType.CountryCode].Value);
            Assert.Equal("ERIKSSON, ANNA MARIA", target.Fields[FieldType.PrimaryIdentifier].Value);
        }
        
        [Fact]
        public void SecondLineFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.MRVB);
            
            Assert.Equal("L8988901C", target.Fields[FieldType.DocumentNumber].Value);
            Assert.Equal("4", target.Fields[FieldType.DocumentNumberCheckDigit].Value);
            Assert.Equal("XXX", target.Fields[FieldType.Nationality].Value);
            Assert.Equal("400907", target.Fields[FieldType.BirthDate].Value);
            Assert.Equal("8", target.Fields[FieldType.BirthDateCheckDigit].Value);
            Assert.Equal("F", target.Fields[FieldType.Sex].Value);
            Assert.Equal("961210", target.Fields[FieldType.ExpiryDate].Value);
            Assert.Equal("9", target.Fields[FieldType.ExpiryDateCheckDigit].Value);
            Assert.Equal("", target.Fields[FieldType.OptionalData2].Value);
        }
    }
}