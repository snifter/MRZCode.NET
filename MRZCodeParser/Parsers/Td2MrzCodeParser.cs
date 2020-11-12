using System.Collections.Generic;
using System.Linq;
using MRZCodeParser.CodeTypes;

namespace MRZCodeParser.Parsers
{
    internal class Td2MrzCodeParser : IMrzCodeParser
    {
        public MrzCode Parse(IEnumerable<string> lines)
        {
            var enumerable = lines.ToList();

            return new MrzCode.Builder(CodeType.TD2)
                .AddLine(new TD2FirstLine(enumerable.First()))
                .AddLine(new TD2SecondLine(enumerable.Last()))
                .Build();
        }
    }
}