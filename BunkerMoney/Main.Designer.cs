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
			this.delivery = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.info = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.initPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.money = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 130);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 31);
			this.button1.TabIndex = 6;
			this.button1.Text = "Apply";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ApplyButton);
			// 
			// delivery
			// 
			this.delivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.delivery.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.delivery.Location = new System.Drawing.Point(3, 3);
			this.delivery.Name = "delivery";
			this.delivery.Size = new System.Drawing.Size(111, 20);
			this.delivery.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Delivery Packages";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// info
			// 
			this.info.AutoSize = true;
			this.info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.info.Location = new System.Drawing.Point(5, 164);
			this.info.Name = "info";
			this.info.Size = new System.Drawing.Size(118, 13);
			this.info.TabIndex = 9;
			this.info.Text = "by Complexicon with <3";
			this.info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.info.Click += new System.EventHandler(this.info_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.delivery);
			this.panel1.Location = new System.Drawing.Point(8, 57);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(119, 28);
			this.panel1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Initial Sell Price";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.initPrice);
			this.panel2.Location = new System.Drawing.Point(8, 18);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(119, 28);
			this.panel2.TabIndex = 12;
			// 
			// initPrice
			// 
			this.initPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.initPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.initPrice.Location = new System.Drawing.Point(3, 3);
			this.initPrice.Name = "initPrice";
			this.initPrice.Size = new System.Drawing.Size(111, 20);
			this.initPrice.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Money (in Million)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.money);
			this.panel3.Location = new System.Drawing.Point(8, 96);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(119, 28);
			this.panel3.TabIndex = 14;
			// 
			// money
			// 
			this.money.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.money.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.money.Location = new System.Drawing.Point(3, 3);
			this.money.Name = "money";
			this.money.Size = new System.Drawing.Size(111, 20);
			this.money.TabIndex = 0;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(134, 176);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.info);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox delivery;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label info;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox initPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox money;
	}
}

