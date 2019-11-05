using System;
using System.Collections.Generic;
using System.IO;
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
            var p = ReadInts();

            var other = 0;
            for (int i = 0; i < n; i++)
            {
                if (p[i]!=i+1)
                {
                    other++;
                }
            }

            if (other == 2 || other == 0)
            {
                WriteLine("YES");
            }
            else
            {
                WriteLine("NO");
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


    public static bool IsPrime(int num)
    {
        if (num < 2) return false;
        else if (num == 2) return true;
        else if (num % 2 == 0) return false;

        double sqrtNum = Sqrt(num);
        for (int i = 3; i <= sqrtNum; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

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
    public static void debuglist(List<int> x)
    {
        foreach (var item in x)
        {
            WriteLine(item);
        }
    }
    public static void debuglist(List<string> x)
    {
        foreach (var item in x)
        {
            WriteLine(item);
        }
    }
    public static void debugarray(int[] x)
    {
        foreach (var item in x)
        {
            WriteLine(item);
        }
    }
    public static void debugarray(string[] x)
    {
        foreach (var item in x)
        {
            WriteLine(item);
        }
    }
}
}
