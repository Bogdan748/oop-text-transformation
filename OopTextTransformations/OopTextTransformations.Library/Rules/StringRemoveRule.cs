using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTextTransformations.Library.Rules
{
    public class StringRemoveRule : TransformationRule
    {

        public StringRemoveRule(string textToRemove)
        {
            TextToRemove = textToRemove;
        }
        public string TextToRemove { get; }

        public override string Transform(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return input.Replace(TextToRemove, string.Empty);
        }
    }
}
