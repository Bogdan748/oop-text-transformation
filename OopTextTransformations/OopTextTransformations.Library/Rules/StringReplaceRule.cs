using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTextTransformations.Library.Rules
{
    public class StringReplaceRule : TransformationRule
    {

        public StringReplaceRule (string oldText, string newText)
        {
            NewText = newText;
            OldText = oldText;
        }
        public string OldText { get; }
        public string NewText { get; }

        public override string Transform(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return input.Replace(OldText, NewText);
        }
    }
}
