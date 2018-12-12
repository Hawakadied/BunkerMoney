using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BunkerMoney
{
	public partial class Main : Form
	{

		[DllImport("kernel32.dll")]
		public static extern int WriteProcessMemory(IntPtr Handle, long Address, byte[] buffer, int Size, int BytesWritten = 0);
		[DllImport("kernel32.dll")]
		public static extern int ReadProcessMemory(IntPtr Handle, long Address, byte[] buffer, int Size, int BytesRead = 0);

		public Process proc;
		public long baseAddr;

		int scPTR = 0x2D09BE8;

		int steamPTR = 0x2D0F2C8;

		int[] bunkerOff = new int[] { 0x1180, 0x4128 };

		bool isSC = false;

		public Main()
		{
			InitializeComponent();
			version = "v0.2.8";
			info.Text = version + " by Complexicon";
		}

		private void ApplyButton(object sender, EventArgs e)
		{
			if (CheckGTA())
			{
				if (IsNum(priceBox.Text) && IsNum(deliverAmtBox.Text) && IsNum(wantedMoneyBox.Text))
				{
					try
					{
						int price = ParseNum(priceBox.Text);
						int amt = ParseNum(deliverAmtBox.Text);
						int multiplier = ParseNum(wantedMoneyBox.Text);

						int amtForMil = 1000000 / (price / amt);

						proc = GetProcess("GTA5");
						baseAddr = GetBaseAddress("GTA5.exe");

						long ptr = isSC
							? GetPtrAddr(baseAddr + scPTR, bunkerOff)
							: GetPtrAddr(baseAddr + steamPTR, bunkerOff);

						WriteInteger(ptr, (amtForMil * multiplier));
						MessageBox.Show("Done! Destroy Delivery Vehicle and Enjoy :)", "Yay!");

					} catch { MessageBox.Show("There was an Error during the Procedure!", "Error"); }
				} else { MessageBox.Show("Please make sure you used Numbers!", "Warning"); }
			}
		}

		private void SCCheck(object sender, EventArgs e)
		{
			MessageBox.Show((scBox.Checked ? "Activated" : "Deactivated") + " Socialclub Mode", "Info");
			MessageBox.Show("Socialclub Mode isnt working Right now i am Sorry :(", "Info");
			//isSC = scBox.Checked;
		}

		private static int ParseNum(string s) => !int.TryParse(s, out int i) ? -13371337 : i;

		private static bool IsNum(string s)
		{
			int x = ParseNum(s);
			if (x == -13371337)
			{
				MessageBox.Show("'" + s + "' is not a Number!", "Warning");
				return false;
			}
			return true;
		}

		public static bool CheckGTA()
		{
			if (Process.GetProcessesByName("GTA5").Length == 0)
			{
				MessageBox.Show("Please Make Sure GTA5 is Running!", "Critical Error");
				return false;
			}
			return true;
		}

		public IntPtr GetProcessHandle()
		{
			try
			{
				return proc.Handle;
			}
			catch
			{
				CheckGTA();
				return IntPtr.Zero;
			}
		}

		public static Process GetProcess(string name) => Process.GetProcessesByName(name)[0];

		public void WriteInteger(long Address, int Value) => WriteProcessMemory(GetProcessHandle(), Address, BitConverter.GetBytes(Value), 4);

		public long GetBaseAddress(string ModuleName)
		{
			try
			{
				ProcessModule DLLBaseAddress = null;
				foreach (ProcessModule i in proc.Modules)
				{
					if (i.ModuleName == ModuleName)
					{
						DLLBaseAddress = i;
					}
				}

				return DLLBaseAddress.BaseAddress.ToInt64();
			}
			catch
			{
				return 0;
			}
		}

		public long GetPtrAddr(long Pointer, int[] Offset = null)
		{
			byte[] Buffer = new byte[8];

			ReadProcessMemory(GetProcessHandle(), Pointer, Buffer, Buffer.Length);

			if (Offset != null)
			{
				for (int x = 0; x < (Offset.Length - 1); x++)
				{
					Pointer = BitConverter.ToInt64(Buffer, 0) + Offset[x];
					ReadProcessMemory(GetProcessHandle(), Pointer, Buffer, Buffer.Length);
				}

				Pointer = BitConverter.ToInt64(Buffer, 0) + Offset[Offset.Length - 1];
			}

			return Pointer;
		}

	}
}
