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
			this.info = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.delivery = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.initPrice = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 80);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(3);
			this.button1.Size = new System.Drawing.Size(125, 30);
			this.button1.TabIndex = 6;
			this.button1.Text = "Apply";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ApplyButton);
			// 
			// info
			// 
			this.info.AutoSize = true;
			this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.info.ForeColor = System.Drawing.Color.White;
			this.info.Location = new System.Drawing.Point(3, 2);
			this.info.Name = "info";
			this.info.Size = new System.Drawing.Size(104, 12);
			this.info.TabIndex = 9;
			this.info.Text = "v5.1 by Complexicon <3";
			this.info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
			this.info.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
			this.info.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Red;
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.info);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(125, 15);
			this.panel3.TabIndex = 13;
			this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
			this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
			this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(105, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(20, 15);
			this.button2.TabIndex = 0;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// delivery
			// 
			this.delivery.BackColor = System.Drawing.Color.Black;
			this.delivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.delivery.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.delivery.ForeColor = System.Drawing.Color.White;
			this.delivery.Location = new System.Drawing.Point(0, 60);
			this.delivery.Name = "delivery";
			this.delivery.Size = new System.Drawing.Size(125, 20);
			this.delivery.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Delivery Amount";
			// 
			// initPrice
			// 
			this.initPrice.BackColor = System.Drawing.Color.Black;
			this.initPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.initPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.initPrice.ForeColor = System.Drawing.Color.White;
			this.initPrice.Location = new System.Drawing.Point(0, 27);
			this.initPrice.Name = "initPrice";
			this.initPrice.Size = new System.Drawing.Size(125, 20);
			this.initPrice.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Initial Price";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(125, 110);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.initPrice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.delivery);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.Opacity = 0.7D;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "BunkerMoney";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label info;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox delivery;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox initPrice;
		private System.Windows.Forms.Label label2;
	}
}

