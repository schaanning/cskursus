using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave16
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(ArealBeregn.BeregnArealFirkant(10, 25));
            System.Console.WriteLine(ArealBeregn.BeregnArealCirkel(10));

            System.Console.ReadLine();
        }
    }

    static class ArealBeregn
    {
        public static double BeregnArealFirkant(double højde, double brede)
        {
            return højde * brede;
        }

        public static double BeregnArealCirkel(double radius)
        {
            //return radius * radius * System.Math.PI;
            return System.Math.Pow(radius, 2) * System.Math.PI;
        }
    }
}
