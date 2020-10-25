namespace MRZCodeParser
{
    internal class ValueCleaner
    {
        private readonly string value;

        internal ValueCleaner(string value)
        {
            this.value = value;
        }

        internal string Clean()
        {
            return value.TrimEnd('<')
                .Replace("<<", ", ")
                .Replace("<", " ");
        }
    }
}