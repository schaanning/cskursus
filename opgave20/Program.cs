using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hund h1 = new Hund() { Navn = "Rolf"};
            //Kat k1 = new Kat() { Navn = "Karina"};

            //h1.SigNoget();
            //k1.SigNoget();

            Dyr[] dyr = new Dyr[20];
            for (int ix = 0; ix < 20; ix++)
                dyr[ix] = Dyr.TilfældigtDyr();
            foreach (Dyr MitDyr in dyr)
            {
                MitDyr.SigNoget();
            }


            Console.ReadLine();
        }
    }

    abstract class Dyr
    {
        static System.Random rnd = new Random();

        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder " + this.Navn);
        }

        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0, navne.Length);
            if (rnd.Next(1, 3) == 1)
            {
                return new Hund { Navn = navne[index] };
            }
            else
            {
                return new Kat { Navn = navne[index] };

            }

        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + this.Navn);
        }

    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + this.Navn);
        }

    }
}
