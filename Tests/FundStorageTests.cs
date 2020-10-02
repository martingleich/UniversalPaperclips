using System;
using UniversalPaperclip;
using Xunit;

namespace Tests
{
	public class FundStorageTests
	{
		[Fact]
		public void Initial()
		{
			var storage = new FundStorage(Money.Dollar(123));
			Assert.Equal(Money.Dollar(123), storage.Funds);
		}
		[Fact]
		public void Initial_Fail()
		{
			Assert.Throws<ArgumentException>(() => new FundStorage(Money.Dollar(-123)));
		}
		[Fact]
		public void TryTake_Available()
		{
			var storage = new FundStorage(Money.Dollar(123));
			Assert.True(storage.TryTake(Money.Dollar(10)));
			Assert.Equal(Money.Dollar(113), storage.Funds);
		}
		[Fact]
		public void TryTake_Missing()
		{
			var storage = new FundStorage(Money.Dollar(123));
			Assert.False(storage.TryTake(Money.Dollar(125)));
			Assert.Equal(Money.Dollar(123), storage.Funds);
		}
		[Fact]
		public void TryTake_Exact()
		{
			var storage = new FundStorage(Money.Dollar(123));
			Assert.True(storage.TryTake(Money.Dollar(123)));
			Assert.Equal(Money.Dollar(0), storage.Funds);
		}
		[Fact]
		public void TryTake_Negative()
		{
			var storage = new FundStorage(Money.Dollar(123));
			Assert.Throws<ArgumentException>(() => storage.TryTake(Money.Dollar(-20)));
		}
		[Fact]
		public void Add()
		{
			var storage = new FundStorage(Money.Dollar(123));
			storage.Add(Money.Dollar(20));
			Assert.Equal(Money.Dollar(143), storage.Funds);
		}
		[Fact]
		public void Add_Negative()
		{
			var storage = new FundStorage(Money.Dollar(123));
			Assert.Throws<ArgumentException>(() => storage.Add(Money.Dollar(-20)));
		}
	}
}
