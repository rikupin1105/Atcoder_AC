using System;
using System.Collections.Generic;
using System.Linq;
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
            var list = new List<string>();
            var ans = "Yes";

            for (int i = 0; i < n; i++)
            {
                var w = Read();
                if (list.Contains(w))
                {
                    ans = "No";
                    break;
                }

                if (i != 0)
                {
                    var maenoword = list[i - 1];
                    if (maenoword[maenoword.Length-1] != w[0])
                    {
                        ans = "No";
                        break;
                    }
                }

                list.Add(w);
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
