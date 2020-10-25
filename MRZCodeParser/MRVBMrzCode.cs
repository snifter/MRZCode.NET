using System.Collections.Generic;
using System.Linq;

namespace MRZCodeParser
{
    internal class MRVBMrzCode : MrzCode
    {
        internal MRVBMrzCode(IEnumerable<string> lines) : base(lines)
        {
        }

        public override CodeType Type => CodeType.MRVB;

        public override IEnumerable<MrzLine> Lines => new MrzLine[]
        {
            new MRVBFirstLine(RawLines.First()),
            new MRVBSecondLine(RawLines.Last())
        };
    }
}