namespace UniversalPaperclip
{
	public class ClipStorage
	{
		public Integer TotalClips { get; private set; }
		public Integer Clips { get; private set;}

		public ClipStorage(Integer initial)
		{
			TotalClips = initial;
			Clips = initial;
		}

		public void Add(Integer count)
		{
			TotalClips += count;
			Clips += count;
		}

		public bool TryTake(Integer count, out Integer taken)
		{
			taken = Integer.Min(count, Clips);
			Clips -= taken;
			return taken > Integer.Zero;
		}
	}
}
