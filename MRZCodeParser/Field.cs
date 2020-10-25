namespace MRZCodeParser
{
    public class Field
    {
        public FieldType Type { get; }
        public string Value { get; }

        public Field(FieldType type, string value)
        {
            Type = type;
            Value = value;
        }
    }
}