using System;
using System.Threading;

namespace UniversalPaperclip
{
	public readonly struct Money : IEquatable<Money>
	{
		readonly double Value;

		public static readonly Money Zero = new Money();
		public static Money Dollar(int dollar) => Cents(dollar * 100);
		public static Money Cents(int cents) => new Money(cents);
		public static Money FlooredCents(double cents) => new Money(Math.Floor(cents));
		public static Money Max(Money a, Money b) => a > b ? a : b;
		private Money(double cents)
		{
			Value = cents;
		}

		public static double operator/(Money a, Money b) => a.Value / b.Value;
		public static Money operator*(Money a, double count) => new Money(Math.Floor(a.Value * count));
		public static Money operator *(double count, Money a) => a * count;
		public static Money operator*(Money a, Integer count) => new Money(a.Value * count.ToDouble());
		public static Money operator *(Integer count, Money a) => a * count;
		public static Money operator-(Money a, Money b) => new Money(a.Value - b.Value);
		public static Money operator-(Money a) => new Money(-a.Value);
		public static Money operator+(Money a, Money b) => new Money(a.Value + b.Value);
		public static bool operator <(Money a, Money b) => a.Value < b.Value;
		public static bool operator >(Money a, Money b) => a.Value > b.Value;
		public static bool operator <=(Money a, Money b) => a.Value <= b.Value;
		public static bool operator >=(Money a, Money b) => a.Value >= b.Value;
		public static bool operator ==(Money left, Money right) => left.Equals(right);
		public static bool operator !=(Money left, Money right) => !(left == right);
		public override bool Equals(object? obj) => obj is Money money && Equals(money);
		public bool Equals(Money other) => Value == other.Value;
		public override int GetHashCode() => HashCode.Combine(Value);
		public override string ToString()
		{
			var dollars = Math.Floor(Value / 100);
			var completeCents = (int)(Value - 100 * dollars);
			var seperator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			return $"$ {dollars:N0}{seperator}{completeCents:D2}";
		}
	}
}
