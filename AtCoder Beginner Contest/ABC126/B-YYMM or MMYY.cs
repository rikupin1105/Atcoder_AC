using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace At
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Read();
            var yy = s[0] +""+ s[1];
            var mm = s[2] +""+ s[3];
            var y = int.Parse(yy);
            var m = int.Parse(mm);
            if (y>=1&&y<=12&& m >= 1 && m <= 12)
            {
                WriteLine("AMBIGUOUS");
            }
            else if (y >= 0 && y <= 99 && m >= 1 && m <= 12)
            {
                WriteLine("YYMM");
            }
            else if (y >= 1 && y <= 12 && m >= 0 && m <= 99)
            {
                WriteLine("MMYY");
            }
            else
            {
                WriteLine("NA");
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

        //最大公約数
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

        //最小公倍数
        public static int Lcm(int a, int b)
        {
            return a * b / Gcd(a, b);
        }

    }
}
