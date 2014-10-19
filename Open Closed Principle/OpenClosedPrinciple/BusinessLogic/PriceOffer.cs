using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PriceOffer : IOffers
    {
        #region IOffers Members

        public bool IsValid
        {
            get { return true; }
        }

        public int CutOffForoffer
        {
            get { return 1000; }
        }

        public bool ShouldOfferBeApplied
        {
            get { return IsValid && CutOffForoffer >= 1000; }
        }

        public int PriceAfterOffer
        {
            get
            {
                if(ShouldOfferBeApplied)
                    return 
            }
        }
        #endregion

    }
}
