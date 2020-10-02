using System;

namespace UniversalPaperclip
{
	class WireSeller
	{
		public Money Cost { get; private set; }
		Money BasePrice = Money.Dollar(20);
		double PriceCounter = 0;
		ulong Timer = 0;
		readonly Integer PerSpool = Integer.Int(1000);

		public WireSeller()
		{
			Cost = BasePrice;
		}

		public void Tick(Random source)
		{
			Timer += 1;
			if(Timer > 250 && BasePrice > Money.Dollar(15))
			{
				BasePrice *= 0.999;
				Timer = 0;
			}

			if(source.True(0.015))
			{
				PriceCounter += 1;
				var adjust = Money.FlooredCents(600 * Math.Sin(PriceCounter));
				Cost = BasePrice + adjust;
			}
		}

		public bool TryPurchaseSpool(FundStorage funds, out Integer wire)
		{
			if(funds.TryTake(Cost))
			{
				Timer = 0;
				BasePrice += Money.Cents(5);
				wire = PerSpool;
				return true;
			}
			else
			{
				wire = Integer.Zero;
				return false;
			}
		}
	}
}
