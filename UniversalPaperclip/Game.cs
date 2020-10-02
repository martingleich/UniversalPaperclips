using System;

namespace UniversalPaperclip
{
	public class Game
	{
		readonly Random Random;
		readonly WireSeller WireSeller = new WireSeller();
		readonly Marketplace Marketplace = new Marketplace();
		readonly ClipperManager ClipperManager = new ClipperManager(0);

		readonly FundStorage Funds = new FundStorage(Money.Zero);
		readonly ClipStorage Clips = new ClipStorage(Integer.Zero);
		readonly WireStorage Wire = new WireStorage(Integer.Int(1000));

		ulong TickId = 0;

		bool CanBuyClippers = false;

		public Game(int seed)
		{
			Random = new Random(seed);
		}

		public VisibleState Tick(UserAction userAction)
		{
			PerformUserAction(userAction);
			AdvanceTick();
			CheckMilestones();
			return Render();
		}

		private void PerformUserAction(UserAction userAction)
		{
			switch (userAction)
			{
				case UserAction.MakeClip:
					if (Wire.TryTake(Integer.Int(1), out var taken))
						Clips.Add(taken);
					break;
				case UserAction.RaiseMargin:
					Marketplace.ChangePrice(Money.Cents(1));
					break;
				case UserAction.LowerMargin:
					Marketplace.ChangePrice(-Money.Cents(1));
					break;
				case UserAction.BuyAds:
					Marketplace.BuyAds(Funds);
					break;
				case UserAction.BuyWire:
					if (WireSeller.TryPurchaseSpool(Funds, out var wire))
						Wire.Add(wire);
					break;
				case UserAction.BuyClipper:
					ClipperManager.TryPurchase(Funds);
					break;
				case UserAction.None:
				default:
					break;
			}
		}

		private VisibleState Render() => new VisibleState(
				paperclips: Clips.TotalClips,
				availableFunds: Funds.Funds,
				unsoldInventory: Clips.Clips,
				pricePerClip: Marketplace.Margin,
				publicDemand: Marketplace.Demand,
				marketing: Marketplace.MarketingLevel,
				marketingCost: Marketplace.MarketingCost,
				wire: Wire.Wire,
				wireCost: WireSeller.Cost,
				autoClippers: ClipperManager.ClipperCount,
				autoClipperCost: ClipperManager.Cost);

		private void CheckMilestones()
		{
			if (!CanBuyClippers)
				CanBuyClippers = Funds.Funds >= ClipperManager.Cost;
		}

		private void AdvanceTick()
		{
			if (TickId % 100 == 0)
			{
				WireSeller.Tick(Random);
				Marketplace.Tick(Clips, Funds, Random);
			}
			if (TickId % 10 == 0)
			{
				var clips = ClipperManager.ProduceClips(Wire);
				Clips.Add(clips);
			}

			++TickId;
		}
	}
}
