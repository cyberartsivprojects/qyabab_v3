using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace NET.My
{
	// Token: 0x02000024 RID: 36
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
	[CompilerGenerated]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		public static MySettings Default
		{
			get
			{
				bool flag = !MySettings.addedHandler;
				if (flag)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					bool flag2 = false;
					try
					{
						Monitor.Enter(obj, ref flag2);
						bool flag3 = !MySettings.addedHandler;
						if (flag3)
						{
							WindowsFormsApplicationBase form0_ = Class1.Form0_0;
							ShutdownEventHandler shutdownEventHandler;
							if ((shutdownEventHandler = MySettings.<>O.<0>__AutoSaveSettings) == null)
							{
								shutdownEventHandler = (MySettings.<>O.<0>__AutoSaveSettings = new ShutdownEventHandler(MySettings.AutoSaveSettings));
							}
							form0_.Shutdown += shutdownEventHandler;
							MySettings.addedHandler = true;
						}
					}
					finally
					{
						bool flag4 = flag2;
						if (flag4)
						{
							Monitor.Exit(obj);
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000BA58 File Offset: 0x00009C58
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			bool saveMySettingsOnExit = Class1.Form0_0.SaveMySettingsOnExit;
			if (saveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x0400007D RID: 125
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x0400007E RID: 126
		private static bool addedHandler;

		// Token: 0x0400007F RID: 127
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
