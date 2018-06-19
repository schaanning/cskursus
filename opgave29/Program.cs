using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave29
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 25;

            //Swap<int>(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();

            string s1 = "Rolf";
            string s2 = "Karina";

            //Swap<string>(ref s1, ref s2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();

            Swap(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();

            Swap(ref s1, ref s2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();


            Console.ReadLine();
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
