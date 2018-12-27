using System;
using System.IO;


namespace Transform
{
    public class BackwardsTextTransform : ITextTransform
    {
        public void Output(string input, TextWriter outputStream)
        {
            if (String.IsNullOrEmpty(input)) return;

            char[] array = input.ToCharArray();
            Array.Reverse(array);
            var backwardsOutput = new String(array);

            outputStream.Write(backwardsOutput);
        }
    }
}
