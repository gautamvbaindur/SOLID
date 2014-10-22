using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Rice:IProduct
    {
        public int GetPrice
        {
            get { return 30; }
        }

        public int Quantity
        {
            get { return 3; }
        }

        public int TotalAmount
        {
            get { return GetPrice*Quantity; }
        }

        public IOffers GetOffer
        {
            get
            {
                return new RiceOffer();
            }
        }
    }
}
