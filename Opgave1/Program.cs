using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 42;
            i++;

            Console.WriteLine(i);

            System.DateTime da;
            da = System.DateTime.Now;
           
            Console.WriteLine(da);

            Console.WriteLine(da.ToString("d"));

            System.DateTime d1 = System.DateTime.Now;
            System.DateTime d2 = new System.DateTime(2018, 12, 24);
            System.TimeSpan ts = d2.Subtract(d1);
            Console.WriteLine(ts.TotalDays.ToString());

            System.DateTime d3 = System.DateTime.Now.AddMonths(1);

            System.TimeSpan ts2 = new TimeSpan(15, 00, 00);
            ts2 = ts2.Add(new TimeSpan(0, 20, 10));
            Console.WriteLine(ts2);

            System.Console.ReadLine();


        }
    }
}
