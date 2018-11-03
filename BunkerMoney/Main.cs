using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BunkerMoney
{
	public partial class Main : Form
	{

		public Process proc;
		public long BaseAddress;

		int scPTR = 0x2C995A8;
		int steamPTR = 0x2C9EB78;

		bool isSC = false;

		[DllImport("kernel32.dll")]
		public static extern int WriteProcessMemory(IntPtr Handle, long Address, byte[] buffer, int Size, int BytesWritten = 0);
		[DllImport("kernel32.dll")]
		public static extern int ReadProcessMemory(IntPtr Handle, long Address, byte[] buffer, int Size, int BytesRead = 0);

		public Main()
		{
			version = "v0.2";
			InitializeComponent();
		}

		private void ApplyButton(object sender, EventArgs e)
		{
			if (IsNum(textBox1.Text) && IsNum(textBox2.Text) && IsNum(textBox3.Text))
			{
				try
				{
					int price = ParseNum(textBox1.Text);
					int amt = ParseNum(textBox2.Text);
					int multiplier = ParseNum(textBox3.Text);

					proc = getProcess("GTA5");
					progressBar1.Value = 10;
					BaseAddress = GetBaseAddress("GTA5.exe");
					progressBar1.Value = 25;
					long ptr;

					if (isSC)
					{
						 ptr = GetPointerAddress(BaseAddress + scPTR, new int[] { 0x1180, 0x4088 });
					}
					else
					{
						ptr = GetPointerAddress(BaseAddress + steamPTR, new int[] { 0x1180, 0x4088 });
					}

					progressBar1.Value = 30;

					int pricePerPacket = price / amt;
					int amtForMil = 0;
					for (int i = 1; (i * pricePerPacket) < 1000000; i++)
					{
						amtForMil = i;
					}
					progressBar1.Value = 80;

					WriteInteger(ptr, (amtForMil * multiplier));
					progressBar1.Value = 100;
					MessageBox.Show("Done! Destroy Delivery Vehicle and Enjoy :)", "Yay!");
					progressBar1.Value = 0;
				}
				catch
				{
					progressBar1.Value = 100;
					MessageBox.Show("There was an Error during the Procedure!", "Error");
					progressBar1.Value = 0;
				}
			}
			else
			{
				progressBar1.Value = 100;
				MessageBox.Show("Please make sure you used Numbers!", "Warning");
				progressBar1.Value = 0;
			}
		}

		private void SCCheck(object sender, EventArgs e)
		{
			MessageBox.Show((checkBox1.Checked ? "Activated" : "Deactivated") + " Socialclub Mode", "Info");
			isSC = checkBox1.Checked;
		}

		private void ExitButton(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			IsGameRunning();
		}

		private int ParseNum(string s)
		{
			int i;
			if (!int.TryParse(s, out i))
			{
				return -13371337;
			}
			return i;
		}

		private bool IsNum(string s)
		{
			int x = ParseNum(s);
			if (x == -13371337)
			{
				MessageBox.Show("'" + s + "' is not a Number!", "Warning");
				return false;
			}
			return true;
		}

		public static bool IsGameRunning()
		{
			Process[] process = Process.GetProcessesByName("GTA5");
			if (process.Length == 0)
			{
				if (MessageBox.Show("You need to run GTA5. Closing Menu!", "Critical Scary Error") == System.Windows.Forms.DialogResult.OK)
				{

				}
				Application.Exit();
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
				IsGameRunning();
				return IntPtr.Zero;
			}
		}

		public Process getProcess(string name)
		{
			return Process.GetProcessesByName(name)[0];
		}

		public void WriteInteger(long Address, int Value)
		{
			WriteProcessMemory(GetProcessHandle(), Address, BitConverter.GetBytes(Value), 4);
		}

		public long GetBaseAddress(string ModuleName)
		{
			try
			{
				ProcessModuleCollection modules = proc.Modules;
				ProcessModule DLLBaseAddress = null;

				foreach (ProcessModule i in modules)
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

		public long GetPointerAddress(long Pointer, int[] Offset = null)
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
