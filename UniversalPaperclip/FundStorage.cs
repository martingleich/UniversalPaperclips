using System;

namespace UniversalPaperclip
{
	public class FundStorage
	{
		public Money Funds { get; private set; }

		public FundStorage(Money funds)
		{
			if (funds < Money.Zero)
				throw new ArgumentException(nameof(funds));
			Funds = funds;
		}

		public bool TryTake(Money count)
		{
			if (count < Money.Zero)
				throw new ArgumentException(nameof(count));
			if (Funds >= count)
			{
				Funds -= count;
				return true;
			}
			return false;
		}

		public void Add(Money count)
		{
			if (count < Money.Zero)
				throw new ArgumentException(nameof(count));
			Funds += count;
		}
	}
}
