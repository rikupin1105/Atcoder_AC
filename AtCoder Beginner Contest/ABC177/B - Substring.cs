using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
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
            var T = Read();
            var Ans = int.MaxValue;

            for (int i = 0; i <= S.Length - T.Length; i++)
            {
                var st = S.Substring(i, T.Length);
                var needchange = 0;
                for (int j = 0; j < T.Length; j++)
                {
                    if (st[j] != T[j])
                    {
                        needchange++;
                    }
                }
                Ans = Min(Ans, needchange);
            }
            WriteLine(Ans);
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
