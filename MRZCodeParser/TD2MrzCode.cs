using System.Collections.Generic;
using System.Linq;

namespace MRZCodeParser
{
    internal class TD2MrzCode : MrzCode
    {
        internal TD2MrzCode(IEnumerable<string> lines) : base(lines)
        {
        }

        public override CodeType Type => CodeType.TD2;

        public override IEnumerable<MrzLine> Lines => new MrzLine[]
        {
            new TD2FirstLine(RawLines.First()),
            new TD2SecondLine(RawLines.Last())
        };
    }
}