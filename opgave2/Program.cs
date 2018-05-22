using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave2
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;
            i++;
            i--;
            i += 20;

            Console.WriteLine(i);

            double d = 12.5;
            d++;
            d--;
            d *= 2;
            Console.WriteLine(d.ToString("N3")); //N3 = 1000-seperator og 3 decimaler.

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine(ft.GetHashCode());

            DateTime dd = System.DateTime.Now;
            Console.WriteLine(dd.ToString("ddMMyy"));
            Console.WriteLine(dd.ToString("dMy")); //fjerner foranstillede 0'er på både dag, måned og år.
            Console.WriteLine(dd.ToLongDateString());

            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            System.Console.ReadLine();
        }

        enum FilTyper
        {
            csv, pdf, txt
        }

        struct Person
        {
            public int Id;
            public string Navn;
        } 
    }
}
