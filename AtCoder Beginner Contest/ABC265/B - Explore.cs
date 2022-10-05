using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var nmt = ReadInts();
            var n = nmt[0];
            var m = nmt[1];
            var t = nmt[2];

            var a = ReadInts();

            for (int i = 0; i < m; i++)
            {
                var input = ReadInts();
                a[input[0]-1] -= input[1];
            }

            foreach (var item in a)
            {
                if (item < t)
                {
                    t -= item;
                }
                else
                {
                    WriteLine("No");
                    return;
                }
            }
            WriteLine("Yes");
        }

        private static string Read() { return ReadLine(); }
        private static string[] Reads() { return Read().Split(); }
        private static decimal ReadDecimal() { return decimal.Parse(Read()); }
        private static int ReadInt() { return int.Parse(Read()); }
        private static long ReadLong() { return long.Parse(Read()); }
        private static double ReadDouble() { return double.Parse(Read()); }
        private static int[] ReadInts() { return Array.ConvertAll(Read().Split(), int.Parse); }
        private static long[] ReadLongs() { return Array.ConvertAll(Read().Split(), long.Parse); }
        private static double[] ReadDoubles() { return Array.ConvertAll(Read().Split(), double.Parse); }
    }
}
