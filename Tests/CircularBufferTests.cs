using System;
using UniversalPaperclip;
using Xunit;

namespace Tests
{
	public class CircularBufferTests
	{
		[Fact]
		public void FailNegativeLength()
		{
			Assert.Throws<ArgumentNullException>(() => new CircularBuffer<int>(-1));
		}

		[Fact]
		public void Empty()
		{
			var buffer = new CircularBuffer<int>(5);
			Assert.True(buffer.IsEmpty);
			Assert.False(buffer.IsFull);
			Assert.False(buffer.TryDeque(out var _));
		}
		[Fact]
		public void Enqueue_Empty()
		{
			var buffer = new CircularBuffer<int>(5);
			buffer.Enqueue(1);
			Assert.False(buffer.IsEmpty);
			Assert.False(buffer.IsFull);
			Assert.True(buffer.TryDeque(out var value));
			Assert.Equal(1, value);
			Assert.True(buffer.IsEmpty);
			Assert.False(buffer.IsFull);
		}
		[Fact]
		public void Enqueue_Single()
		{
			var buffer = new CircularBuffer<int>(5);
			buffer.Enqueue(1);
			buffer.Enqueue(2);
			Assert.False(buffer.IsEmpty);
			Assert.False(buffer.IsFull);
			Assert.True(buffer.TryDeque(out var value));
			Assert.Equal(1, value);
			Assert.False(buffer.IsEmpty);
			Assert.False(buffer.IsFull);
			Assert.True(buffer.TryDeque(out var value2));
			Assert.Equal(2, value2);
		}
		[Fact]
		public void Enqueue_Full()
		{
			var buffer = new CircularBuffer<int>(2);
			buffer.Enqueue(1);
			buffer.Enqueue(2);
			buffer.Enqueue(3);
			Assert.False(buffer.IsEmpty);
			Assert.True(buffer.IsFull);
			Assert.True(buffer.TryDeque(out var value));
			Assert.Equal(2, value);
			Assert.False(buffer.IsEmpty);
			Assert.False(buffer.IsFull);
			Assert.True(buffer.TryDeque(out var value2));
			Assert.Equal(3, value2);
			Assert.True(buffer.IsEmpty);
		}
		[Fact]
		public void Dequeue_Default()
		{
			var buffer = new CircularBuffer<int>(2);
			buffer.Enqueue(1);
			Assert.Equal(1, buffer.DequeOrDefault());
			Assert.Equal(0, buffer.DequeOrDefault());
			Assert.Equal(-1, buffer.DequeOrDefault(-1));
		}
	}
}
