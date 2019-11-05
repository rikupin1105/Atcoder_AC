using System;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var nd = ReadInts();
            var ans = 0;

            var list = new List<string>();
            for (int i = 0; i < nd[0]; i++)
            {
                var x = Read();
                list.Add(x);
            }

            for (int i = 0; i < nd[0]; i++)
            {
                var x1 = list[i].Split(' ');
                for (int i1 = i + 1; i1 < nd[0]; i1++)
                {
                    var x2 = list[i1].Split(' ');

                    double tmplist = 0;

                    for (int i2 = 0; i2 < nd[1]; i2++)
                    {
                        double t = (int.Parse(x1[i2]) - int.Parse(x2[i2])) * (int.Parse(x1[i2]) - int.Parse(x2[i2]));
                        tmplist += t;
                    }
                    var x = Sqrt(tmplist);
                    if (x % 1 == 0)
                    {
                        ans++;
                    }
                }

            }

            WriteLine(ans);
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
