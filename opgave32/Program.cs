using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave32
{
    public delegate void MinDelegate(string tekst);

    class Program
    {
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            m.Log += AppendLog;
            m.StartMaskine();
            m.StopMaskine();

            Console.ReadLine();
        }

        static void AppendLog(string tekst)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", tekst + "\r\n");
        } 
    }

    public class Maskine
    {
        public MinDelegate Log { get; set; }

        public void StartMaskine()
        {
            Log(DateTime.Now.ToLongTimeString() + " Starter");
        }
        public void StopMaskine()
        {
            Log(DateTime.Now.ToLongTimeString() + " Stop");
        }

    }
}
