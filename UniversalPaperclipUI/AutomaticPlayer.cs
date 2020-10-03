using UniversalPaperclip;

namespace UniversalPaperclipUI
{
	public class AutomaticPlayer : IAutomaticPlayer
	{
		public static readonly AutomaticPlayerDescription Description = new AutomaticPlayerDescription(() => new AutomaticPlayer(), "Reference");
		public UserAction NextStep(VisibleState state)
		{
			if (state.Wire <= Integer.Int(100))
				return UserAction.BuyWire;
			return UserAction.MakeClip;
		}
		public override string ToString() => Description.Name;
	}
}
