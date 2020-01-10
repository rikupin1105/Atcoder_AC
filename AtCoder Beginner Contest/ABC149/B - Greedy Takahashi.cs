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
            var abk = ReadLongs();
            //高橋
            var takahashi = abk[0];
            //青木
            var aoki = abk[1];
            var K = abk[2];

            var ansA = Max(takahashi - K, 0);
            var nokori = Max(K - takahashi, 0);
            var ansB = aoki - nokori;

            WriteLine(Max(ansA,0) + " " + Max(ansB,0));
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
