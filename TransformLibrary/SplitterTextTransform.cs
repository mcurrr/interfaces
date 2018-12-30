using System;
using System.IO;
using System.Text;

namespace TransformLibrary
{
    public class SplitterTextTransform : ITextTransform
    {
        private readonly TextWriter _outputStream;

        public SplitterTextTransform(TextWriter outputStream)
        {
            this._outputStream = outputStream;
        }
  
        private static string AppendAtPosition(string baseString, int position, string character)
        {
            var sb = new StringBuilder(baseString);

            for (int i = position; i < sb.Length; i += (position + character.Length))
                sb.Insert(i, character);

            return sb.ToString();
        }

        public void Output(string input, string splitter)
        {
            if (String.IsNullOrEmpty(input)) return;

            var splitted = AppendAtPosition(input, 1, splitter);

            this._outputStream.Write(splitted);
        }
    }
}