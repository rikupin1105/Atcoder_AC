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
        //static public List<int> ListInt = new();
        static void Main(string[] args)
        {
            var n = ReadInt();
            var oldList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var newlist = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j==0 || i==j) newlist.Add(1);
                    else
                    {
                        newlist.Add(oldList[j-1]+oldList[j]);
                    }
                }
                oldList = new List<int>(newlist);

                WriteLine(string.Join(" ", newlist));
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
