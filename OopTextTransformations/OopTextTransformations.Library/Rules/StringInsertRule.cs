using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTextTransformations.Library.Rules
{
    public class StringInsertRule : TransformationRule
    {
        public StringInsertRule(int index, string value)
        {
            Index = index;
            Value = value;
        }
        public int Index { get; }
        public string Value { get; }
        public override string Transform(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return input.Insert(Index, Value);
        }
    }
}
