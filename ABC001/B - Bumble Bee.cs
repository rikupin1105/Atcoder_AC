using System;
using System.Collections.Generic;
using System.Linq;

namespace at
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int tmp = 0;
            
            if(x<100)
            {
                Console.WriteLine("00");
            }
            else if(x >= 100 && x <= 5000)
            {
                tmp = x*10/1000;
                if(tmp<10)
                {
                    Console.WriteLine("0"+tmp);
                }
                else
                {
                    Console.WriteLine(tmp);
                }
            }
            else if(x >= 6000 && x <= 30000)
            {
                Console.WriteLine(x/1000+50);
            }
            else if(x >= 35000 && x <= 70000)
            {
                Console.WriteLine((x/1000-30)/5+80);
            }
            else if(x >= 70000)
            {
                Console.WriteLine(89);
            }
        
        }
    }
}
