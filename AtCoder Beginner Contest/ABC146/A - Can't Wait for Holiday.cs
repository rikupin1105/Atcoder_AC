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
            var s = Read();
            switch (s)
            {
                case "SUN":
                    WriteLine("7");
                    break;
                case "MON":
                    WriteLine("6");
                    break;
                case "TUE":
                    WriteLine("5");
                    break;
                case "WED":
                    WriteLine("4");
                    break;
                case "THU":
                    WriteLine("3");
                    break;
                case "FRI":
                    WriteLine("2");
                    break;
                case "SAT":
                    WriteLine("1");
                    break;
                default:
                    break;
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
