using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave27
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<Person> lp1 = new List<Person>();
            lp1.Add(new Person() { Id = 1, Navn = "Rolf" });
            lp1.Add(new Person() { Id = 2, Navn = "Karina" });
            lp1.Add(new Person() { Id = 3, Navn = "PV" });

            foreach (Person item in lp1)
            {
                Console.WriteLine(item.Navn);
            }

            System.Collections.Generic.Dictionary<int, Person> dp1 = new Dictionary<int, Person>();
            dp1.Add(1, new Person() { Id = 11, Navn = "Flemming" });
            dp1.Add(2, new Person() { Id = 21, Navn = "Stine" });
            dp1.Add(3, new Person() { Id = 31, Navn = "Asker" });

            var p = dp1[1];
            Console.WriteLine(p.Navn);


            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
