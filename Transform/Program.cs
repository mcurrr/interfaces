using System;
using System.IO;


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
            rainbowed.Output(input);
            Console.WriteLine();

            BackwardsTextTransform backwards = new BackwardsTextTransform(outputStream);
            backwards.Output(input);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
