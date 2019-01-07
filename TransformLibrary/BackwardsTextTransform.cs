using System;
using System.IO;
using static System.String;


namespace TransformLibrary
{
    public class BackwardsTextTransform : ITextTransform
    {
        private readonly TextWriter _outputStream;

        public BackwardsTextTransform(TextWriter outputStream)
        {
            this._outputStream = outputStream;
        }
 
        public void Output(string input)
        {
            if (IsNullOrEmpty(input)) return;

            char[] array = input.ToCharArray();
            Array.Reverse(array);
            var backwardsOutput = new String(array);

            this._outputStream.Write(backwardsOutput);
        }
    }
}
