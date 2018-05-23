using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayResultat b;
            b = ArrayBeregn(new int[] { 2, 4, 6 });
            Console.WriteLine(b.sum);

            System.Console.ReadLine();

        }

        static ArrayResultat ArrayBeregn(int[] arrayTal)
        {
            ArrayResultat a;
            a.sum = 10;
            a.gennemsnit = 20;

            return a;
        }

        struct ArrayResultat
        {
            public double sum;
            public double gennemsnit;
        }
    }
}
