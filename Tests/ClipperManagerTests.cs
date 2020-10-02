using UniversalPaperclip;
using Xunit;

namespace Tests
{
	public class ClipperManagerTests
	{
		[Fact]
		public void Initial()
		{
			var manager = new ClipperManager(0);
			Assert.Equal(0ul, manager.ClipperCount);
			Assert.Equal(Money.Dollar(5), manager.Cost);
		}
		[Fact]
		public void Purchase_Enough()
		{
			var funds = new FundStorage(Money.Dollar(7));
			var manager = new ClipperManager(0);
			manager.TryPurchase(funds);
			Assert.Equal(Money.Dollar(2), funds.Funds);
			Assert.Equal(1ul, manager.ClipperCount);
			Assert.Equal(Money.Cents(610), manager.Cost);
		}
		[Fact]
		public void Purchase_Missing()
		{
			var funds = new FundStorage(Money.Dollar(3));
			var manager = new ClipperManager(0);
			manager.TryPurchase(funds);
			Assert.Equal(Money.Dollar(3), funds.Funds);
			Assert.Equal(0ul, manager.ClipperCount);
			Assert.Equal(Money.Cents(500), manager.Cost);
		}

		[Fact]
		public void Produce_NoWire()
		{
			var wire = new WireStorage(Integer.Zero);
			var manager = new ClipperManager(1);
			for (int i = 0; i < (int)(10/manager.ClipsPerTick); ++i) // Run long enough to produce 10 clips
			{
				var value = manager.ProduceClips(wire);
				Assert.Equal(Integer.Zero, value);
			}
		}
		[Fact]
		public void Produce_EnoughWire_LessThan1()
		{
			var wire = new WireStorage(Integer.Int(int.MaxValue));
			var manager = new ClipperManager(1);
			int ticks = 1000;
			Integer min = Integer.Int(int.MaxValue);
			Integer max = Integer.Int(int.MinValue);
			Integer total = Integer.Zero;
			for (int i = 0; i < ticks; ++i)
			{
				var value = manager.ProduceClips(wire);
				total += value;
				min = Integer.Min(min, value);
				max = Integer.Max(max, value);
			}
			Assert.Equal(Integer.Zero, min);
			Assert.Equal(Integer.Int(1), max);
			Assert.Equal(Integer.Int(10), total);
		}
		[Fact]
		public void Produce_EnoughWire_MoreThan1()
		{
			var wire = new WireStorage(Integer.Int(int.MaxValue));
			var manager = new ClipperManager(975);
			Integer min = Integer.Int(int.MaxValue);
			Integer max = Integer.Int(int.MinValue);
			Integer total = Integer.Zero;
			for (int i = 0; i < 1000; ++i)
			{
				var value = manager.ProduceClips(wire);
				total += value;
				min = Integer.Min(min, value);
				max = Integer.Max(max, value);
			}
			Assert.Equal(Integer.Int(9), min);
			Assert.Equal(Integer.Int(10), max);
			Assert.Equal(Integer.Int(9750), total);
		}
		[Fact]
		public void Produce_WireShortage_LessThan1()
		{
			var wire = new WireStorage(Integer.Int(int.MaxValue));
			var manager = new ClipperManager(1000);
			Integer min = Integer.Int(int.MaxValue);
			Integer max = Integer.Int(int.MinValue);
			Integer total = Integer.Zero;
			for (int i = 0; i < 1000; ++i)
			{
				if (i == 333)
					wire.TryTake(wire.Wire, out var _);
				else if (i == 666)
					wire.Add(Integer.Int(int.MaxValue));
				var value = manager.ProduceClips(wire);
				total += value;
				min = Integer.Min(min, value);
				max = Integer.Max(max, value);
			}
			Assert.Equal(Integer.Int(0), min);
			Assert.Equal(Integer.Int(10), max);
			Assert.InRange(total, Integer.Int(6600), Integer.Int(6700));
		}
	}
}
