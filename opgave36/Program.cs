using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave36
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            //w.Changed += FilÆndret;
            w.Changed += (a, b) => { Console.WriteLine(b.Name); };
            do
            {

            } while (true);

        }

        private static void FilÆndret(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name);
        }

    }
}
