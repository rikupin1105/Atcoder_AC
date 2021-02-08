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
            var pizza = ReadInts();
            var A = pizza[0] * pizza[3] + pizza[1] * pizza[4];
            int B = int.MaxValue;
            if (pizza[3] > pizza[4])
            {
                B = (pizza[2] * Min(pizza[3], pizza[4]) * 2) + (pizza[0] * (pizza[3] - pizza[4]));
            }
            else if (pizza[4] > pizza[3])
            {
                B = (pizza[2] * Min(pizza[3], pizza[4]) * 2) + pizza[1] * (pizza[4] - pizza[3]);
            }
            var C = pizza[2] * Max(pizza[3], pizza[4]) * 2;

            WriteLine(Min(Min(A, B), C));
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
