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
            var xyz = ReadInts();
            var x = xyz[0];
            var y = xyz[1];
            var z = xyz[2];

            var ans = 0;
            if ((0 < y && y < x) || (x < y && y < 0))
            {
                //壁が間にある
                if ((0 < y && y < z)|| (z < y && y < 0))
                {
                    WriteLine(-1);
                    return;
                }
                else
                {
                    //ハンマーを取りに行く
                    ans += Abs(0-z);
                    ans += Abs(z-x);
                    WriteLine(ans);
                }
            }
            else
            {
                WriteLine(Abs(0-x));
            }
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
