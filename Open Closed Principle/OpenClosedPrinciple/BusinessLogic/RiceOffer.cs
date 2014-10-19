using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RiceOffer:IOffers
    {
        #region IOffers Members

        public bool IsValid
        {
            get { return true; }
        }

        public bool ShouldOfferBeApplied
        {
            get { return IsValid && CutOffForoffer >= 3; }
        }

        public int CutOffForoffer
        {
            get { return 3; }
        }

        #endregion
    }
}
