using System;
using System.Diagnostics.CodeAnalysis;

namespace UniversalPaperclip
{
	public sealed class CircularBuffer<T>
	{
		readonly T[] Buffer;
		int Head;
		int Tail;
		int Length;

		public CircularBuffer(int length)
		{
			if (length < 0)
				throw new ArgumentNullException(nameof(length));
			Buffer = new T[length];
		}

		public bool IsFull => Length == Buffer.Length;
		public bool IsEmpty => Length == 0;

		public void Enqueue(T action)
		{
			Buffer[Head] = action;
			Head = Next(Head);
			if (IsFull)
				Tail = Next(Tail);
			else
				Length += 1;
		}

		public bool TryDeque([MaybeNullWhen(false)] out T dequeued)
		{
			if (IsEmpty)
			{
				dequeued = default;
				return false;
			}
			else
			{
				dequeued = Buffer[Tail];
				Tail = Next(Tail);
				Length -= 1;
				return true;
			}
		}

		public T DequeOrDefault(T @default = default) => TryDeque(out var value) ? value : @default;

		private int Next(int i) => (i + 1) % Buffer.Length;
	}
}
