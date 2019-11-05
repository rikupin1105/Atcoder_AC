using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var abcd = ReadLongs();
            var a = abcd[0];
            var b = abcd[1];
            var c = abcd[2];
            var d = abcd[3];
            var lcm = Lcm(c, d);

            //1-200
            var sbaia = b / c;
            var sbaib = b / d;
            var kbaia = (a-1) / c;
            var kbaib = (a-1) / d;

            //一番
            var q = sbaia - kbaia;
            //WriteLine(q);

            //二番
            var w = sbaib - kbaib;
            //WriteLine(w);

            //三番
            var e = b / lcm - (a-1) / lcm;
            //WriteLine(e);

            //四番
            var r = q + w - e;
            //WriteLine(r);

            //碁盤
            var tmp = b - (a - 1);
            WriteLine(tmp - r);

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

        public static long Gcd(long a, long b)
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
        public static long Lcm(long a, long b)
        {
            return a * b / Gcd(a, b);
        }

        //文字数を数える
        public static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }
        static long fibonacci(int n)
        {
            switch (n)
            {
                case 0:
                case 1:
                    return n;
                default:
                    return fibonacci(n - 2) + fibonacci(n - 1);
            }
        }
    }
}
