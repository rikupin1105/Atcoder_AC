using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Compression;
using System.IO.Pipes;
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
            var A = ABCD[0];
            var B = ABCD[1];
            var C = ABCD[2];
            var D = ABCD[3];

            while (true)
            {
                C = C - B;
                if (C <= 0)
                {
                    WriteLine("Yes");
                    return;
                }
                A = A - D;
                if (A <= 0)
                {
                    WriteLine("No");
                    return;
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
