using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0 || i.ToString().Contains("3");
                bool buzz = i % 5 == 0 || i.ToString().Contains("5");
                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizz) { Console.WriteLine("Fizz"); }
                else if (buzz) { Console.WriteLine("Buzz"); }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}