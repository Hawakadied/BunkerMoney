namespace BunkerMoney
{
	partial class Main
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public string version = "null";

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.priceBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.deliverAmtBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.wantedMoneyBox = new System.Windows.Forms.TextBox();
			this.info = new System.Windows.Forms.Label();
			this.scBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 136);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 31);
			this.button1.TabIndex = 6;
			this.button1.Text = "Apply";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ApplyButton);
			// 
			// label1
			// 
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.Location = new System.Drawing.Point(12, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Delivery Packages";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// priceBox
			// 
			this.priceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.priceBox.Location = new System.Drawing.Point(12, 25);
			this.priceBox.Name = "priceBox";
			this.priceBox.Size = new System.Drawing.Size(130, 20);
			this.priceBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Initial Sell Price";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// deliverAmtBox
			// 
			this.deliverAmtBox.Location = new System.Drawing.Point(12, 66);
			this.deliverAmtBox.Name = "deliverAmtBox";
			this.deliverAmtBox.Size = new System.Drawing.Size(130, 20);
			this.deliverAmtBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Money (in Million)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// wantedMoneyBox
			// 
			this.wantedMoneyBox.Location = new System.Drawing.Point(12, 110);
			this.wantedMoneyBox.Name = "wantedMoneyBox";
			this.wantedMoneyBox.Size = new System.Drawing.Size(130, 20);
			this.wantedMoneyBox.TabIndex = 4;
			// 
			// info
			// 
			this.info.AutoSize = true;
			this.info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.info.Location = new System.Drawing.Point(9, 170);
			this.info.Name = "info";
			this.info.Size = new System.Drawing.Size(114, 13);
			this.info.TabIndex = 9;
			this.info.Text = "v1337 by Complexicon";
			// 
			// scBox
			// 
			this.scBox.AutoSize = true;
			this.scBox.Location = new System.Drawing.Point(102, 144);
			this.scBox.Name = "scBox";
			this.scBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.scBox.Size = new System.Drawing.Size(40, 17);
			this.scBox.TabIndex = 10;
			this.scBox.Text = "SC";
			this.scBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.scBox.UseVisualStyleBackColor = false;
			this.scBox.Click += new System.EventHandler(this.SCCheck);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(154, 186);
			this.Controls.Add(this.scBox);
			this.Controls.Add(this.info);
			this.Controls.Add(this.wantedMoneyBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.deliverAmtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.priceBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "BunkerMoney";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox priceBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox deliverAmtBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox wantedMoneyBox;
		private System.Windows.Forms.Label info;
		private System.Windows.Forms.CheckBox scBox;
	}
}

