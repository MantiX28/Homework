using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter First Number: ");
            int num_1 = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Enter Second Number: ");
            int num_2 = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"\nThe Average Is {(num_1+num_2)/2}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
