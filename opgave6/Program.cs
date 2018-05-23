using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            string talString;
            for (int i1 = 1; i1 < 11; i1++)
            {
                for (int i2 = 1; i2 < 11; i2++)
                {
                    //string talString = (i1*i2).ToString();
                    talString = (i1 * i2).ToString();

                    if (i1 * i2 > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.Write(talString.PadLeft(4));
                }
                Console.WriteLine();
            }

            System.Console.ReadLine();

        }
    }
}
