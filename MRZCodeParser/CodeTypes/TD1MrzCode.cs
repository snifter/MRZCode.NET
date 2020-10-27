using System.Collections.Generic;
using System.Linq;

namespace MRZCodeParser.CodeTypes
{
    internal class TD1MrzCode : MrzCode
    {
        internal TD1MrzCode(IEnumerable<string> lines) : base(lines)
        {
        }

        public override CodeType Type => CodeType.TD1;

        public override IEnumerable<MrzLine> Lines => new MrzLine[]
        {
            new TD1FirstLine(RawLines.First()),
            new TD1SecondLine(RawLines.ElementAt(1)),
            new TD1ThirdLine(RawLines.Last())
        };
    }
}