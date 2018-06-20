using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave35
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int> { 5, 1, 51, 7, 1, 56, 36, 5 };

            Console.WriteLine(a.FindIndex(Find));

            Console.WriteLine(a.FindIndex((int i) => { return i == 56; }));
            
            Console.WriteLine(a.FindIndex(i => i == 56));

            a.ForEach(ListVærdi);

            Console.WriteLine();

            a.ForEach(i=> { Console.Write(i + " "); });

            Console.ReadLine();
        }

        public static bool Find(int i)
        {
            return i == 56;
        }

        public static void ListVærdi(int i)
        {
            Console.Write(i + " ");
        }
    }
}
