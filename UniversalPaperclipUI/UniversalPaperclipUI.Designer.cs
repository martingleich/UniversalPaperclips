using UniversalPaperclipUI.Properties;

namespace UniversalPaperclipUI
{
	partial class UniversalPaperclipsUI
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniversalPaperclipsUI));
			this.LabelPaperclips = new System.Windows.Forms.Label();
			this.ButtonMakePaperclip = new System.Windows.Forms.Button();
			this.GroupBusiness = new System.Windows.Forms.GroupBox();
			this.ButtonMarketing = new System.Windows.Forms.Button();
			this.LabelMarketingLevel = new System.Windows.Forms.Label();
			this.LabelMarketingCost = new System.Windows.Forms.Label();
			this.LabelPublicDemand = new System.Windows.Forms.Label();
			this.ButtonRaise = new System.Windows.Forms.Button();
			this.ButtonLower = new System.Windows.Forms.Button();
			this.LabelPricePerClip = new System.Windows.Forms.Label();
			this.LabelUnsoldInventory = new System.Windows.Forms.Label();
			this.LabelAvailableFunds = new System.Windows.Forms.Label();
			this.GroupManufactoring = new System.Windows.Forms.GroupBox();
			this.LabelCostAutoClippers = new System.Windows.Forms.Label();
			this.LabelAutoClippers = new System.Windows.Forms.Label();
			this.ButtonAutoClippers = new System.Windows.Forms.Button();
			this.LabelWireCost = new System.Windows.Forms.Label();
			this.ButtonWire = new System.Windows.Forms.Button();
			this.LabelWire = new System.Windows.Forms.Label();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.ButtonSettings = new System.Windows.Forms.Button();
			this.GroupBusiness.SuspendLayout();
			this.GroupManufactoring.SuspendLayout();
			this.SuspendLayout();
			// 
			// LabelPaperclips
			// 
			this.LabelPaperclips.AutoSize = true;
			this.LabelPaperclips.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelPaperclips.Location = new System.Drawing.Point(12, 9);
			this.LabelPaperclips.Name = "LabelPaperclips";
			this.LabelPaperclips.Size = new System.Drawing.Size(153, 25);
			this.LabelPaperclips.TabIndex = 0;
			this.LabelPaperclips.Text = "Paperclips: {0}";
			// 
			// ButtonMakePaperclip
			// 
			this.ButtonMakePaperclip.Location = new System.Drawing.Point(12, 37);
			this.ButtonMakePaperclip.Name = "ButtonMakePaperclip";
			this.ButtonMakePaperclip.Size = new System.Drawing.Size(98, 23);
			this.ButtonMakePaperclip.TabIndex = 1;
			this.ButtonMakePaperclip.Text = "Make Paperclip";
			this.ButtonMakePaperclip.UseVisualStyleBackColor = true;
			// 
			// GroupBusiness
			// 
			this.GroupBusiness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBusiness.Controls.Add(this.ButtonMarketing);
			this.GroupBusiness.Controls.Add(this.LabelMarketingLevel);
			this.GroupBusiness.Controls.Add(this.LabelMarketingCost);
			this.GroupBusiness.Controls.Add(this.LabelPublicDemand);
			this.GroupBusiness.Controls.Add(this.ButtonRaise);
			this.GroupBusiness.Controls.Add(this.ButtonLower);
			this.GroupBusiness.Controls.Add(this.LabelPricePerClip);
			this.GroupBusiness.Controls.Add(this.LabelUnsoldInventory);
			this.GroupBusiness.Controls.Add(this.LabelAvailableFunds);
			this.GroupBusiness.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.GroupBusiness.Location = new System.Drawing.Point(12, 66);
			this.GroupBusiness.Name = "GroupBusiness";
			this.GroupBusiness.Size = new System.Drawing.Size(285, 171);
			this.GroupBusiness.TabIndex = 2;
			this.GroupBusiness.TabStop = false;
			this.GroupBusiness.Text = "Business";
			// 
			// ButtonMarketing
			// 
			this.ButtonMarketing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ButtonMarketing.Location = new System.Drawing.Point(6, 122);
			this.ButtonMarketing.Name = "ButtonMarketing";
			this.ButtonMarketing.Size = new System.Drawing.Size(70, 23);
			this.ButtonMarketing.TabIndex = 1;
			this.ButtonMarketing.Text = "Marketing";
			this.ButtonMarketing.UseVisualStyleBackColor = true;
			// 
			// LabelMarketingLevel
			// 
			this.LabelMarketingLevel.AutoSize = true;
			this.LabelMarketingLevel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelMarketingLevel.Location = new System.Drawing.Point(80, 125);
			this.LabelMarketingLevel.Name = "LabelMarketingLevel";
			this.LabelMarketingLevel.Size = new System.Drawing.Size(69, 17);
			this.LabelMarketingLevel.TabIndex = 0;
			this.LabelMarketingLevel.Text = "Level: {0}";
			// 
			// LabelMarketingCost
			// 
			this.LabelMarketingCost.AutoSize = true;
			this.LabelMarketingCost.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelMarketingCost.Location = new System.Drawing.Point(6, 148);
			this.LabelMarketingCost.Name = "LabelMarketingCost";
			this.LabelMarketingCost.Size = new System.Drawing.Size(63, 17);
			this.LabelMarketingCost.TabIndex = 0;
			this.LabelMarketingCost.Text = "Cost: {0}";
			// 
			// LabelPublicDemand
			// 
			this.LabelPublicDemand.AutoSize = true;
			this.LabelPublicDemand.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelPublicDemand.Location = new System.Drawing.Point(6, 82);
			this.LabelPublicDemand.Name = "LabelPublicDemand";
			this.LabelPublicDemand.Size = new System.Drawing.Size(161, 17);
			this.LabelPublicDemand.TabIndex = 0;
			this.LabelPublicDemand.Text = "Public Demand: {0:F0} %";
			// 
			// ButtonRaise
			// 
			this.ButtonRaise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ButtonRaise.Location = new System.Drawing.Point(68, 56);
			this.ButtonRaise.Name = "ButtonRaise";
			this.ButtonRaise.Size = new System.Drawing.Size(56, 23);
			this.ButtonRaise.TabIndex = 1;
			this.ButtonRaise.Text = "raise";
			this.ButtonRaise.UseVisualStyleBackColor = true;
			// 
			// ButtonLower
			// 
			this.ButtonLower.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ButtonLower.Location = new System.Drawing.Point(6, 56);
			this.ButtonLower.Name = "ButtonLower";
			this.ButtonLower.Size = new System.Drawing.Size(56, 23);
			this.ButtonLower.TabIndex = 1;
			this.ButtonLower.Text = "lower";
			this.ButtonLower.UseVisualStyleBackColor = true;
			// 
			// LabelPricePerClip
			// 
			this.LabelPricePerClip.AutoSize = true;
			this.LabelPricePerClip.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelPricePerClip.Location = new System.Drawing.Point(130, 59);
			this.LabelPricePerClip.Name = "LabelPricePerClip";
			this.LabelPricePerClip.Size = new System.Drawing.Size(117, 17);
			this.LabelPricePerClip.TabIndex = 0;
			this.LabelPricePerClip.Text = "Price per Clip: {0}";
			// 
			// LabelUnsoldInventory
			// 
			this.LabelUnsoldInventory.AutoSize = true;
			this.LabelUnsoldInventory.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelUnsoldInventory.Location = new System.Drawing.Point(6, 36);
			this.LabelUnsoldInventory.Name = "LabelUnsoldInventory";
			this.LabelUnsoldInventory.Size = new System.Drawing.Size(137, 17);
			this.LabelUnsoldInventory.TabIndex = 0;
			this.LabelUnsoldInventory.Text = "Unsold Inventory: {0}";
			// 
			// LabelAvailableFunds
			// 
			this.LabelAvailableFunds.AutoSize = true;
			this.LabelAvailableFunds.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelAvailableFunds.Location = new System.Drawing.Point(6, 19);
			this.LabelAvailableFunds.Name = "LabelAvailableFunds";
			this.LabelAvailableFunds.Size = new System.Drawing.Size(129, 17);
			this.LabelAvailableFunds.TabIndex = 0;
			this.LabelAvailableFunds.Text = "Available Funds: {0}";
			// 
			// GroupManufactoring
			// 
			this.GroupManufactoring.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupManufactoring.Controls.Add(this.LabelCostAutoClippers);
			this.GroupManufactoring.Controls.Add(this.LabelAutoClippers);
			this.GroupManufactoring.Controls.Add(this.ButtonAutoClippers);
			this.GroupManufactoring.Controls.Add(this.LabelWireCost);
			this.GroupManufactoring.Controls.Add(this.ButtonWire);
			this.GroupManufactoring.Controls.Add(this.LabelWire);
			this.GroupManufactoring.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.GroupManufactoring.Location = new System.Drawing.Point(12, 243);
			this.GroupManufactoring.Name = "GroupManufactoring";
			this.GroupManufactoring.Size = new System.Drawing.Size(285, 133);
			this.GroupManufactoring.TabIndex = 3;
			this.GroupManufactoring.TabStop = false;
			this.GroupManufactoring.Text = "Manufacturing";
			// 
			// LabelCostAutoClippers
			// 
			this.LabelCostAutoClippers.AutoSize = true;
			this.LabelCostAutoClippers.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelCostAutoClippers.Location = new System.Drawing.Point(6, 108);
			this.LabelCostAutoClippers.Name = "LabelCostAutoClippers";
			this.LabelCostAutoClippers.Size = new System.Drawing.Size(63, 17);
			this.LabelCostAutoClippers.TabIndex = 0;
			this.LabelCostAutoClippers.Text = "Cost: {0}";
			// 
			// LabelAutoClippers
			// 
			this.LabelAutoClippers.AutoSize = true;
			this.LabelAutoClippers.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelAutoClippers.Location = new System.Drawing.Point(104, 85);
			this.LabelAutoClippers.Name = "LabelAutoClippers";
			this.LabelAutoClippers.Size = new System.Drawing.Size(29, 17);
			this.LabelAutoClippers.TabIndex = 0;
			this.LabelAutoClippers.Text = "{0}";
			// 
			// ButtonAutoClippers
			// 
			this.ButtonAutoClippers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ButtonAutoClippers.Location = new System.Drawing.Point(6, 82);
			this.ButtonAutoClippers.Name = "ButtonAutoClippers";
			this.ButtonAutoClippers.Size = new System.Drawing.Size(92, 23);
			this.ButtonAutoClippers.TabIndex = 1;
			this.ButtonAutoClippers.Text = "AutoClippers";
			this.ButtonAutoClippers.UseVisualStyleBackColor = true;
			// 
			// LabelWireCost
			// 
			this.LabelWireCost.AutoSize = true;
			this.LabelWireCost.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelWireCost.Location = new System.Drawing.Point(6, 46);
			this.LabelWireCost.Name = "LabelWireCost";
			this.LabelWireCost.Size = new System.Drawing.Size(63, 17);
			this.LabelWireCost.TabIndex = 0;
			this.LabelWireCost.Text = "Cost: {0}";
			// 
			// ButtonWire
			// 
			this.ButtonWire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ButtonWire.Location = new System.Drawing.Point(6, 20);
			this.ButtonWire.Name = "ButtonWire";
			this.ButtonWire.Size = new System.Drawing.Size(56, 23);
			this.ButtonWire.TabIndex = 1;
			this.ButtonWire.Text = "Wire";
			this.ButtonWire.UseVisualStyleBackColor = true;
			// 
			// LabelWire
			// 
			this.LabelWire.AutoSize = true;
			this.LabelWire.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelWire.Location = new System.Drawing.Point(68, 23);
			this.LabelWire.Name = "LabelWire";
			this.LabelWire.Size = new System.Drawing.Size(70, 17);
			this.LabelWire.TabIndex = 0;
			this.LabelWire.Text = "{0} inches";
			// 
			// Timer
			// 
			this.Timer.Enabled = true;
			this.Timer.Interval = 10;
			this.Timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// ButtonSettings
			// 
			this.ButtonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSettings.BackgroundImage")));
			this.ButtonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ButtonSettings.Location = new System.Drawing.Point(265, 12);
			this.ButtonSettings.Name = "ButtonSettings";
			this.ButtonSettings.Size = new System.Drawing.Size(32, 32);
			this.ButtonSettings.TabIndex = 4;
			this.ButtonSettings.UseVisualStyleBackColor = true;
			this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
			// 
			// UniversalPaperclipsUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 386);
			this.Controls.Add(this.ButtonSettings);
			this.Controls.Add(this.GroupManufactoring);
			this.Controls.Add(this.GroupBusiness);
			this.Controls.Add(this.ButtonMakePaperclip);
			this.Controls.Add(this.LabelPaperclips);
			this.MinimumSize = new System.Drawing.Size(325, 425);
			this.Name = "UniversalPaperclipsUI";
			this.Text = "Universal Paperclips";
			this.GroupBusiness.ResumeLayout(false);
			this.GroupBusiness.PerformLayout();
			this.GroupManufactoring.ResumeLayout(false);
			this.GroupManufactoring.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LabelPaperclips;
		private System.Windows.Forms.Button ButtonMakePaperclip;
		private System.Windows.Forms.GroupBox GroupBusiness;
		private System.Windows.Forms.Button ButtonLower;
		private System.Windows.Forms.Label LabelPricePerClip;
		private System.Windows.Forms.Label LabelUnsoldInventory;
		private System.Windows.Forms.Label LabelAvailableFunds;
		private System.Windows.Forms.Label LabelPublicDemand;
		private System.Windows.Forms.Button ButtonRaise;
		private System.Windows.Forms.GroupBox GroupManufactoring;
		private System.Windows.Forms.Label LabelCostAutoClippers;
		private System.Windows.Forms.Label LabelAutoClippers;
		private System.Windows.Forms.Button ButtonAutoClippers;
		private System.Windows.Forms.Label LabelWireCost;
		private System.Windows.Forms.Button ButtonWire;
		private System.Windows.Forms.Label LabelWire;
		private System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.Button ButtonMarketing;
		private System.Windows.Forms.Label LabelMarketingLevel;
		private System.Windows.Forms.Label LabelMarketingCost;
		private System.Windows.Forms.Button ButtonSettings;
	}
}

