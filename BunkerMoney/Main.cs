using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace BunkerMoney {
	public partial class Main : Form {

		int[] bunkerOff = new int[] { 0x1180, 0x4128 };
		long GlobalPTR;

		MemLib Mem;

		bool mouseDown;
		Point lastLocation;

		string url = "https://raw.githubusercontent.com/Complexicon/BunkerMoney/master/BunkerMoney/offsets.ini";

		public Main() {

			using(WebClient client = new WebClient()) {
				try {
					string s = client.DownloadString(url);
					string[] lines = s.Split(Environment.NewLine.ToCharArray());
					foreach(string l in lines) {
						if(l.StartsWith("offset1")) bunkerOff[0] = Convert.ToInt32(l.Substring(8), 16);
						if(l.StartsWith("offset2")) bunkerOff[1] = Convert.ToInt32(l.Substring(8), 16);
					}
				} catch {
					MessageBox.Show("Couldn't load Remote Offsets! Using local Offsets (GTA 1.46)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}

			try {
				Mem = new MemLib("GTA5");
				var addr = Mem.FindPattern(new byte[] { 0x4C, 0x8D, 0x05, 0x0, 0x0, 0x0, 0x0, 0x4D, 0x8B, 0x08, 0x4D, 0x85, 0xC9, 0x74, 0x11 }, "xxx????xxxxxxxx");
				GlobalPTR = addr + Mem.ReadInt(addr + 3, null) + 7;
			} catch {
				MessageBox.Show("GTA is not Running!", "Serious Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}

			InitializeComponent();
		}

		private void ApplyButton(object sender, EventArgs e) {
			if(int.TryParse(initPrice.Text, out int price) && int.TryParse(delivery.Text, out int amt)) {
				try {
					Mem.WriteInt(GlobalPTR - 0x128, bunkerOff, Convert.ToInt32((1000000 / (price / amt)) * 4.5));

					MessageBox.Show("Done! Deliver Vehlicle and Enjoy :D, Program will now close!", "Yay!");
					Environment.Exit(0);

				} catch { MessageBox.Show("There was an Error during the Procedure!", "Error"); }
			} else { MessageBox.Show("Please make sure you used Numbers!", "Warning"); }
		}
		private void button2_Click(object sender, EventArgs e) => Environment.Exit(0);

		private void Panel_MouseDown(object sender, MouseEventArgs e) {
			mouseDown = true;
			lastLocation = e.Location;
		}

		private void Panel_MouseMove(object sender, MouseEventArgs e) {
			if(mouseDown) {
				Location = new Point(Location.X - lastLocation.X + e.X, Location.Y - lastLocation.Y + e.Y);
				this.Update();
			}
		}

		private void Panel_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;

	}
}
