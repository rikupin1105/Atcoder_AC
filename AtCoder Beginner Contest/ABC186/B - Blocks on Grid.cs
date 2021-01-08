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
            var HW = ReadInts();
            var list = new List<int>();
            for (int i = 0; i < HW[0]; i++)
            {
                var input = ReadInts();
                for (int j = 0; j < HW[1]; j++)
                {
                    list.Add(input[j]);
                }
            }

            WriteLine(list.Sum() - (list.Min() * HW[0] * HW[1]));
        }
        private static string Read() { return Console.ReadLine(); }
        private static string[] Reads() { return (Read().Split()); }
        private static int ReadInt() { return int.Parse(Read()); }
        private static long ReadLong() { return long.Parse(Read()); }
        private static double ReadDouble() { return double.Parse(Read()); }
        private static int[] ReadInts() { return Array.ConvertAll(Read().Split(), int.Parse); }
        private static long[] ReadLongs() { return Array.ConvertAll(Read().Split(), long.Parse); }
        private static double[] ReadDoubles() { return Array.ConvertAll(Read().Split(), double.Parse); }
    }
}
