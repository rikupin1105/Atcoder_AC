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
            var x = ReadInt();
            int ans = 0;
            if (x >= 1800) ans = 1;
            else if (x >= 1600) ans = 2;
            else if (x >= 1400) ans = 3;
            else if (x >= 1200) ans = 4;
            else if (x >= 1000) ans = 5;
            else if (x >= 800) ans = 6;
            else if (x >= 600) ans = 7;
            else if (x >= 400) ans = 8;
            WriteLine(ans);
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
