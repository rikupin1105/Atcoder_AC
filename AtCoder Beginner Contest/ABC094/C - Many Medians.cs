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
            var N = ReadInt();
            var X = ReadInts().ToList();
            var sortedx = new List<int>(X);
            sortedx.Sort();

            int c1 = sortedx[X.Count / 2 - 1];
            int c2 = sortedx[X.Count / 2];
            for (int i = 0; i < N; i++)
            {
                if (X[i] <= c1)
                {
                    WriteLine(c2);
                }
                else
                {
                    WriteLine(c1);
                }
            }
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
