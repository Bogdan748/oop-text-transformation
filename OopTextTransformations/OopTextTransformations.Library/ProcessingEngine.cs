using OopTextTransformations.Library.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTextTransformations.Library
{
    public class ProcessingEngine
    {
        public ProcessingEngine (params TransformationRule[] rules)
        {
            Rules = rules ?? new TransformationRule[0];
        }
        public TransformationRule[] Rules { get; }

        public string Transform(string input)
        {
            string result = input;
            foreach(TransformationRule rule in Rules)
            {
                result = rule.Transform(result);
            }
            return result;
        }
    }
}
