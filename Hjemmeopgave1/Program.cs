using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjemmeopgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person k1 = new Person();
            k1.navn = "Rolf";
            Person k2 = new Person();
            k2.navn = "Karina";


            Console.WriteLine(k1.navn);
            Console.WriteLine(k2.navn);

            k1 = k2;

            Console.WriteLine(k1.navn);
            Console.WriteLine(k2.navn);

            k1.navn = "Schaanning";

            Console.WriteLine(k1.navn);
            Console.WriteLine(k2.navn);

            System.Console.ReadLine();
        }

        class Person
        {
            public string navn;
        }
    }
}
