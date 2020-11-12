using System.Collections.Generic;
using System.Linq;
using MRZCodeParser.CodeTypes;

namespace MRZCodeParser.Parsers
{
    internal class Td3MrzCodeParser : IMrzCodeParser
    {
        public MrzCode Parse(IEnumerable<string> lines)
        {
            var enumerable = lines.ToList();

            return new MrzCode.Builder(CodeType.TD3)
                .AddLine(new TD3FirstLine(enumerable.First()))
                .AddLine(new TD3SecondLine(enumerable.Last()))
                .Build();
        }
    }
}