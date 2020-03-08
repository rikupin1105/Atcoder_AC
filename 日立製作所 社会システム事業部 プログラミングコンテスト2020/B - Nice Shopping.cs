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
            var ABM = ReadInts();
            var a = ReadInts();
            var b = ReadInts();

            var anslist = new List<int>();
            var sonomama = a.Min() + b.Min();
            anslist.Add(sonomama);
                
            for (int i = 0; i < ABM[2]; i++)
            {
                var xyc = ReadInts();

                var price = a[xyc[0] - 1] + b[xyc[1] - 1] - xyc[2];
                anslist.Add(price);
            }
            WriteLine(anslist.Min());
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
