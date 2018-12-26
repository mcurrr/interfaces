using System;
using System.IO;
using System.Linq;

namespace Transform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter some letters");
            Rainbow rainbowed = new Rainbow();
            string input = Console.ReadLine();
 
            TextWriter outputStream = Console.Out;
            rainbowed.Output(input, outputStream);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
