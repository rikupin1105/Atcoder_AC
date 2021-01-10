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
            var N = ReadInt();
            var A = ReadInts();
            aaa = A.ToList();
            if (N == 1)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (aaa[j] == A.Min())
                    {
                        WriteLine(j + 1);
                        break;
                    }
                }
            }
            else
                aa(A);

        }
        static List<int> aaa;
        static List<int> aa(int[] A)
        {
            var list = new List<int>();

            for (int i = 0; i < A.Length; i += 2)
            {
                if (A[i] > A[i + 1])
                {
                    list.Add(A[i]);
                }
                else
                {
                    list.Add(A[i + 1]);
                }
            }
            if (list.Count == 2)
            {
                for (int j = 0; j < aaa.Count; j++)
                {
                    if (aaa[j] == list.Min())
                    {
                        WriteLine(j + 1);
                        break;
                    }
                }
                return list;
            }
            return aa(list.ToArray());
        }
        private static string Read() { return Console.ReadLine(); }
        private static string[] Reads() { return (Read().Split()); }
        private static int ReadInt() { return int.Parse(Read()); }
        private static long ReadLong() { return long.Parse(Read()); }
        private static double ReadDouble() { return double.Parse(Read()); }
        private static int[] ReadInts() { return Array.ConvertAll(Read().Split(), int.Parse); }
        private static long[] ReadLongs() { return Array.ConvertAll(Read().Split(), long.Parse); }
        private static double[] ReadDoubles() { return Array.ConvertAll(Read().Split(), double.Parse); }
    }
}
