using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rice needed");
            int riceQuantity  = Convert.ToInt32(Console.ReadLine());

            IProduct rice = new Rice();

            List<IProduct> llst = new List<IProduct>()
            {
                new Rice(),
                new Sugar()
            };

            ISuperMarket nilgiris = new NilgirisSuperMarket();



        }
    }
}
