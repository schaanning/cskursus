using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave11
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            System.Console.ReadLine();
        }             
    }

    public class Terning
    {
        public int værdi;
        private bool snyd;

        private static Random rnd = new Random();

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;
        }

        public void Skriv()
        {
            System.Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            if (this.snyd == false)
                this.værdi = rnd.Next(1, 7);
            else
                this.værdi = 6;
        }

    }
}
