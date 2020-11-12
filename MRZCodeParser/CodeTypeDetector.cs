using System;
using System.Collections.Generic;
using System.Linq;

namespace MRZCodeParser
{
    internal class CodeTypeDetector
    {
        private readonly IEnumerable<string> lines;

        internal CodeTypeDetector(IEnumerable<string> lines)
        {
            this.lines = lines;
        }

        internal CodeType DetectType()
        {
            CodeType type = lines.Count() == 3 && lines.First().Length == 30
                ? CodeType.TD1
                : lines.First().Length == 44 && lines.Count() == 2
                    ? lines.First()[0] == 'P'
                        ? CodeType.TD3
                        : CodeType.MRVA
                    : lines.First().Length == 36 && lines.Count() == 2
                        ? lines.First()[0] == 'V'
                            ? CodeType.MRVB
                            : CodeType.TD2
                        : throw new MrzCodeException($"Unknown MRZ code: {string.Join(Environment.NewLine, lines)}");

            return type;
        }
    }
}