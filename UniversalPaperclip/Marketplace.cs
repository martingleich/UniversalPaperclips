using System;
using System.Runtime.CompilerServices;

namespace UniversalPaperclip
{
	class Marketplace
	{
		public Money Margin { get; private set; } = Money.Cents(25);

		public double MarketingEffectivness { get; } = 1;
		public ulong MarketingLevel { get; private set; } = 1;
		public Money MarketingCost => Money.Dollar(100) * Math.Pow(2, MarketingLevel - 1);

		public double DemandBoost { get; } = 1;
		public double Demand
		{
			get
			{
				var marketing = Math.Pow(1.1, MarketingLevel - 1) * MarketingEffectivness;
				return Money.Cents(80) / Margin * marketing * DemandBoost;
			}
		}

		public void BuyAds(FundStorage funds)
		{
			if (funds.TryTake(MarketingCost))
				MarketingLevel += 1;
		}

		public void ChangePrice(Money amount)
		{
			Margin = Money.Max(Margin + amount, Money.Cents(1));
		}

		public void Tick(ClipStorage clips, FundStorage funds, Random random)
		{
			if (random.True(Demand / 100))
			{
				var count = Integer.Floored(0.7 * Math.Pow(Demand, 1.15));
				if (clips.TryTake(count, out var taken))
					funds.Add(Margin * taken);
			}
		}
	}
}
