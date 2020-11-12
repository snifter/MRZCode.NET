namespace MRZCodeParser.Parsers
{
    internal static class MrzCodeParserFactory
    {
        internal static IMrzCodeParser Create(CodeType codeType)
        {
            return new Parser(codeType);
        }
    }
}