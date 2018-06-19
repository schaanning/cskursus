using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave26
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.IO.StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt"))
            //System.IO.StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt");
                while (stream.Peek() != -1)
            {
                string navn = stream.ReadLine();
                Console.WriteLine(navn);
            }

            //stream.Close();
            //stream = null;

            Console.ReadLine();

        }
    }
}
