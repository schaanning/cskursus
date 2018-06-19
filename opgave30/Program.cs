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
            p1.TilføjPerson(new Instruktør() { Navn = "Rolf", Alder = 42, InstruktørNummer = 101 });
            p1.TilføjPerson(new Kursist() { Navn = "Karina", Alder = 47, KursistNummer = 201 });

            p1.Vis();

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public virtual int Nummer ()
        {

            return 0;
        }
    }

    public class Kursist : Person
    {
        public int KursistNummer { get; set; }
        public override int Nummer()
        {
            return KursistNummer;
        }
    }

    public class Instruktør : Person
    {
        public int InstruktørNummer { get; set; }
        public override int Nummer()
        {
            return InstruktørNummer;
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
                Console.WriteLine(item.Navn + " " + item.Alder + " " + item.Nummer());
            }
        }


    }

}
