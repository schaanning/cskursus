using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave5
{
    class Program
    {
        static void Main(string[] args)
        {

            string fornavn = "Rolf";
            string efternavn = "Schaanning";

            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string del = samletNavn.Substring(6, 3);
            Console.WriteLine(del);

            string[] arrayNavn = samletNavn.Split(' ');

            for (int i = 0; i < arrayNavn.Length; i++)
            {
                Console.WriteLine(arrayNavn[i]);
            }

            string text1 = "tewr\tklods\r\netyu";
            Console.WriteLine(text1);

            System.IO.File.WriteAllText("c:\\temp\\opgave5.txt", text1);

            System.Console.ReadLine();


        }
    }
}
