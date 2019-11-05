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
            var NL = ReadInts();
            var N = NL[0];
            var L = NL[1];

            var list = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                list.Add(L + i - 1);
            }

            var ans = 100000;
            int res = 100000;
            var x = 1;
            foreach (var item in list)
            {
                var tmp = Math.Abs(item - 0);
                if (ans > tmp)
                {
                    ans = tmp;
                    res = tmp;
                    if(item - 0 < 0)
                    {
                        x = -1;
                    }
                    else
                    {
                        x = 1;
                    }
                }
            }
            WriteLine(list.Sum() - res * x);
            
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
