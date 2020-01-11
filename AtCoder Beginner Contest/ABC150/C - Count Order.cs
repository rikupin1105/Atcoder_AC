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
            var n = ReadInt();
            var p = int.Parse(Read().Replace(" ",""));
            var q = int.Parse(Read().Replace(" ",""));

            var x = Enumerable.Range(1, n).ToArray();
            var all = AllPermutation(x);

            var list = new List<int>();
            foreach (var item in all)
            {
                list.Add(int.Parse(string.Join("", item)));
            }
            var p_num = list.BinarySearch(p);
            var q_num = list.BinarySearch(q);

            WriteLine(Abs(p_num - q_num));
        }

        static List<T[]> AllPermutation<T>(params T[] array) where T : IComparable
        {
            var a = new List<T>(array).ToArray();
            var res = new List<T[]>();
            res.Add(new List<T>(a).ToArray());
            var n = a.Length;
            var next = true;
            while (next)
            {
                next = false;

                // 1
                int i;
                for (i = n - 2; i >= 0; i--)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0) break;
                }
                // 2
                if (i < 0) break;

                // 3
                var j = n;
                do
                {
                    j--;
                } while (a[i].CompareTo(a[j]) > 0);

                if (a[i].CompareTo(a[j]) < 0)
                {
                    // 4
                    var tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                    Array.Reverse(a, i + 1, n - i - 1);
                    res.Add(new List<T>(a).ToArray());
                    next = true;
                }
            }
            return res;
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
