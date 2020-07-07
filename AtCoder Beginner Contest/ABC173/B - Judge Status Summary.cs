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
            var N = ReadInt();
            var AC = 0;
            var WA = 0;
            var TLE = 0;
            var RE = 0;
            for (int i = 0; i < N; i++)
            {
                var s = Read();
                switch (s)
                {
                    case "AC":
                        AC++;
                        break;
                    case "WA":
                        WA++;
                        break;
                    case "TLE":
                        TLE++;
                        break;
                    case "RE":
                        RE++;
                        break;
                    default:
                        break;
                }
            }
            WriteLine("AC x " + AC);
            WriteLine("WA x " + WA);
            WriteLine("TLE x " + TLE);
            WriteLine("RE x " + RE);
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
