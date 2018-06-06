using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave15
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Værdi = 5;
            System.Console.WriteLine(t1.Værdi);
            t1.Skriv();

            System.Console.ReadLine();

        }
    }

    class Terning
    {
        private static Random rnd = new Random();
        private int _værdi;

        public int Værdi
        {
            get { return _værdi; }
            set
            {
                if (value < 1 || value > 6)
                {
                    _værdi = 1;
                }
                else
                {
                    _værdi = value;
                }
            }
        }

        public void Ryst()
        {
            this._værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            System.Console.WriteLine("[" + this._værdi + "]");
        }

    }
}
