using System;
using System.IO;
using System.Linq;

namespace Transform
{
    public class RainbowTextTransform : ITextTransform
    {
        private readonly Random _random;
        private readonly Array _values;

        public RainbowTextTransform()
        {
            this._random = new Random();
            this._values = Enum.GetValues(typeof(ConsoleColor));
        }

        public void Output(string input, TextWriter outputStream)
        {
            if (String.IsNullOrEmpty(input)) return;

            ConsoleColor initialColor = Console.ForegroundColor;

            // changing forground color for each character
            input.ToList().ForEach(x =>
            {
                var randomEnumIndex = this._random.Next(this._values.Length);
                var randomValue = this._values.GetValue(randomEnumIndex);

                Console.ForegroundColor = (ConsoleColor)randomValue;
                outputStream.Write(x);
            });

            // back to initial
            Console.ForegroundColor = initialColor;
        }
    }
}
