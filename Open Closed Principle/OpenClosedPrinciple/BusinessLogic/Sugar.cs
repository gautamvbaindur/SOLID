using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Sugar : IProduct
    {
        public int GetPrice
        {
            get { return 40; }
        }

        public int Quantity
        {
            get { return 1; }
        }

        public int TotalAmount
        {
            get { return GetPrice * Quantity; }
        }

        public IOffers GetOffer
        {
            get { throw new NotImplementedException(); }
        }
    }
}
