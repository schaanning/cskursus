using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave24
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h1 = new Hund();

            IDbFunktioner i1;
            IDbFunktioner i2 = new Ubåd();

            i1 = h1;

            i1.Gem();
            i2.Gem();

            Console.WriteLine(h1.Rase());
            

            System.Console.ReadLine();
        }
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund.");
        }

        public string Rase()
        {
            return "Rasen er: Hyrdehund.";
        }
    }

    class Ubåd: IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Ubåd.");
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }
}
