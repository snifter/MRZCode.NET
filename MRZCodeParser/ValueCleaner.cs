using System;
using System.Linq;
using System.Reflection;

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

        internal string Clean(FieldType f)
        {
            var member = typeof(FieldType).GetMember(f.ToString()).FirstOrDefault();
            var s_replacer = member?.GetCustomAttribute<ReplaceHelper>() ?? new ReplaceHelper(" ", ", ");

            var t_val = value.TrimEnd('<')
                .Replace("<<", s_replacer.Double)
                .Replace("<", s_replacer.Simple);

            return t_val;
        }
    }
}