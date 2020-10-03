namespace UniversalPaperclipUI
{
	public class Settings
	{
		public readonly IAutomaticPlayer AutoPlayer;
		public readonly int SpeedFactor;

		public Settings(IAutomaticPlayer autoPlayer, int speedFactor)
		{
			AutoPlayer = autoPlayer;
			SpeedFactor = speedFactor;
		}
	}
}
