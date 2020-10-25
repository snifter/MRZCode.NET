using System.Linq;
using Xunit;

namespace MRZCodeParser.Tests
{
    public class LineSplitterTest
    {
        [Theory]
        [InlineData("ab\r\nab\r\nab", 3)]
        [InlineData("ab\r\nab\r\nab\r\n", 3)]
        [InlineData("ab\nab\nab", 3)]
        [InlineData("ab\nab\nab\n", 3)]
        [InlineData("ab\r\nab", 2)]
        [InlineData("ab\r\nab\r\n", 2)]
        [InlineData("ab\nab", 2)]
        [InlineData("ab\nab\n", 2)]
        public void LineCount(string input, int expected)
        {
            var target = new LineSplitter(input);
            var actual = target.Split().Count();
            Assert.Equal(expected, actual);
        }
    }
}