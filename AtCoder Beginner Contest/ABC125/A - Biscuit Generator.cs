using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(x[2]) / int.Parse(x[0]) * int.Parse(x[1]));
        }
    }
}
