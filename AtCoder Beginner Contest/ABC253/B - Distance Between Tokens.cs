using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw = ReadInts();

            var list = new List<List<int>>();

            for (int i = 0; i < hw[0]; i++)
            {
                var s = Read().ToCharArray();
                for (int j = 0; j < hw[1]; j++)
                {
                    if (s[j] == 'o')
                    {
                        list.Add(new List<int> { i, j });
                    }
                }
            }
            WriteLine(Abs(list[0][0]-list[1][0])+ Abs(list[0][1]-list[1][1]));
        }

        private static string Read() { return ReadLine(); }
        private static string[] Reads() { return (Read().Split()); }
        private static decimal ReadDecimal() { return decimal.Parse(Read()); }
        private static int ReadInt() { return int.Parse(Read()); }
        private static long ReadLong() { return long.Parse(Read()); }
        private static double ReadDouble() { return double.Parse(Read()); }
        private static int[] ReadInts() { return Array.ConvertAll(Read().Split(), int.Parse); }
        private static long[] ReadLongs() { return Array.ConvertAll(Read().Split(), long.Parse); }
        private static double[] ReadDoubles() { return Array.ConvertAll(Read().Split(), double.Parse); }
    }
}
