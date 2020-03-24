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
            var S = Read();
            var N = S.Length;
            if (KaibunCheck(S))
            {
                var a = S.Substring(0, ((N - 1) / 2));
                if (KaibunCheck(a))
                {
                    var b = S.Substring(((N + 3) / 2) - 1);
                    if (KaibunCheck(b))
                    {
                        WriteLine("Yes");
                        return;
                    }
                }
            }
            WriteLine("No");

        }
        static bool KaibunCheck(string S)
        {
            var Reversed_S = S.Reverse();
            if (S == string.Join("", Reversed_S))
            {
                return true;
            }
            else
            {
                return false;
            }
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
