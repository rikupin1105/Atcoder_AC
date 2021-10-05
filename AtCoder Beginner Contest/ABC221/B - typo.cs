using System;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Read().ToCharArray();
            var t = Read().ToCharArray();

            var ans = "No";
            if (string.Join("", s)
                == string.Join("", t))
            {
                ans = "Yes";
            }
            for (int i = 0; i < s.Length - 1; i++)
            {
                var tt = new char[t.Count()];
                t.CopyTo(tt, 0);

                var tmp = tt[i];
                tt[i] = tt[i + 1];
                tt[i + 1] = tmp;

                if (string.Join("", s)
                    == string.Join("", tt))
                {
                    ans = "Yes";
                }
            }
            WriteLine(ans);
        }

        private static string Read() { return ReadLine(); }
        private static string[] Reads() { return (Read().Split()); }
        private static decimal ReadDecimal() { return decimal.Parse(Read()); }
        private static int ReadInt() { return int.Parse(Read()); }
        private static long ReadLong() { return long.Parse(Read()); }
        private static double ReadDouble() { return double.Parse(Read()); }
        private static int[] ReadInts() { return Array.ConvertAll(Read().Split(), int.Parse); }
        private static long[] ReadLongs() { return Array.ConvertAll(Read().Split(), long.Parse); }
        private static double[] ReadDoubles() { return Array.ConvertAll(Read().Split(), double.Parse); }
    }
}
