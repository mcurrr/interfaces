using System;
using System.IO;
using System.Linq;

namespace Transform
{
    public class RainbowTextTransform : ITextTransform
    {
        private readonly Random _random;
        private readonly Array _values;
        private readonly TextWriter _outputStream;

        public RainbowTextTransform(TextWriter outputStream)
        {
            this._random = new Random();
            this._values = Enum.GetValues(typeof(ConsoleColor));
            this._outputStream = outputStream;
        }

        public void Output(string input)
        {
            if (String.IsNullOrEmpty(input)) return;

            ConsoleColor initialColor = Console.ForegroundColor;

            // changing forground color for each character
            input.ToList().ForEach(x =>
            {
                var randomEnumIndex = this._random.Next(this._values.Length);
                var randomValue = this._values.GetValue(randomEnumIndex);

                Console.ForegroundColor = (ConsoleColor)randomValue;
                this._outputStream.Write(x);
            });

            // back to initial
            Console.ForegroundColor = initialColor;
        }
    }
}
