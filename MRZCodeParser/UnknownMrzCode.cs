using System.Collections.Generic;
using System.Linq;

namespace MRZCodeParser
{
    internal class UnknownMrzCode : MrzCode
    {
        internal UnknownMrzCode(IEnumerable<string> lines) : base(lines)
        {
        }

        public override CodeType Type => CodeType.UNKNOWN;

        public override IEnumerable<MrzLine> Lines => RawLines.Select(x => new UnknownLine(x));
    }
}