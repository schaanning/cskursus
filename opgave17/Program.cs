using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave17
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Fornavn = "Rolf", Efternavn = "Schaanning"};

            Elev e1 = new Elev() { Fornavn = "Asker", Efternavn = "Rasmussen", Klasselokale = "Lakale1" };

            Instruktør i1 = new Instruktør() { Fornavn = "Karina", Efternavn = "Wiedenhofer", NøgleId = 4 };

            Console.WriteLine(p1.FuldNavn());
            Console.WriteLine(e1.FuldNavn());
            Console.WriteLine(i1.FuldNavn());

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldNavn ()
        {
            return Fornavn + " " + Efternavn + " er en person";
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }

        public string FuldNavn()
        {
            return Fornavn + " " + Efternavn + " er elev";
        }
    }

    class Instruktør : Person
    {           
        public int NøgleId { get; set; }
        public string FuldNavn()
        {
            return Fornavn + " " + Efternavn + " er instruktør";
        }
    }
}
