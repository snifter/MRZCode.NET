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
    }
}