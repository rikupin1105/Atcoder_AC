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
            var ans = "Yes";
            var before_positionX = 0;
            var before_positionY = 0;
            var before_time = 0;

            for (int i = 0; i < n; i++)
            {
                var txy = ReadInts();
                var T = txy[0];
                var X = txy[1];
                var Y = txy[2];

                var need = Abs(X - before_positionX) + Abs(Y - before_positionY);

                if (need <= T)
                {
                    //遠回りするべき数
                    var tmp = Abs(T - before_time) - need;

                    //遠回りする方法ができない時
                    //遠回りするべき数が２の倍数のときは可能
                    if (tmp % 2 != 0)
                    {
                        ans = "No";
                        break;
                    }
                }
                //そもそも届かない場合
                else
                {
                    ans = "No";
                    break;
                }

                before_positionX = X;
                before_positionY = Y;
                before_time = T;
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
    }
}
