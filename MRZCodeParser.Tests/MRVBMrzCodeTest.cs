using Xunit;

namespace MRZCodeParser.Tests
{
    public class MRVBMrzCodeTest
    {
        [Fact]
        public void CodeFieldsTest()
        {
            var target = MrzCode.Parse(MrzSamples.MRVB);
            
            Assert.Equal(DocumentType.V.ToString(), target[FieldType.DocumentType]);
            Assert.Equal("UTO", target[FieldType.CountryCode]);
            Assert.Equal("ERIKSSON, ANNA MARIA", target[FieldType.PrimaryIdentifier]);
            Assert.Equal("L8988901C", target[FieldType.DocumentNumber]);
            Assert.Equal("4", target[FieldType.DocumentNumberCheckDigit]);
            Assert.Equal("XXX", target[FieldType.Nationality]);
            Assert.Equal("400907", target[FieldType.BirthDate]);
            Assert.Equal("8", target[FieldType.BirthDateCheckDigit]);
            Assert.Equal("F", target[FieldType.Sex]);
            Assert.Equal("961210", target[FieldType.ExpiryDate]);
            Assert.Equal("9", target[FieldType.ExpiryDateCheckDigit]);
            Assert.Equal("", target[FieldType.OptionalData2]);
        }
    }
}