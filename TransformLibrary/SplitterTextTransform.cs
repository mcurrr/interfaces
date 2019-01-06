using System;
using System.IO;
using System.Text;

namespace TransformLibrary
{
    public class SplitterTextTransform : ITextTransform
    {
        private readonly TextWriter _outputStream;

        public string Delimeter { get; set; }

        public SplitterTextTransform(TextWriter outputStream)
        {
            this._outputStream = outputStream;
            Delimeter = Environment.NewLine;
        }

        public void Output(string input)
        {
            if (String.IsNullOrEmpty(input)) return;

            var splitted = AppendAtPosition(input, 1);

            this._outputStream.Write(splitted);
        }


        private string AppendAtPosition(string baseString, int position)
        {
            var sb = new StringBuilder(baseString);

            for (int i = position; i < sb.Length; i += (position + Delimeter.Length))
                sb.Insert(i, Delimeter);

            return sb.ToString();
        }
    }
}