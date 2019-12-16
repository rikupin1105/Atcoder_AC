using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var ny = ReadInts();
            var N = ny[0];
            var Y = ny[1];

            //iが1000円
            //jが5000円
            //kが10000円

            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= N - i; j++)
                {
                    var k = N - i - j;
                    if (1000 * i + 5000 * j + 10000 * k == Y)
                    {
                        WriteLine($"{k} {j} {i}");
                        return;
                    }
                }
            }
            WriteLine("-1 -1 -1");
        }
        private static string Read() { return ReadLine(); }
        private static string[] Reads() { return (Read().Split()); }
        private static int ReadInt() { return int.Parse(Read()); }
        private static long ReadLong() { return long.Parse(Read()); }
        private static double ReadDouble() { return double.Parse(Read()); }
        private static int[] ReadInts() { return Array.ConvertAll(Read().Split(), int.Parse); }
        private static long[] ReadLongs() { return Array.ConvertAll(Read().Split(), long.Parse); }
        private static double[] ReadDoubles() { return Array.ConvertAll(Read().Split(), double.Parse); }
    }
}
