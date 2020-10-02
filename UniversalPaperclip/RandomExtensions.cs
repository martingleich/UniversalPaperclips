using System;

namespace UniversalPaperclip
{
	public static class RandomExtensions
	{
		public static bool True(this Random random, double probabilty)
			=> random.NextDouble() < probabilty;
	}
}
