using System;
using System.Collections.Generic;
using System.Text;

namespace MRZCodeParser
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class ReplaceHelper :Attribute
    {
        public string Simple { get; set; } = " ";
        public string Double { get; set; } = ", ";

        public ReplaceHelper()
        { }

        public ReplaceHelper(string simpleReplaceText)
        {
            Simple = simpleReplaceText;
            Double = ", ";
        }

        public ReplaceHelper(string simpleReplaceText, string doubleReplaceText)
        {
            Simple = simpleReplaceText;
            Double = doubleReplaceText;
        }
    }
}
