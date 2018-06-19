using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave30
{
    class Program
    {
        static void Main(string[] args)
        {
            Person1 p1 = new Person1();
            for (int i = 0; i < 10000; i++)
            {
                p1.TilføjPerson(new Instruktør() { Navn = "Rolf", Alder = 42, InstruktørNummer = 101, Løn = 10000 });
                p1.TilføjPerson(new Kursist() { Navn = "Karina", Alder = 47, KursistNummer = 201, KursusPris = 2500 });
            }

            p1.Vis();
            p1.Slet();

            p1 = null;

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public virtual void Vis()
        {
        }
        public virtual void Slet()
        {
        }
    }

    public class Kursist : Person
    {
        public int KursistNummer { get; set; }
        public int KursusPris { get; set; }
        public override void Vis()
        {
            Console.WriteLine("Kursist: " + this.Navn);
            Console.WriteLine("Alder: " + this.Alder);
            Console.WriteLine("Kursistnummer: " + this.KursistNummer);
            Console.WriteLine("Kursus pris: " + this.KursusPris);
        }
        public override void Slet()
        {
            //this = null;
        }
    }

    public class Instruktør : Person
    {
        public int InstruktørNummer { get; set; }
        public int Løn { get; set; }
        public override void Vis()
        {
            Console.WriteLine("Instruktør: " + this.Navn);
            Console.WriteLine("Alder: " + this.Alder);
            Console.WriteLine("Instruktørnummer: " + this.InstruktørNummer);
            Console.WriteLine("Instruktør løn: " + this.Løn);
        }
        public override void Slet()
        {
            //this = null;
        }
    }

    public class Person1
    {
        private List<Person> PersonListe = new List<Person>();

        public void TilføjPerson(Person p)
        {
            PersonListe.Add(p);
        }

        public void Vis()
        {
            foreach (var item in PersonListe)
            {
                item.Vis();
                Console.WriteLine();
            }
        }

        public void Slet()
        {
            foreach (var item in PersonListe)
            {
                item.Slet();
            }
            PersonListe.Clear();
            PersonListe.TrimExcess();
        }
    }

}
