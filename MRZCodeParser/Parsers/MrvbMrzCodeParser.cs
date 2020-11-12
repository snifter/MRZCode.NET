using System.Collections.Generic;
using System.Linq;
using MRZCodeParser.CodeTypes;

namespace MRZCodeParser.Parsers
{
    internal class MrvbMrzCodeParser : IMrzCodeParser
    {
        public MrzCode Parse(IEnumerable<string> lines)
        {
            var enumerable = lines.ToList();

            return new MrzCode.Builder(CodeType.MRVB)
                .AddLine(new MRVBFirstLine(enumerable.First()))
                .AddLine(new MRVBSecondLine(enumerable.Last()))
                .Build();
        }
    }
}