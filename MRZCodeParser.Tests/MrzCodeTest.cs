using System.Linq;
using Xunit;

namespace MRZCodeParser.Tests
{
    public class MrzCodeTest
    {
        [Theory]
        [InlineData(MrzSamples.TD1, CodeType.TD1)]
        [InlineData(MrzSamples.TD2, CodeType.TD2)]
        [InlineData(MrzSamples.TD3, CodeType.TD3)]
        [InlineData(MrzSamples.MRVA, CodeType.MRVA)]
        [InlineData(MrzSamples.MRVB, CodeType.MRVB)]
        [InlineData(MrzSamples.UNKNOWN, CodeType.UNKNOWN)]
        public void CodeTypeDetection(string input, CodeType expected)
        {
            var target = MrzCode.Parse(input);
            Assert.Equal(expected, target.Type);
        }

        [Theory]
        [InlineData(MrzSamples.TD1, 3)]
        [InlineData(MrzSamples.TD2, 2)]
        [InlineData(MrzSamples.TD3, 2)]
        [InlineData(MrzSamples.MRVA, 2)]
        [InlineData(MrzSamples.MRVB, 2)]
        public void LinesCount(string input, int expected)
        {
            var target = MrzCode.Parse(input);
            Assert.Equal(expected, target.Lines.Count());
        }

        [Theory]
        [InlineData(MrzSamples.TD1)]
        [InlineData(MrzSamples.TD2)]
        [InlineData(MrzSamples.TD3)]
        [InlineData(MrzSamples.MRVA)]
        [InlineData(MrzSamples.MRVB)]
        public void ToStringReturnsInputLines(string input)
        {
            var target = MrzCode.Parse(input);
            Assert.Equal(input, target.ToString());
        }

        [Theory]
        [InlineData(MrzSamples.TD1, FieldType.PrimaryIdentifier)]
        [InlineData(MrzSamples.TD1, FieldType.OptionalData)]
        [InlineData(MrzSamples.TD1, FieldType.OptionalDataCheckDigit)]
        [InlineData(MrzSamples.TD2, FieldType.Names)]
        [InlineData(MrzSamples.TD2, FieldType.OptionalDataCheckDigit)]
        [InlineData(MrzSamples.MRVB, FieldType.OverallCheckDigit)]
        public void AccessToInvalidFieldTypeWithException(string input, FieldType invalidType)
        {
            var target = MrzCode.Parse(input);
            Assert.Throws<MrzCodeException>(() => target[invalidType]);
        }

        [Fact]
        public void ExceptionIfCodeDoesNotMatchPattern()
        {
            const string invalidCode = @"V<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<<<<<<<<<
L8988901C4XXX4009078R96121096ZE184226B<<<<<<"; // invalid sex value

            Assert.Throws<MrzCodeException>(() => MrzCode.Parse(invalidCode));
        }
    }
}