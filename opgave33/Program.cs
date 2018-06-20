using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave31
{
    //public delegate int Beregn(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            int res;

            res = Beregner(2, 4, Plus);
            Console.WriteLine("Resultat: " + res);

            res = Beregner(2, 4, Minus);
            Console.WriteLine("Resultat: " + res);

            res = Beregner(2, 4, Gange);
            Console.WriteLine("Resultat: " + res);

            res = Beregner(8, 4, Divider);
            Console.WriteLine("Resultat: " + res);

            Console.ReadLine();
        }
        public static int Beregner(int a, int b, Func<int, int, int> funktion)
        {
            return funktion(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

    }
}
