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

            RainbowTextTransform rainbowed = new RainbowTextTransform();
            rainbowed.Output(input, outputStream);
            Console.WriteLine();

            BackwardsTextTransform backwards = new BackwardsTextTransform();
            backwards.Output(input, outputStream);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
