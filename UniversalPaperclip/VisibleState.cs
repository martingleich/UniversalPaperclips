namespace UniversalPaperclip
{
	public class VisibleState
	{
		public readonly Integer Paperclips;
		public readonly Money AvailableFunds;
		public readonly Integer UnsoldInventory;
		public readonly Money PricePerClip;
		public readonly double PublicDemand;
		public readonly ulong Marketing;
		public readonly Money MarketingCost;
		public readonly Integer Wire;
		public readonly Money WireCost;
		public readonly ulong AutoClippers;
		public readonly Money AutoClipperCost;

		public VisibleState(Integer paperclips, Money availableFunds, Integer unsoldInventory, Money pricePerClip, double publicDemand, ulong marketing, Money marketingCost, Integer wire, Money wireCost, ulong autoClippers, Money autoClipperCost)
		{
			Paperclips = paperclips;
			AvailableFunds = availableFunds;
			UnsoldInventory = unsoldInventory;
			PricePerClip = pricePerClip;
			PublicDemand = publicDemand;
			Marketing = marketing;
			MarketingCost = marketingCost;
			Wire = wire;
			WireCost = wireCost;
			AutoClippers = autoClippers;
			AutoClipperCost = autoClipperCost;
		}

		public bool CanDo(UserAction userAction) => userAction switch
		{
			UserAction.MakeClip => Wire > Integer.Zero,
			UserAction.RaiseMargin => true,
			UserAction.LowerMargin => PricePerClip > Money.Cents(1),
			UserAction.BuyAds => AvailableFunds >= MarketingCost,
			UserAction.BuyWire => AvailableFunds >= WireCost,
			UserAction.BuyClipper => AvailableFunds >= AutoClipperCost,
			_ => false,
		};
	}
}
