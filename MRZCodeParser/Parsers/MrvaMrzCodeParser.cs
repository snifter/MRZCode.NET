using System.Collections.Generic;
using System.Linq;
using MRZCodeParser.CodeTypes;

namespace MRZCodeParser.Parsers
{
    internal class MrvaMrzCodeParser : IMrzCodeParser
    {
        public MrzCode Parse(IEnumerable<string> lines)
        {
            var enumerable = lines.ToList();

            return new MrzCode.Builder(CodeType.MRVA)
                .AddLine(new MRVAFirstLine(enumerable.First()))
                .AddLine(new MRVASecondLine(enumerable.Last()))
                .Build();
        }
    }
}