using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(beregn(1, 2));
            Console.WriteLine(beregn(1, 2, 3));
            Console.WriteLine(beregn(1, 2, 3, 4));
            System.Console.ReadLine();
        }

        static int beregn(int tal1, int tal2)
        {
            return tal1 + tal2;
        }

        static int beregn(int tal1, int tal2, int tal3)
        {
            return beregn(tal1, tal2) + tal3;
        }

        static int beregn(int tal1, int tal2, int tal3, int tal4)
        {
            return beregn(tal1, tal2, tal3) + tal4;
        }

    }
}
