using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave10
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Fornavn = "Rolf";
            p1.Efternavn = "Schaanning";
            p1.Fødselsår = 1975;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());

            Person p2 = new Person("karina", "Wiedenhofer", 1971);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());


            System.Console.ReadLine();

        }
    }

    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fornavn = fornavn.ToUpper();
            this.Efternavn = efternavn.ToUpper();
            this.Fødselsår = fødselsår;
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public int Alder()
        {
            return DateTime.Now.Year - this.Fødselsår;
        }

    }
}
