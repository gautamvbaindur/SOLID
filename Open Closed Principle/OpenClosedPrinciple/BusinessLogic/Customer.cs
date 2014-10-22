using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Abstractions;

namespace BusinessLogic
{
    public class Customer :ICustomers
    {
        public List<IProduct> BuyProducts()
        {
            return new List<IProduct>()
            {
                new Rice(),
            };

        }
    }
}
