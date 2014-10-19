using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IProduct
    {
        int GetPrice { get; }
        int Quantity { get; }
        int TotalAmount { get; }
        int Quality { get; }
        int Product { get; }
        

        


       
    }
}
