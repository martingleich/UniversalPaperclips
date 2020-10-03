using System;
using System.Collections.Immutable;
using System.Windows.Forms;
using UniversalPaperclip;

namespace UniversalPaperclipUI
{
	public partial class UniversalPaperclipsUI : Form
	{
		private readonly Game Game = new Game(0);
		private readonly Action<VisibleState> RefreshUI;
		private readonly CircularBuffer<UserAction> QueuedActions = new CircularBuffer<UserAction>(5);
		private readonly SettingsOwner SettingsOwner = new SettingsOwner(ImmutableArray.Create(
			NoneAutomaticPlayer.Description,
			AutomaticPlayer.Description));

		public UniversalPaperclipsUI()
		{
			InitializeComponent();

			var updates = ImmutableArray.Create(
				LinkLabel(LabelPaperclips, state => state.Paperclips),
				LinkLabel(LabelAvailableFunds, state => state.AvailableFunds),
				LinkLabel(LabelUnsoldInventory, state => state.UnsoldInventory),
				LinkLabel(LabelPricePerClip, state => state.PricePerClip),
				LinkLabel(LabelPublicDemand, state => 10 * state.PublicDemand),
				LinkLabel(LabelMarketingLevel, state => state.Marketing),
				LinkLabel(LabelMarketingCost, state => state.MarketingCost),
				LinkLabel(LabelWire, state => state.Wire),
				LinkLabel(LabelWireCost, state => state.WireCost),
				LinkLabel(LabelAutoClippers, state => state.AutoClippers),
				LinkLabel(LabelCostAutoClippers, state => state.AutoClipperCost),
				LinkButton(ButtonMakePaperclip, UserAction.MakeClip),
				LinkButton(ButtonLower, UserAction.LowerMargin),
				LinkButton(ButtonRaise, UserAction.RaiseMargin),
				LinkButton(ButtonMarketing, UserAction.BuyAds),
				LinkButton(ButtonWire, UserAction.BuyWire),
				LinkButton(ButtonAutoClippers, UserAction.BuyClipper));
			RefreshUI = state =>
			{
				foreach (var update in updates)
					update(state);
			};
		}

		private Action<VisibleState> LinkLabel<T>(Label label, Func<VisibleState, T> getValue)
		{
			label.Tag = label.Text;
			return state =>
			{
				label.Text = string.Format((string)label.Tag, getValue(state));
			};
		}

		private Action<VisibleState> LinkButton(Button button, UserAction action)
		{
			button.Click += (obj, args) => QueuedActions.Enqueue(action);
			return state =>
			{
				button.Enabled = state.CanDo(action);
			};
		}

		private VisibleState? State;
		private void TimerTick(object sender, EventArgs e)
		{
			for (int i = 0; i < Timer.Interval * SettingsOwner.CurrentSettings.SpeedFactor; ++i)
			{
				var nextAction = QueuedActions.DequeOrDefault(UserAction.None);
				if (nextAction == UserAction.None && State != null)
					nextAction = SettingsOwner.CurrentSettings.AutoPlayer.NextStep(State);
				State = Game.Tick(nextAction);
			}
			if (State != null)
				RefreshUI(State);
		}

		private void ButtonSettings_Click(object sender, EventArgs e)
		{
			SettingsOwner.ShowDialog(this);
		}
	}
}
