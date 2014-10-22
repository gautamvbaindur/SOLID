using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SugarOffer:IOffers
    {
        public bool IsValid
        {
            get { return false; }
        }

        public int CutOffForoffer
        {
            get { return 0; }
        }

        public bool ShouldOfferBeApplied
        {
            get { return false; }
        }
    }
}
