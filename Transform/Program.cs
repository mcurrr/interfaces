using System;
using System.IO;
using TransformLibrary;

namespace Transform
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter outputStream = Console.Out;

            Console.WriteLine("enter some letters");
            string input = Console.ReadLine();

            RainbowTextTransform rainbowed = new RainbowTextTransform(outputStream);
            rainbowed.Output(input, "");
            Console.WriteLine();

            BackwardsTextTransform backwards = new BackwardsTextTransform(outputStream);
            backwards.Output(input, "");
            Console.WriteLine();

            SplitterTextTransform splitted = new SplitterTextTransform(outputStream);
            splitted.Output(input, "\n");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
