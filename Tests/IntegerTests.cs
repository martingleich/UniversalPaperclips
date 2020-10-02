using UniversalPaperclip;
using Xunit;

namespace Tests
{
	public class IntegerTests
	{
		[Fact]
		public void Default()
		{
			var value = new Integer();
			Assert.Equal(0, value.ToDouble());
		}
		[Fact]
		public void Zero()
		{
			var value = Integer.Zero;
			Assert.Equal(0, value.ToDouble());
		}
		[Fact]
		public void Floored_Int()
		{
			var value = Integer.Floored(5);
			Assert.Equal(5, value.ToDouble());
		}
		[Fact]
		public void Floored_Fraction()
		{
			var value = Integer.Floored(5.5);
			Assert.Equal(5, value.ToDouble());
		}
		[Fact]
		public void Int()
		{
			var value = Integer.Int(7);
			Assert.Equal(7, value.ToDouble());
		}
		[Theory]
		[InlineData(1, 1, 2)]
		[InlineData(1, 2, 1)]
		public void Min(double result, int a, int b)
		{
			var value = Integer.Min(Integer.Int(a), Integer.Int(b));
			Assert.Equal(result, value.ToDouble());
		}
		[Fact]
		public void Plus()
		{
			var value = Integer.Int(5) + Integer.Int(7);
			Assert.Equal(12, value.ToDouble());
		}
		[Fact]
		public void Minus()
		{
			var value = Integer.Int(5) - Integer.Int(7);
			Assert.Equal(-2, value.ToDouble());
		}
		[Fact]
		public void Less()
		{
			Assert.True(Integer.Int(5) < Integer.Int(7));
			Assert.False(Integer.Int(5) < Integer.Int(5));
			Assert.False(Integer.Int(7) < Integer.Int(5));
		}
		[Fact]
		public void Greater()
		{
			Assert.True(Integer.Int(7) > Integer.Int(5));
			Assert.False(Integer.Int(5) > Integer.Int(5));
			Assert.False(Integer.Int(5) > Integer.Int(7));
		}
		[Fact]
		public void LessEqual()
		{
			Assert.True(Integer.Int(5) <= Integer.Int(7));
			Assert.True(Integer.Int(5) <= Integer.Int(5));
			Assert.False(Integer.Int(7) <= Integer.Int(5));
		}
		[Fact]
		public void GreaterEqual()
		{
			Assert.True(Integer.Int(7) >= Integer.Int(5));
			Assert.True(Integer.Int(5) >= Integer.Int(5));
			Assert.False(Integer.Int(5) >= Integer.Int(7));
		}
		[Fact]
		public void Equal()
		{
			Assert.True(Integer.Int(5) == Integer.Int(5));
			Assert.False(Integer.Int(7) == Integer.Int(5));
		}
		[Fact]
		public void NotEqual()
		{
			Assert.True(Integer.Int(7) != Integer.Int(5));
			Assert.False(Integer.Int(5) != Integer.Int(5));
		}
		[Fact]
		public void EqualsObject()
		{
			Assert.False(Integer.Int(7).Equals("str"));
			Assert.False(Integer.Int(7).Equals(null));
			Assert.False(Integer.Int(7).Equals(Integer.Int(5)));
			Assert.True(Integer.Int(5).Equals(Integer.Int(5)));
		}
		[Fact]
		public void IntToString()
		{
			Assert.Equal("1234", Integer.Int(1234).ToString());
		}
	}
}
