using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave18
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom u1 = new UdvidetRandom();

            for (int ix = 1; ix < 100; ix++)
            {
                Console.WriteLine(u1.NextBool());
            }

            Console.ReadLine();

        }
    }

    class UdvidetRandom : System.Random
    {
        public bool NextBool ()
        {
            return this.Next(1, 1001) < 500;
        }
    }
}
