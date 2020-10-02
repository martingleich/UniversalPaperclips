using UniversalPaperclip;
using Xunit;

namespace Tests
{
	public class ClipStorageTests
	{
		[Fact]
		public void Inital()
		{
			var storage = new ClipStorage(Integer.Int(7));
			Assert.Equal(Integer.Int(7), storage.Clips);
			Assert.Equal(Integer.Int(7), storage.TotalClips);
		}
		[Fact]
		public void Add()
		{
			var storage = new ClipStorage(Integer.Int(0));
			Assert.Equal(Integer.Int(0), storage.Clips);
			Assert.Equal(Integer.Int(0), storage.TotalClips);
			storage.Add(Integer.Int(5));
			Assert.Equal(Integer.Int(5), storage.Clips);
			Assert.Equal(Integer.Int(5), storage.TotalClips);
		}
		[Fact]
		public void Take_Less()
		{
			var storage = new ClipStorage(Integer.Int(10));
			Assert.True(storage.TryTake(Integer.Int(2), out var taken));
			Assert.Equal(Integer.Int(2), taken);
			Assert.Equal(Integer.Int(8), storage.Clips);
			Assert.Equal(Integer.Int(10), storage.TotalClips);
		}
		[Fact]
		public void Take_Overflow()
		{
			var storage = new ClipStorage(Integer.Int(10));
			Assert.True(storage.TryTake(Integer.Int(12), out var taken));
			Assert.Equal(Integer.Int(10), taken);
			Assert.Equal(Integer.Int(0), storage.Clips);
			Assert.Equal(Integer.Int(10), storage.TotalClips);
		}
		[Fact]
		public void Take_None()
		{
			var storage = new ClipStorage(Integer.Int(0));
			Assert.False(storage.TryTake(Integer.Int(12), out var taken));
			Assert.Equal(Integer.Int(0), taken);
			Assert.Equal(Integer.Int(0), storage.Clips);
			Assert.Equal(Integer.Int(0), storage.TotalClips);
		}
	}
}
