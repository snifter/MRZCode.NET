using System.Collections.Generic;
using MRZCodeParser.CodeTypes;
using Xunit;

namespace MRZCodeParser.Tests
{
    public class MrzLineTest
    {
        [Theory]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        [InlineData("a", 1)]
        [InlineData("ab", 2)]
        [InlineData("I<UTOD231458907<<<<<<<<<<<<<<<", 30)]
        [InlineData("P<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<<<<<<<<<", 44)]
        public void Length(string input, int expected)
        {
            var target = new TestMrzLine(input);
            Assert.Equal(expected, target.Length);
        }


        [Fact]
        public void ExceptionIfCodeDoesNotMatchPattern()
        {
            const string invalidLine = @"L8988901C4XXX4009078R96121096ZE184226B<<<<<<"; // invalid sex value

            Assert.Throws<MrzCodeException>(() => new MRVASecondLine(invalidLine).Fields);
        }
    }

    internal class TestMrzLine : MrzLine
    {
        public TestMrzLine(string value) : base(value)
        {
        }

        protected override string Pattern { get; }
        internal override IEnumerable<FieldType> FieldTypes { get; }
    }
}