using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UniversalPaperclipUI
{
	public partial class SettingsUI : Form
	{
		private readonly int BasePower = 10;
		private readonly int MaxPower = 5;
		private readonly int Resolution = 10;

		public Action<IAutomaticPlayer> SetPlayer { get; }
		public Action<int> SetSpeed { get; }

		public SettingsUI(IEnumerable<AutomaticPlayerDescription> players, IAutomaticPlayer selectedPlayer, int speed, Action<IAutomaticPlayer> setPlayer, Action<int> setSpeed)
		{
			InitializeComponent();
			SetPlayer = setPlayer;
			SetSpeed = setSpeed;

			foreach (var player in players)
			{
				ComboAutoPlayers.Items.Add(player);
				if (player.Name == selectedPlayer.ToString())
					ComboAutoPlayers.SelectedItem = player;
			}
			TrackSpeed.Minimum = 0;
			TrackSpeed.Maximum = MaxPower * Resolution;
			TrackSpeed.Value = (int)(Math.Log(speed, BasePower) * Resolution);
			UpdateSpeed(TrackSpeed.Value);
		}

		private void UpdateSpeed(int speed)
		{
			var newValue = (int)Math.Pow(BasePower, speed / (double)Resolution);
			TextSpeed.Text = newValue.ToString("N0");
			SetSpeed(newValue);
		}

		private void TrackSpeed_Scroll(object sender, EventArgs e)
		{
			UpdateSpeed(TrackSpeed.Value);
		}

		private void ComboAutoPlayers_SelectedIndexChanged(object sender, EventArgs e)
		{
			var newDescription = (AutomaticPlayerDescription)ComboAutoPlayers.SelectedItem;
			var newPlayer = newDescription.Create();
			SetPlayer(newPlayer);
		}
	}
}
