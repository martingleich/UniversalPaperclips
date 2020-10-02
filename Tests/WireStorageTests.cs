using System;
using UniversalPaperclip;
using Xunit;

namespace Tests
{
	public class WireStorageTests
	{
		[Fact]
		public void Initial()
		{
			var storage = new WireStorage(Integer.Int(123));
			Assert.Equal(Integer.Int(123), storage.Wire);
		}
		[Fact]
		public void Initial_Fail()
		{
			Assert.Throws<ArgumentException>(() => new WireStorage(Integer.Int(-123)));
		}
		[Fact]
		public void TryTake_Available()
		{
			var storage = new WireStorage(Integer.Int(123));
			Assert.True(storage.TryTake(Integer.Int(10), out var taken));
			Assert.Equal(Integer.Int(10), taken);
			Assert.Equal(Integer.Int(113), storage.Wire);
		}
		[Fact]
		public void TryTake_Missing()
		{
			var storage = new WireStorage(Integer.Int(123));
			Assert.True(storage.TryTake(Integer.Int(125), out var taken));
			Assert.Equal(taken, Integer.Int(123));
			Assert.Equal(Integer.Int(0), storage.Wire);
		}
		[Fact]
		public void TryTake_Nothing()
		{
			var storage = new WireStorage(Integer.Int(0));
			Assert.False(storage.TryTake(Integer.Int(125), out var taken));
			Assert.Equal(taken, Integer.Int(0));
			Assert.Equal(Integer.Int(0), storage.Wire);
		}
		[Fact]
		public void TryTake_Exact()
		{
			var storage = new WireStorage(Integer.Int(123));
			Assert.True(storage.TryTake(Integer.Int(123), out var taken));
			Assert.Equal(Integer.Int(123), taken);
			Assert.Equal(Integer.Int(0), storage.Wire);
		}
		[Fact]
		public void TryTake_Negative()
		{
			var storage = new WireStorage(Integer.Int(123));
			Assert.Throws<ArgumentException>(() => storage.TryTake(Integer.Int(-20), out var _));
		}
		[Fact]
		public void Add()
		{
			var storage = new WireStorage(Integer.Int(123));
			storage.Add(Integer.Int(20));
			Assert.Equal(Integer.Int(143), storage.Wire);
		}
		[Fact]
		public void Add_Negative()
		{
			var storage = new WireStorage(Integer.Int(123));
			Assert.Throws<ArgumentException>(() => storage.Add(Integer.Int(-20)));
		}
	}
}
