using System.Collections.Generic;

namespace MRZCodeParser.Parsers
{
    internal interface IMrzCodeParser
    {
        MrzCode Parse(IEnumerable<string> lines);
    }
}