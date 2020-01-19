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
            var ab = ReadInts();
            var list = new List<string>();

            var tmp = "";
            for (int i = 0; i < ab[0]; i++)
            {
                tmp += ab[1];
            }
            list.Add(tmp);
            tmp = "";
            for (int i = 0; i < ab[1]; i++)
            {
                tmp += ab[0];
            }
            list.Add(tmp);

            list.Sort();
            WriteLine(list[0]);
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
