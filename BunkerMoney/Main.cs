using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BunkerMoney {
	public partial class Main : Form {

		[DllImport("kernel32.dll")]
		public static extern int WriteProcessMemory(IntPtr Handle, long Address, byte[] buffer, int Size, int BytesWritten = 0);
		[DllImport("kernel32.dll")]
		public static extern int ReadProcessMemory(IntPtr Handle, long Address, byte[] buffer, int Size, int BytesRead = 0);

		public Process proc;
		public long baseAddr;

		int scPTR = 0x2D09BE8;

		int steamPTR = 0x2D0F2C8;

		int[] bunkerOff = new int[] { 0x1180, 0x4128 };

		string url = "https://raw.githubusercontent.com/Complexicon/BunkerMoney/master/BunkerMoney/offsets.ini";

		public Main() {

			using (WebClient client = new WebClient()) {
				try {
					string s = client.DownloadString(url);
					string[] lines = s.Split(Environment.NewLine.ToCharArray());
					foreach (string l in lines) {
						if (l.StartsWith("scPTR")) scPTR = Convert.ToInt32(l.Substring(6), 16);
						if (l.StartsWith("steamPTR")) steamPTR = Convert.ToInt32(l.Substring(9), 16);
						if (l.StartsWith("offset1")) bunkerOff[0] = Convert.ToInt32(l.Substring(8), 16);
						if (l.StartsWith("offset2")) bunkerOff[1] = Convert.ToInt32(l.Substring(8), 16);
					}
				} catch {
					MessageBox.Show("Couldn't load Remote Offsets! Using local Offsets (GTA 1.46)!", "Warning");
				}
			}


			InitializeComponent();
			this.Text = "v0.4.1";
		}

		private void ApplyButton(object sender, EventArgs e) {
			if (CheckGTA()) {
				if (IsNum(initPrice.Text) && IsNum(delivery.Text) && IsNum(money.Text)) {
					try {
						int price = ParseNum(initPrice.Text);
						int amt = ParseNum(delivery.Text);
						int multiplier = ParseNum(money.Text);

						int amtForMil = 1000000 / (price / amt);

						proc = GetProcess("GTA5");
						baseAddr = GetBaseAddress("GTA5.exe");

						long ptr = MessageBox.Show("Social Club?", "This some Important Shit", MessageBoxButtons.YesNo) == DialogResult.Yes
							? GetPtrAddr(baseAddr + scPTR, bunkerOff)
							: GetPtrAddr(baseAddr + steamPTR, bunkerOff);

						WriteInteger(ptr, (amtForMil * multiplier));
						MessageBox.Show("Done! Deliver Vehlicle and Enjoy :D, Program will now close!", "Yay!");
						Environment.Exit(0);

					} catch { MessageBox.Show("There was an Error during the Procedure!", "Error"); }
				} else { MessageBox.Show("Please make sure you used Numbers!", "Warning"); }
			}
		}

		private static int ParseNum(string s) => !int.TryParse(s, out int i) ? -13371337 : i;

		private static bool IsNum(string s) {
			int x = ParseNum(s);
			if (x == -13371337) {
				MessageBox.Show("'" + s + "' is not a Number!", "Warning");
				return false;
			}
			return true;
		}

		public static bool CheckGTA() {
			if (Process.GetProcessesByName("GTA5").Length == 0) {
				MessageBox.Show("Please Make Sure GTA5 is Running!", "Critical Error");
				return false;
			}
			return true;
		}

		public IntPtr GetProcessHandle() {
			try {
				return proc.Handle;
			} catch {
				CheckGTA();
				return IntPtr.Zero;
			}
		}

		public static Process GetProcess(string name) => Process.GetProcessesByName(name)[0];

		public void WriteInteger(long Address, int Value) => WriteProcessMemory(GetProcessHandle(), Address, BitConverter.GetBytes(Value), 4);

		public long GetBaseAddress(string ModuleName) {
			try {
				ProcessModule DLLBaseAddress = null;
				foreach (ProcessModule i in proc.Modules) {
					if (i.ModuleName == ModuleName) {
						DLLBaseAddress = i;
					}
				}

				return DLLBaseAddress.BaseAddress.ToInt64();
			} catch {
				return 0;
			}
		}

		public long GetPtrAddr(long Pointer, int[] Offset = null) {
			byte[] Buffer = new byte[8];

			ReadProcessMemory(GetProcessHandle(), Pointer, Buffer, Buffer.Length);

			if (Offset != null) {
				for (int x = 0; x < (Offset.Length - 1); x++) {
					Pointer = BitConverter.ToInt64(Buffer, 0) + Offset[x];
					ReadProcessMemory(GetProcessHandle(), Pointer, Buffer, Buffer.Length);
				}

				Pointer = BitConverter.ToInt64(Buffer, 0) + Offset[Offset.Length - 1];
			}

			return Pointer;
		}

		private void info_Click(object sender, EventArgs e) => MessageBox.Show("Easter Egg Hunter ;)");
	}
}
