using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave7
{
    class Program
    {
        static void Main(string[] args)
        {

            int tal1 = lægSammen(3,5);
            Console.WriteLine(tal1);

            Console.WriteLine(beregnAreal(10));

            Udskriv();

            Udskriv("Hej Rolf.");

            Console.WriteLine($"momsen er {BeregnMoms(100)} kr.");

            Console.WriteLine($"momsen er {BeregnMoms(100,0.20)} kr.");

            //int[] talRække = { 2, 4, 5, 9 };
            Console.WriteLine($"gennemsnit af tallene i arrayet er {BeregnGennemsnit(new int[] { 2, 4, 5, 9 })}"); //new skal med fordi det er en reference?!?!?
            //Console.WriteLine($"gennemsnit af tallene i arrayet er {BeregnGennemsnit(talRække)}");

            System.Console.ReadLine();

        }

        static int lægSammen(int a, int b)
        {
            return a + b;
        }

        static double beregnAreal(int radius)
        {
            return System.Math.Pow(radius,2) * System.Math.PI;
        }

        static void Udskriv(string text)
        {
            Console.WriteLine(text);
        }
        static void Udskriv()
        {
            Console.WriteLine();
        }
        static double BeregnMoms(int beløb, double moms = 0.25)
        {
            return beløb * moms;
        }

        static double BeregnGennemsnit(int[] talArray)
        {
            return talArray.Average();
        }
    }
}
