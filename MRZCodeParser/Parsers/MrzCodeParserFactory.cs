namespace MRZCodeParser.Parsers
{
    internal static class MrzCodeParserFactory
    {
        internal static IMrzCodeParser Create(CodeType codeType)
        {
            return codeType switch
            {
                CodeType.TD1 => new Td1MrzCodeParser(),
                CodeType.TD2 => new Td2MrzCodeParser(),
                CodeType.TD3 => new Td3MrzCodeParser(),
                CodeType.MRVA => new MrvaMrzCodeParser(),
                CodeType.MRVB => new MrvbMrzCodeParser(),
                _ => null // never occurs because in this case exception is thrown in CodeTypeDetector
            };
        }
    }
}