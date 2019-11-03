using System;
using System.Collections.Generic;
using static System.Console;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = ReadInt();
            var ans = 0;
            var listflower = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                var a = ReadInt();

                listflower.Add(a);
            }
            listflower.Sort();
            for (int i = 0; i < n-1; i++)
            {
                if (listflower[i] == listflower[i + 1])
                {
                    ans++;
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
