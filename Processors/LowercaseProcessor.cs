using System;

namespace Processors {
    public class LowercaseProcessor : TextTransformationProcessor
    {
        public override void Process(ref string text) {
            text.ToLower();
        }   
    }

    public abstract class TextTransformationProcessor : IProcessor<string> {

        public abstract void Process(ref string text);
    }
}