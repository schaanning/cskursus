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
            b = ArrayBeregn(new int[] { 4, 2, 6 });
            Console.WriteLine(b.sum);
            Console.WriteLine(b.gennemsnit);

            System.Console.ReadLine();

        }

        static ArrayResultat ArrayBeregn(int[] arrayTal)
        {
            ArrayResultat a;
            Array.Sort(arrayTal);
            a.sum = arrayTal.Sum();
            a.gennemsnit = a.sum / arrayTal.Length;

            return a;
        }

        struct ArrayResultat
        {
            public double sum;
            public double gennemsnit;
        }
    }
}
