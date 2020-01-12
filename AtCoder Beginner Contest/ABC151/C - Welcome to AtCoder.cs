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
            int[] wa = new int[NM[0]+1];
            int[] ac = new int[NM[0]+1];

            var Count_AC = 0;
            var Count_WA = 0;

            for (int i = 0; i < NM[1]; i++)
            {
                var pS = Reads();
                var p = int.Parse(pS[0]);
                var S = pS[1];

                if(ac[p] == 0)
                {
                    if (S == "WA")
                    {
                        wa[p]++;
                    }
                    else
                    {
                        ac[p]=1;
                        Count_WA += wa[p];
                        Count_AC++;
                    }
                }
            }

            WriteLine($"{Count_AC} {Count_WA}");
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
