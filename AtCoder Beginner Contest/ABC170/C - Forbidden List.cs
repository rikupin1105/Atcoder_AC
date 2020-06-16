using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var XY = ReadInts();
            int[] listP;
            if (XY[1] == 0)
            {
                WriteLine(XY[0]);
                return;
            }
            else
            {
                listP = ReadInts();
            }

            for (int i = 0; i < 101; i++)
            {
                if (!listP.Contains(XY[0] - i))
                {
                    WriteLine(XY[0] - i);
                    return;
                }
                else if (!listP.Contains(XY[0] + i))
                {
                    WriteLine(XY[0] + i);
                    return;
                }
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
