using System;
using OopTextTransformations.Library;
using OopTextTransformations.Library.Rules;

namespace ApplicationTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world!";

            ProcessingEngine engine = new ProcessingEngine(
                new StringInsertRule(0, "Test "),
                new StringRemoveRule("Hello "),
                new StringReplaceRule("world", "C#"));

            string transform = engine.Transform(text);

            Console.WriteLine($"Old text: {text}{Environment.NewLine}New text: {transform}");
        }
    }
}
