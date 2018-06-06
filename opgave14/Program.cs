using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave14
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1._fornavn = "Rolf";
            p1.Efternavn = "Schaanning";
            System.Console.WriteLine(p1.FuldNavn);

            System.Console.ReadLine();

        }
    }

    class Person
    {
        public string _fornavn { get; set; }
        private string _efternavn;

        public string Efternavn
        {
            get { return _efternavn; }
            set
            {
                if (value.Length < 3)
                {
                    _efternavn = "";
                }
                else
                {
                    _efternavn = value;
                }
            }
        }

        public string FuldNavn
        {
            get {
                return this._fornavn + " " + _efternavn;
            }
        }

    }
}
