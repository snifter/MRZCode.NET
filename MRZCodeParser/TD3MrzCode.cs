using System.Collections.Generic;
using System.Linq;

namespace MRZCodeParser
{
    internal class TD3MrzCode : MrzCode
    {
        internal TD3MrzCode(IEnumerable<string> lines) : base(lines)
        {
        }

        public override CodeType Type => CodeType.TD3;

        public override IEnumerable<MrzLine> Lines => new MrzLine[]
        {
            new TD3FirstLine(RawLines.First()),
            new TD3SecondLine(RawLines.Last())
        };
    }
}