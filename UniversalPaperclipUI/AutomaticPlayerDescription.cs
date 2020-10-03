using System;

namespace UniversalPaperclipUI
{
	public class AutomaticPlayerDescription
	{
		public AutomaticPlayerDescription(Func<IAutomaticPlayer> create, string name)
		{
			Create = create;
			Name = name;
		}

		public Func<IAutomaticPlayer> Create { get; }
		public string Name { get; }
		public override string ToString() => Name;
	}
}
