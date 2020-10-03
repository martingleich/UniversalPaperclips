using UniversalPaperclip;

namespace UniversalPaperclipUI
{
	public interface IAutomaticPlayer
	{
		public UserAction NextStep(VisibleState state);
	}
}
