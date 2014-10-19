using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    interface IOffers
    {
        bool IsValid { get; }
        int CutOffForoffer { get; }
        bool ShouldOfferBeApplied { get; }
        int PriceAfterOffer { get; }
    }
}
