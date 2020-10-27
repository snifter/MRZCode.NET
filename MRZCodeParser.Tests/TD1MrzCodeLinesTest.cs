using System.Linq;
using Xunit;

namespace MRZCodeParser.Tests
{
    public class TD1MrzCodeLinesTest
    {
        [Fact]
        public void FirstLineFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.TD1).Lines.First();
            
            Assert.Equal(DocumentType.I.ToString(), target.Fields[FieldType.DocumentType].Value);
            Assert.Equal("UTO", target.Fields[FieldType.CountryCode].Value);
            Assert.Equal("D23145890", target.Fields[FieldType.DocumentNumber].Value);
            Assert.Equal("7", target.Fields[FieldType.DocumentNumberCheckDigit].Value);
            Assert.Equal("", target.Fields[FieldType.OptionalData1].Value);
        }
        
        [Fact]
        public void SecondLineFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.TD1).Lines.ElementAt(1);
            
            Assert.Equal("740812", target.Fields[FieldType.BirthDate].Value);
            Assert.Equal("2", target.Fields[FieldType.BirthDateCheckDigit].Value);
            Assert.Equal("F", target.Fields[FieldType.Sex].Value);
            Assert.Equal("120415", target.Fields[FieldType.ExpiryDate].Value);
            Assert.Equal("9", target.Fields[FieldType.ExpiryDateCheckDigit].Value);
            Assert.Equal("UTO", target.Fields[FieldType.Nationality].Value);
            Assert.Equal("", target.Fields[FieldType.OptionalData2].Value);
            Assert.Equal("6", target.Fields[FieldType.OverallCheckDigit].Value);
        }
        
        [Fact]
        public void ThirdLineFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.TD1).Lines.Last();
            
            Assert.Equal("ERIKSSON, ANNA MARIA", target.Fields[FieldType.Names].Value);
        }
    }
}