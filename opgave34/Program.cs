using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave31
{
    class Program
    {
        static void Main(string[] args)
        {
            double res;
 
            res = Beregner(2, 4, FindTilfældigFunktion());
            Console.WriteLine("Resultat: " + res);

            //Lav en vent her.

            res = Beregner(2, 4, FindTilfældigFunktion());
            Console.WriteLine("Resultat: " + res);

            //Lav en vent her.

            res = Beregner(2, 4, FindTilfældigFunktion());
            Console.WriteLine("Resultat: " + res);

            //Lav en vent her.

            res = Beregner(8, 4, FindTilfældigFunktion());
            Console.WriteLine("Resultat: " + res);

            Console.ReadLine();
        }
        public static double Beregner(double a, double b, Func<double, double, double> funktion)
        {
            return funktion(a, b);
        }

        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static double Divider(double a, double b)
        {
            return a / b;
        }

        public static double Gange(double a, double b)
        {
            return a * b;
        }

        public static Func<double, double, double> FindTilfældigFunktion()
        {
            if (DateTime.Now.Millisecond < 250)
                return Plus;
            if (DateTime.Now.Millisecond < 500)
                return Minus;
            if (DateTime.Now.Millisecond < 750)
                return Divider;
            return Gange;
        }

    }
}
