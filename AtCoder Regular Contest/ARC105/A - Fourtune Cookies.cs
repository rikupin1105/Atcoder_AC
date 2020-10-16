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

            var ABCD = ReadInts();
            for (int i = 0; i < 4; i++)
            {
                if (ABCD.Sum() - ABCD[i] == ABCD[i])
                {
                    WriteLine("Yes");
                    return;
                }
                for (int j = i + 1; j < 4; j++)
                {
                    if (ABCD.Sum() - ABCD[i] - ABCD[j] == ABCD[i] + ABCD[j])
                    {
                        WriteLine("Yes");
                        return;
                    }
                    for (int l = j + 1; l < 4; l++)
                    {
                        if (ABCD.Sum() - ABCD[i] - ABCD[j] - ABCD[l] == ABCD[i] + ABCD[j] + ABCD[l])
                        {
                            WriteLine("Yes");
                            return;
                        }
                    }
                }
            }
            WriteLine("No");
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
