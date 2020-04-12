using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO.Pipes;
using System.Linq;
using System.Numerics;
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
            var N = ReadInt();
            long ans = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 == 0)
                {

                }
                else if (i % 5 == 0)
                {

                }
                else
                {
                    ans += i;
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
