namespace BusinessLogic
{
    public interface IOffers
    {
        bool IsValid { get; }
        int CutOffForoffer { get; }
        bool ShouldOfferBeApplied { get; }
        //int PriceAfterOffer { get; }
    }
}
