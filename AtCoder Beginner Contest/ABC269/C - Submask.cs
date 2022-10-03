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
            var n = ReadLong();
            var binary = Convert.ToString(n, 2);

            var pattern = new List<long>();
            var ans = new List<long>();
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    pattern.Add((long)Pow(2, binary.Length-1 - i));
                }
            }

            var b = CountChar(binary, '1');
            for (int i = 0; i < Pow(2, b); i++)
            {
                var a = string.Format("{0:D"+ b +"}", long.Parse(Convert.ToString(i, 2)));

                long anstmp = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j]=='1')
                    {
                        anstmp += pattern[b-j-1];
                    }
                }
                ans.Add(anstmp);
            }

            foreach (var item in ans.OrderBy(x => x))
            {
                WriteLine(item);
            }
        }
        public static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
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
