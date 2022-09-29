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
            var abc = ReadInts();
            var ans = 3;
            if (abc[0] == abc[1]) ans--;
            if (abc[0] == abc[2]) ans--;
            if (abc[1] == abc[2]) ans--;
            if (ans == 0) ans = 1;
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

    }
}
