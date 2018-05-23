using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime d1 = System.DateTime.Now;
            Console.WriteLine(d1);

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(1);
            Console.WriteLine(d1);

            System.DateTime d2 = System.DateTime.Now;
            Console.WriteLine(d1.Subtract(d2).Days);

            TimeSpan t2 = new TimeSpan(16, 00, 00);
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(00, 30, 00);
            Console.WriteLine(t3);

            TimeSpan t4 = t2 - t3;
            Console.WriteLine(t4);

            TimeSpan t5 = t2 + t3;
            Console.WriteLine(t5);

//*****************************************************************
// 
//*****************************************************************

            System.Console.ReadLine();

        }
    }
}
