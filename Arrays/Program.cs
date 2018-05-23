using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] løn = { 20000, 15000, 20000, 5000, 40000, 7000, 60000, 59000 };

            for (int i = 0; i < løn.Length; i++)
            {
                Console.WriteLine(løn[i]);
            }

            Console.WriteLine("Gennemsnits løn: " + løn.Average());

            Array.Sort(løn);
            løn[1] = 10;
            for (int i = 0; i < løn.Length; i++)
            {
                Console.WriteLine(løn[i]);
            }


            System.Console.ReadLine();


            //*****************************************************************
                // 
                //*****************************************************************


        }
    }
}
