using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NET.My
{
	// Token: 0x02000026 RID: 38
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[StandardModule]
	[HideModuleName]
	internal sealed class MySettingsProperty
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002365 File Offset: 0x00000565
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
