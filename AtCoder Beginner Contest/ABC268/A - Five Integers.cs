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
            var abcde = ReadInts();
            var a = new List<int>();
            var ans = 0;
            for (int i = 0; i < abcde.Length; i++)
            {
                if (!a.Contains(abcde[i]))
                {
                    a.Add(abcde[i]);
                    ans++;
                }
            }
            WriteLine(ans);
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
