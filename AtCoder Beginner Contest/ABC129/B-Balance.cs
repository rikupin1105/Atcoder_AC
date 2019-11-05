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
            var n = ReadInt();
            var w = ReadInts();
            var ans = new List<int>();
            var sum = w.Sum();
            var tmp = 0;
            for (int i = 0; i < n; i++)
            {
                tmp += w[i];
                var s1 = tmp;
                var s2 = sum-tmp;
                ans.Add(Math.Abs(s1 - s2));
            }
            WriteLine(ans.Min());
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

        //文字数を数える
        public static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }
    }
}
