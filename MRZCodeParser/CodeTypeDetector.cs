using System.Collections.Generic;
using System.Linq;

namespace MRZCodeParser
{
    internal class CodeTypeDetector
    {
        private readonly IEnumerable<string> lines;

        /// <summary>
        /// Countries that use TD1 with long document number (30 characters).
        /// </summary>
        private readonly IEnumerable<string> Countries_LongDocNumber = new List<string> { "BEL" };

        internal CodeTypeDetector(IEnumerable<string> lines)
        {
            this.lines = lines;
        }

        internal CodeType DetectType()
        {
            CodeType type = lines.Count() == 3 && lines.First().Length == 30
                ? Countries_LongDocNumber.Contains(lines.First().Substring(2,3)) 
                ? CodeType.TD1_LONG_DOC_NUMBER : CodeType.TD1
                : lines.First().Length == 44 && lines.Count() == 2
                    ? lines.First()[0] == 'P'
                        ? CodeType.TD3
                        : CodeType.MRVA
                    : lines.First().Length == 36 && lines.Count() == 2
                        ? lines.First()[0] == 'V'
                            ? CodeType.MRVB
                            : CodeType.TD2
                        : CodeType.UNKNOWN;

            return type;
        }
    }
}