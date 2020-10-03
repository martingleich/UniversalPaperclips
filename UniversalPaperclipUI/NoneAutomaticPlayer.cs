using UniversalPaperclip;

namespace UniversalPaperclipUI
{
	public class NoneAutomaticPlayer : IAutomaticPlayer
	{
		public static readonly AutomaticPlayerDescription Description = new AutomaticPlayerDescription(() => new NoneAutomaticPlayer(), "None");
		public UserAction NextStep(VisibleState state) => UserAction.None;
		public override string ToString() => Description.Name;
	}
}
