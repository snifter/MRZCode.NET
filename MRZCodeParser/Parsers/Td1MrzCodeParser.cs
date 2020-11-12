using System.Collections.Generic;
using System.Linq;
using MRZCodeParser.CodeTypes;

namespace MRZCodeParser.Parsers
{
    internal class Td1MrzCodeParser : IMrzCodeParser
    {
        public MrzCode Parse(IEnumerable<string> lines)
        {
            var enumerable = lines.ToList();

            return new MrzCode.Builder(CodeType.TD1)
                .AddLine(new TD1FirstLine(enumerable.First()))
                .AddLine(new TD1SecondLine(enumerable.ElementAt(1)))
                .AddLine(new TD1ThirdLine(enumerable.Last()))
                .Build();
        }
    }
}