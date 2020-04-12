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
            var K = ReadInt();
            var list = new List<int>();
            for (int i = 1; i <= K; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    for (int l = 1; l <= K; l++)
                    {
                        list.Add(Gcd(Gcd(i, j), l));
                    }
                }
            }
            WriteLine(list.Sum());
        }
        public static int Gcd(int a, int b)
        {
            if (a < b)
            {
                return Gcd(b, a);
            }
            while (b != 0)
            {
                var reminder = a % b;
                a = b;
                b = reminder;
            }
            return a;
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
