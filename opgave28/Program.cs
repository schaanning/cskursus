using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave28
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            Console.WriteLine(b);
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 4 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 8 });
            b.TilføjKort(new Kort() { Kulør = "Klør", Værdi = 6 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 2 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();
            b.Vis();

            Console.ReadLine();
        }
    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }

    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public void TilføjKort(Kort k)
        {
            bunke.Push(k);
        }

        public Kort FjernKort()
        {
            return bunke.Pop();
        }

        public void Vis()
        {
            foreach (var item in bunke)
            {
                //Console.WriteLine(item.Kulør + " " + item.Værdi);
                Console.WriteLine(item.ToString());
            }
        }
    }
}
