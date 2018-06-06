using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave12
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.Navn = "MinVare";
            v1.Pris = 44;
            System.Console.WriteLine(v1.PrisMedMoms());

            Vare v2 = new Vare("MinVare2", 200);
            System.Console.WriteLine(v2.PrisMedMoms());

            System.Console.ReadLine();

        }
    }

    class Vare
    {
        public Vare()
        {
        }

        public Vare(string _navn, double _pris)
        {
            this.Navn = _navn;
            this.Pris = _pris;
        }

        private string _navn;

        public string Navn
        {   
            get { System.Console.WriteLine("Læs Navn: ");
                    return _navn; }
            set { System.Console.WriteLine("Set Navn: ");
                    _navn = value; }
        }

        private double _pris;

        public double Pris
        {   
            get { System.Console.WriteLine("Læs Pris: ");
                    return _pris; }
            set { System.Console.WriteLine("Set Pris: ");
                    _pris = value; }
        }

        public double PrisMedMoms()
        {
            return this._pris * 1.25;
        }

    }
}
