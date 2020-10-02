using UniversalPaperclip;

namespace UniversalPaperclipUI
{
	public class AutomaticPlayer
	{
		public UserAction NextStep(VisibleState state)
		{
			if (state.Wire <= Integer.Int(100))
				return UserAction.BuyWire;
			return UserAction.MakeClip;
		}
	}
}
