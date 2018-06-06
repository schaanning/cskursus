using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave13
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t1 = new Trekant(100,10);
            //t1.Grundlinie = 100;
            //t1.Højde = 10;
            System.Console.WriteLine(t1.Areal);

            System.Console.ReadLine();
        }
    }

    class Trekant
    {
        private int _grundlinje;

        public int Grundlinie
        {
            get; // { return _grundlinje; }
            private set; // { _grundlinje = value; }
        }

        private int _højde;

        public int Højde
        {
            get; // { return _højde; }
            private set; // { _højde = value; }
        }

        public Trekant(int grundlinje, int højde)
        {
            this._grundlinje = grundlinje;
            this._højde = højde;
        }

        public double Areal
        {
               get { return this._grundlinje * this._højde * 0.5; }
        }
    }
}
