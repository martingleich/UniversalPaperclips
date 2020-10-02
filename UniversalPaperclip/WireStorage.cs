using System;

namespace UniversalPaperclip
{
	public class WireStorage
	{
		public Integer Wire { get; private set; }

		public WireStorage(Integer wire)
		{
			if (wire < Integer.Zero)
				throw new ArgumentException(nameof(wire));
			Wire = wire;
		}

		public bool TryTake(Integer amount, out Integer taken)
		{
			if (amount < Integer.Zero)
				throw new ArgumentException(nameof(amount));
			taken = Integer.Min(amount, Wire);
			Wire -= taken;
			return taken > Integer.Zero;
		}

		public void Add(Integer amount)
		{
			if (amount < Integer.Zero)
				throw new ArgumentException(nameof(amount));
			Wire += amount;
		}
	}
}
