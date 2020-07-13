using System;
using System.Collections.Generic;
using System.IO;
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
            var ans = new int[10050];
            for (int i = 1; i <= 105; i++)
            {
                for (int j = 1; j <= 105; j++)
                {
                    for (int k = 1; k <= 105; k++)
                    {
                        var v = i * i + j * j + k * k + i * j + j * k + k * i;
                        if (v < 10050)
                            ans[v] += 1;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                WriteLine(ans[i + 1]);
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
