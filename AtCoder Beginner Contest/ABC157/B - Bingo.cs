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
            var a1 = ReadInts();
            var a2 = ReadInts();
            var a3 = ReadInts();

            var n = ReadInt();
            var list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var b = ReadInt();
                list.Add(b);
            }
            if (list.Contains(a1[0]) && list.Contains(a1[1]) && list.Contains(a1[2]))
            {

            }
            else if (list.Contains(a2[0]) && list.Contains(a2[1]) && list.Contains(a2[2]))
            {

            }
            else if (list.Contains(a3[0]) && list.Contains(a3[1]) && list.Contains(a3[2]))
            {

            }
            else if (list.Contains(a1[0]) && list.Contains(a2[0]) && list.Contains(a3[0]))
            {

            }
            else if (list.Contains(a1[1]) && list.Contains(a2[1]) && list.Contains(a3[1]))
            {

            }
            else if (list.Contains(a1[2]) && list.Contains(a2[2]) && list.Contains(a3[2]))
            {

            }

            else if (list.Contains(a1[0]) && list.Contains(a2[1]) && list.Contains(a3[2]))
            {

            }
            else if (list.Contains(a1[2]) && list.Contains(a2[1]) && list.Contains(a3[0]))
            {

            }
            else
            {
                WriteLine("No");
                return;
            }
            WriteLine("Yes");
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
