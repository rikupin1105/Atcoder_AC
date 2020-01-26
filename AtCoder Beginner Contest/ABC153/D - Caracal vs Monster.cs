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
            var H = BigInteger.Parse(Read());


            //for (int i = 1; i <= H; i++)
            //{
            //    if (i == 1) list.Add(0);
            //    else if (i == 2) list.Add(3);
            //    else if (i == 3) list.Add(3);
            //    else
            //    {
            //        var a = Floor(i / 2.0);
            //        list.Add(list[int.Parse(a.ToString())] * 2 + 1);
            //    }
            //}
            //foreach (var item in list)
            //{
            //    Write(item + " ");
            //}
            //WriteLine(list[int.Parse(H.ToString())]);

            var list = new List<BigInteger>()
            {2, 4
, 8
, 16
, 32
, 64
, 128
, 256
            , 512
            , 1024
            , 2048
            , 4096
            , 8192
            , 16384
            , 32768
            , 65536
            , 131072
            , 262144
            , 524288
            , 1048576
            , 2097152
            , 4194304
            , 8388608
            , 16777216
            , 33554432
            , 67108864
            , 134217728
            , 268435456
            , 536870912
            , 1073741824
            , 2147483648
            , 4294967296
            , 8589934592
            , 17179869184
            , 34359738368
            , 68719476736
            , 137438953472
            , 274877906944
            , 549755813888
            , 1099511627776 };
            if (H == 1)
            {
                WriteLine(1);
            }
            else if (H == 2)
            {
                WriteLine(3);
            }
            else
            {
                for (int i = 0; i < list.Count-1; i++)
                {
                    var a = list[i];
                    var b = list[i + 1] - 1;
                    if (a <= H && H <= b)
                    {
                        WriteLine(b);
                        return;
                    }
                }
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
    }
}
