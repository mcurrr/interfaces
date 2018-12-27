using System;
using System.IO;


namespace Transform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter some letters");
            RainbowTextTransform rainbowed = new RainbowTextTransform();
            string input = Console.ReadLine();

            TextWriter outputStream = Console.Out;
            rainbowed.Output(input, outputStream);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
