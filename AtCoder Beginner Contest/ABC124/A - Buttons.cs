using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace At
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = 0;
            var input = ReadInts();
            var a = input[0];
            var b = input[1];
            for (int i = 0; i < 2; i++)
            {

                if (a > b)
                {
                    ans += a;
                    a--;
                }
                else
                {
                    ans += b;
                    b--;
                }
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
