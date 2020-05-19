using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO.Compression;
using System.IO.Pipes;
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
            var ABHM = ReadInts();
            var A = ABHM[0];
            var B = ABHM[1];
            var H = ABHM[2];
            var M = ABHM[3];

            var Hnokakudo = (((H * 60)+M) * 0.5) % 360;
            var Mnokakudo = (M * 6) % 360;
            //WriteLine(Hnokakudo);
            //WriteLine(Mnokakudo);

            var kakudo = Min(Abs(Hnokakudo - Mnokakudo), 360 - Abs(Hnokakudo - Mnokakudo));
            //WriteLine(kakudo);

            if (kakudo == 90)
            {
                WriteLine(Sqrt(A * A + B * B));
            }
            else
            {
                WriteLine(Sqrt(A * A + B * B - 2 * A * B * Cos(kakudo * PI / 180)));

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
