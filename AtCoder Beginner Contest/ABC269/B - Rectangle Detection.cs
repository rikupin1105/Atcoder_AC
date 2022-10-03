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
            int a = 0, b = 0, c = 0, d = 0;

            var flag = false;
            for (int i = 0; i < 10; i++)
            {
                var s = Read();
                if (s.Contains('#') && !flag)
                {
                    c = s.IndexOf('#') + 1;
                    d = s.LastIndexOf('#') + 1;

                    a = i + 1;
                    flag = true;
                }
                if (s.Contains('#') && flag)
                {
                    b = i + 1;
                }

            }
            WriteLine(a + " " + b);
            WriteLine(c + " " + d);
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
