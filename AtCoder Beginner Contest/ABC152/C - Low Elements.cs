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
            var n = ReadInt();
            var p = ReadInts();
            var ans = 0;
            var max = p[0];
            var min = p[0];

            ans = 0;
            for (int i = 0; i < n; i++)
            {
                var boo = true;
                if (p[i] <= max)
                {
                    if (p[i] <= min)
                    {
                    }
                    else
                    {
                        boo = false;
                    }
                }
                else
                {
                    boo = false;
                }

                if (boo)
                {
                    ans++;
                }
                max = Max(max, p[i]);
                min = Min(min, p[i]);
            }
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
