using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave22
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StockItem s = new StockItem(-1);
            }
            catch (StockItemExeption ex)
            {
                Console.WriteLine("StockItem fejl - " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Generel fejl");
                throw;
            }

            Console.ReadLine();
        }
    }

    public class StockItem
    {
        public int ID { get; set; }

        public StockItem(int id)
        {
            if (id < 0)
                throw new StockItemExeption("wrong ID");
        }
    }

    public class StockItemExeption : Exception
    {
        public StockItemExeption(string message) : base(message)
        {
        }

    }
}
