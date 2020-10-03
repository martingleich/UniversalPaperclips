using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Windows.Forms;

namespace UniversalPaperclipUI
{
	public sealed class SettingsOwner
	{
		public ImmutableArray<AutomaticPlayerDescription> AutomaticPlayers { get; }

		private SettingsUI? CurUi;
		public Settings CurrentSettings { get; private set; }
		public Subject<Settings> OnSettingsSubject { get; } = new Subject<Settings>();
		public IObservable<Settings> OnSettings => OnSettingsSubject.AsObservable();

		public SettingsOwner(ImmutableArray<AutomaticPlayerDescription> automaticPlayers)
		{
			AutomaticPlayers = automaticPlayers;
			CurrentSettings = new Settings(AutomaticPlayers.First().Create(), 1);
		}

		public void ShowDialog(Form owner)
		{
			if (CurUi == null)
			{
				var ui = new SettingsUI(AutomaticPlayers, CurrentSettings.AutoPlayer, CurrentSettings.SpeedFactor, SetPlayer, SetSpeed);
				CurUi = ui;
				ui.FormClosing += (sender, args) => { CurUi = null; };
				ui.Show(owner);
			}
			else
			{
				CurUi.Owner = owner;
				CurUi.WindowState = FormWindowState.Normal;
				CurUi.BringToFront();
			}
		}

		private void UpdateSettings(Func<Settings, Settings> update)
		{
			CurrentSettings = update(CurrentSettings);
			OnSettingsSubject.OnNext(CurrentSettings);
		}
		private void SetPlayer(IAutomaticPlayer player)
		{
			UpdateSettings(s => new Settings(player, s.SpeedFactor));
		}
		private void SetSpeed(int speed)
		{
			UpdateSettings(s => new Settings(s.AutoPlayer, speed));
		}
	}
}
