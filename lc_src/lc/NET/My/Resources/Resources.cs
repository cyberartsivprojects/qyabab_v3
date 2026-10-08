using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NET.My.Resources
{
	// Token: 0x02000027 RID: 39
	[CompilerGenerated]
	[HideModuleName]
	[DebuggerNonUserCode]
	[StandardModule]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	internal sealed class Resources
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000BA84 File Offset: 0x00009C84
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceManager_0 == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("NET.Resources", typeof(Resources).Assembly);
					Resources.resourceManager_0 = resourceManager;
				}
				return Resources.resourceManager_0;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000BACC File Offset: 0x00009CCC
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000236C File Offset: 0x0000056C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.cultureInfo_0;
			}
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		// Token: 0x04000081 RID: 129
		private static ResourceManager resourceManager_0;

		// Token: 0x04000082 RID: 130
		private static CultureInfo cultureInfo_0;
	}
}
