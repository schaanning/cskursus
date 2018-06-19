using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hunde2 = new int[4];
            hunde2[0] = 10;
            hunde2[1] = 5;
            hunde2[2] = 3;
            hunde2[3] = 8;

            Array.Sort(hunde2);
            foreach (var item in hunde2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Hund[] hunde = new Hund[4];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 3, Navn = "Tenna" };
            hunde[3] = new Hund() { Alder = 8, Navn = "Ami" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }

            Console.ReadLine();
        }
    }

    class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund h = obj as Hund;
            if (h.Alder > this.Alder)
            {
                return 1;
            }
            if (h.Alder < this.Alder)
            {
                return -1;
            }
            return 0;
        }
    }
}
