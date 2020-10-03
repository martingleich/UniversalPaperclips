namespace UniversalPaperclipUI
{
	partial class SettingsUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ComboAutoPlayers = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TrackSpeed = new System.Windows.Forms.TrackBar();
			this.TextSpeed = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.TrackSpeed)).BeginInit();
			this.SuspendLayout();
			// 
			// ComboAutoPlayers
			// 
			this.ComboAutoPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboAutoPlayers.FormattingEnabled = true;
			this.ComboAutoPlayers.Location = new System.Drawing.Point(60, 6);
			this.ComboAutoPlayers.Name = "ComboAutoPlayers";
			this.ComboAutoPlayers.Size = new System.Drawing.Size(228, 23);
			this.ComboAutoPlayers.TabIndex = 0;
			this.ComboAutoPlayers.SelectedIndexChanged += new System.EventHandler(this.ComboAutoPlayers_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "KI:";
			// 
			// TrackSpeed
			// 
			this.TrackSpeed.Location = new System.Drawing.Point(60, 35);
			this.TrackSpeed.Name = "TrackSpeed";
			this.TrackSpeed.Size = new System.Drawing.Size(140, 45);
			this.TrackSpeed.TabIndex = 2;
			this.TrackSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
			this.TrackSpeed.Scroll += new System.EventHandler(this.TrackSpeed_Scroll);
			// 
			// TextSpeed
			// 
			this.TextSpeed.Location = new System.Drawing.Point(206, 35);
			this.TextSpeed.Name = "TextSpeed";
			this.TextSpeed.ReadOnly = true;
			this.TextSpeed.Size = new System.Drawing.Size(82, 23);
			this.TextSpeed.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Speed:";
			// 
			// SettingsUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 96);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TextSpeed);
			this.Controls.Add(this.TrackSpeed);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ComboAutoPlayers);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsUI";
			this.Text = "SettingsUI";
			((System.ComponentModel.ISupportInitialize)(this.TrackSpeed)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox ComboAutoPlayers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar TrackSpeed;
		private System.Windows.Forms.TextBox TextSpeed;
		private System.Windows.Forms.Label label2;
	}
}