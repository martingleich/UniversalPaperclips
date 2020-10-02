using System;

namespace UniversalPaperclip
{
	public readonly struct Integer : IEquatable<Integer>, IComparable<Integer>, IComparable
	{
		private readonly double Value;

		public static readonly Integer Zero = new Integer();
		public static Integer Int(int value) => new Integer(value);
		public static Integer Floored(double value) => new Integer(Math.Floor(value));
		public static Integer Min(Integer a, Integer b) => a > b ? b : a;
		public static Integer Max(Integer a, Integer b) => a < b ? b : a;

		private Integer(double value)
		{
			Value = value;
		}

		public static Integer operator +(Integer a, Integer b) => new Integer(a.Value + b.Value);
		public static Integer operator -(Integer a, Integer b) => new Integer(a.Value - b.Value);
		public static bool operator <(Integer left, Integer right) => left.Value < right.Value;
		public static bool operator >(Integer left, Integer right) => left.Value > right.Value;
		public static bool operator <=(Integer left, Integer right) => left.Value <= right.Value;
		public static bool operator >=(Integer left, Integer right) => left.Value >= right.Value;
		public static bool operator !=(Integer left, Integer right) => !(left == right);
		public static bool operator ==(Integer left, Integer right) => left.Equals(right);
		public bool Equals(Integer other) => Value == other.Value;
		public override bool Equals(object? obj) => obj is Integer integer && Equals(integer);
		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => $"{Value:N0}";
		public double ToDouble() => Value;

		public int CompareTo(Integer other) => Value.CompareTo(other.Value);

		public int CompareTo(object? obj)
		{
			if (obj == null)
				return -1;
			if (obj is Integer value)
				return CompareTo(value);
			throw new ArgumentException(nameof(obj));
		}
	}
}
