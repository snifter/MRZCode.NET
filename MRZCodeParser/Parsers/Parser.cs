using System.Collections.Generic;
using MRZCodeParser.CodeTypes;

namespace MRZCodeParser.Parsers
{
    internal class Parser : IMrzCodeParser
    {
        private readonly CodeType codeType;

        public Parser(CodeType codeType)
        {
            this.codeType = codeType;
        }

        public MrzCode Parse(IEnumerable<string> lines)
        {
            return codeType switch
            {
                CodeType.TD1 => new TD1MrzCode(lines),
                CodeType.TD2 => new TD2MrzCode(lines),
                CodeType.TD3 => new TD3MrzCode(lines),
                CodeType.MRVA => new MRVAMrzCode(lines),
                CodeType.MRVB => new MRVBMrzCode(lines),
                _ => null // never occurs because in this case exception is thrown in CodeTypeDetector
            };
        }
    }
}