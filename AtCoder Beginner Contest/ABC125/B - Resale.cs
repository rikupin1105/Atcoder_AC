using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var v = Console.ReadLine().Split(' ');
            var c = Console.ReadLine().Split(' ');

            var ans = 0;

            for (int i = 0; i < n; i++)
            {
                if (int.Parse(v[i]) > int.Parse(c[i]))
                {
                    ans += int.Parse(v[i]) - int.Parse(c[i]);
                }
            }
            Console.WriteLine(ans);
        }
    }
}
