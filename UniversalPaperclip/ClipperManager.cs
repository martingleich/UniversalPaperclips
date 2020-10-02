using System;

namespace UniversalPaperclip
{
	public class ClipperManager
	{
		public ulong ClipperCount { get; private set; } = 0;
		public Money Cost => Money.Dollar(5) + (ClipperCount > 0 ? Money.FlooredCents(100 * Math.Pow(1.1, ClipperCount)) : Money.Zero);
		public double ClipsPerTick => 0.01 * ClipperCount;

		public void TryPurchase(FundStorage funds)
		{
			if(funds.TryTake(Cost))
				ClipperCount += 1;
		}

		double Queue;

		public ClipperManager(ulong clipperCount)
		{
			ClipperCount = clipperCount;
		}

		public Integer ProduceClips(WireStorage wire)
		{
			Queue += ClipsPerTick;
			wire.TryTake(Integer.Floored(Queue), out var taken);
			Queue -= Math.Floor(Queue);
			return taken;
		}
	}
}
