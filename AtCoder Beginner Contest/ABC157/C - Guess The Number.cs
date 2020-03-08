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
            var NM = ReadInts();
            var list = new List<string>();
            int ii = 0;
            switch (NM[0])
            {
                case 1:
                    ii = 0;
                    break;
                case 2:
                    ii = 10;
                    break;
                case 3:
                    ii = 100;
                    break;
            }

            for (int i = 0; i < NM[1]; i++)
            {
                var sc = Read();
                list.Add(sc);
            }

            for (int i = ii; i < 1000; i++)
            {
                var b = true;
                for (int j = 0; j < list.Count; j++)
                {
                    var a = list[j].Split(' ');
                    var s = int.Parse(a[0]);
                    var c = int.Parse(a[1]);
                    var istr = i.ToString();
                    try
                    {
                        if (istr[s - 1] != c.ToString()[0])
                        {
                            b = false;
                        }
                    }
                    catch (Exception)
                    {
                        b = false;
                    }
                }
                if (b)
                {
                    //if (i == 0)
                    //{
                    //    WriteLine(-1);
                    //    return;
                    //}
                    WriteLine(i);
                    return;
                }
            }
            WriteLine(-1);

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
