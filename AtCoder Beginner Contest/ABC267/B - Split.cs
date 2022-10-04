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
        static void Main(string[] args)
        {
            var s = Read();
            var column = new List<bool>() { false, false, false, false, false, false, false };

            if (s[0] == '0')
            {
                if (s[7-1]=='1')
                    column[0] = true;


                if (s[4-1]=='1')
                    column[1] = true;


                if (s[8-1]=='1' || s[2-1]=='1')
                    column[2] = true;


                if (s[5-1]=='1' || s[1-1]=='1')
                    column[3] = true;

                if (s[9-1]=='1' || s[3-1]=='1')
                    column[4] = true;


                if (s[6-1]=='1')
                    column[5] = true;


                if (s[10-1]=='1')
                    column[6] = true;

                var frag1 = false;
                var frag2 = false;

                for (int i = 0; i < column.Count; i++)
                {
                    if (column[i] && frag1 && frag2)
                    {
                        WriteLine("Yes");
                        return;
                    }
                    else if (column[i])
                    {
                        frag1 = true;
                    }
                    else if (column[i]==false && frag1)
                    {
                        frag2 = true;
                    }
                }
                WriteLine("No");
            }
            else
            {
                WriteLine("No");
                return;
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
