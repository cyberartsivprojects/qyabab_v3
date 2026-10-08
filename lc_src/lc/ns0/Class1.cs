using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{
	// Token: 0x02000010 RID: 16
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class Class1
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002080 File Offset: 0x00000280
		[HelpKeyword("My.Computer")]
		internal static Class0 Class0_0
		{
			get
			{
				return Class1.threadSafeObjectProvider_0.method_0();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000208C File Offset: 0x0000028C
		[HelpKeyword("My.Application")]
		internal static Form0 Form0_0
		{
			get
			{
				return Class1.threadSafeObjectProvider_1.method_0();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002098 File Offset: 0x00000298
		[HelpKeyword("My.User")]
		internal static User User_0
		{
			get
			{
				return Class1.threadSafeObjectProvider_2.method_0();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020A4 File Offset: 0x000002A4
		[HelpKeyword("My.Forms")]
		internal static Class1.MyForms MyForms_0
		{
			get
			{
				return Class1.threadSafeObjectProvider_3.method_0();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020B0 File Offset: 0x000002B0
		[HelpKeyword("My.WebServices")]
		internal static Class1.MyWebServices MyWebServices_0
		{
			get
			{
				return Class1.threadSafeObjectProvider_4.method_0();
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly Class1.ThreadSafeObjectProvider<Class0> threadSafeObjectProvider_0 = new Class1.ThreadSafeObjectProvider<Class0>();

		// Token: 0x04000003 RID: 3
		private static readonly Class1.ThreadSafeObjectProvider<Form0> threadSafeObjectProvider_1 = new Class1.ThreadSafeObjectProvider<Form0>();

		// Token: 0x04000004 RID: 4
		private static readonly Class1.ThreadSafeObjectProvider<User> threadSafeObjectProvider_2 = new Class1.ThreadSafeObjectProvider<User>();

		// Token: 0x04000005 RID: 5
		private static Class1.ThreadSafeObjectProvider<Class1.MyForms> threadSafeObjectProvider_3 = new Class1.ThreadSafeObjectProvider<Class1.MyForms>();

		// Token: 0x04000006 RID: 6
		private static readonly Class1.ThreadSafeObjectProvider<Class1.MyWebServices> threadSafeObjectProvider_4 = new Class1.ThreadSafeObjectProvider<Class1.MyWebServices>();

		// Token: 0x02000011 RID: 17
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000014 RID: 20 RVA: 0x000023C0 File Offset: 0x000005C0
			// (set) Token: 0x06000015 RID: 21 RVA: 0x000023EC File Offset: 0x000005EC
			public gui _o_program
			{
				get
				{
					this.gui_0 = Class1.MyForms.smethod_0<gui>(this.gui_0);
					return this.gui_0;
				}
				set
				{
					bool flag = value != this.gui_0;
					if (flag)
					{
						bool flag2 = value != null;
						if (flag2)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.method_0<gui>(ref this.gui_0);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000016 RID: 22 RVA: 0x00002430 File Offset: 0x00000630
			// (set) Token: 0x06000017 RID: 23 RVA: 0x0000245C File Offset: 0x0000065C
			public GForm0 empty
			{
				get
				{
					this.gform0_0 = Class1.MyForms.smethod_0<GForm0>(this.gform0_0);
					return this.gform0_0;
				}
				set
				{
					bool flag = value != this.gform0_0;
					if (flag)
					{
						bool flag2 = value != null;
						if (flag2)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.method_0<GForm0>(ref this.gform0_0);
					}
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000018 RID: 24 RVA: 0x000024A0 File Offset: 0x000006A0
			// (set) Token: 0x06000019 RID: 25 RVA: 0x000024CC File Offset: 0x000006CC
			public main loader
			{
				get
				{
					this.main_0 = Class1.MyForms.smethod_0<main>(this.main_0);
					return this.main_0;
				}
				set
				{
					bool flag = value != this.main_0;
					if (flag)
					{
						bool flag2 = value != null;
						if (flag2)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.method_0<main>(ref this.main_0);
					}
				}
			}

			// Token: 0x0600001A RID: 26 RVA: 0x00002510 File Offset: 0x00000710
			private static T smethod_0<T>(T gparam_0) where T : Form, new()
			{
				bool flag = gparam_0 == null || gparam_0.IsDisposed;
				if (flag)
				{
					bool flag2 = Class1.MyForms.hashtable_0 != null;
					if (flag2)
					{
						bool flag3 = Class1.MyForms.hashtable_0.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						Class1.MyForms.hashtable_0 = new Hashtable();
					}
					Class1.MyForms.hashtable_0.Add(typeof(T), null);
					TargetInvocationException ex2 = null;
					object obj;
					TargetInvocationException ex;
					bool flag4;
					TargetInvocationException ex5;
					bool flag5;
					try
					{
						return new T();
					}
					catch when (delegate
					{
						// Failed to create a 'catch-when' expression
						ex = obj as TargetInvocationException;
						if (ex == null)
						{
							flag4 = false;
						}
						else
						{
							ex5 = ex;
							TargetInvocationException ex3 = ex5;
							flag5 = delegate
							{
								TargetInvocationException ex4 = ex3;
								return delegate
								{
									ex2 = ex4;
									return delegate
									{
										ProjectData.SetProjectError(ex2);
										return ex2.InnerException != null;
									}();
								}();
							}();
							flag4 = flag5 > false;
						}
						endfilter(flag4);
					})
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[] { CS$<>8__locals2.CS$<>8__locals1.ex2.InnerException.Message });
						throw new InvalidOperationException(resourceString, CS$<>8__locals2.CS$<>8__locals1.ex2.InnerException);
					}
					finally
					{
						Class1.MyForms.hashtable_0.Remove(typeof(T));
					}
				}
				return gparam_0;
			}

			// Token: 0x0600001B RID: 27 RVA: 0x000020F1 File Offset: 0x000002F1
			private void method_0<T>(ref T gparam_0) where T : Form
			{
				gparam_0.Dispose();
				gparam_0 = default(T);
			}

			// Token: 0x0600001C RID: 28 RVA: 0x00002108 File Offset: 0x00000308
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x0600001D RID: 29 RVA: 0x0000267C File Offset: 0x0000087C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object obj)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}

			// Token: 0x0600001E RID: 30 RVA: 0x0000269C File Offset: 0x0000089C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600001F RID: 31 RVA: 0x000026B4 File Offset: 0x000008B4
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal Type method_1()
			{
				return typeof(Class1.MyForms);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x000026D0 File Offset: 0x000008D0
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000007 RID: 7
			[ThreadStatic]
			private static Hashtable hashtable_0;

			// Token: 0x04000008 RID: 8
			[EditorBrowsable(EditorBrowsableState.Never)]
			public gui gui_0;

			// Token: 0x04000009 RID: 9
			[EditorBrowsable(EditorBrowsableState.Never)]
			public GForm0 gform0_0;

			// Token: 0x0400000A RID: 10
			[EditorBrowsable(EditorBrowsableState.Never)]
			public main main_0;
		}

		// Token: 0x02000015 RID: 21
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x06000027 RID: 39 RVA: 0x0000267C File Offset: 0x0000087C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object obj)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}

			// Token: 0x06000028 RID: 40 RVA: 0x0000269C File Offset: 0x0000089C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00002794 File Offset: 0x00000994
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal Type method_0()
			{
				return typeof(Class1.MyWebServices);
			}

			// Token: 0x0600002A RID: 42 RVA: 0x000026D0 File Offset: 0x000008D0
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600002B RID: 43 RVA: 0x000027B0 File Offset: 0x000009B0
			private static T smethod_0<T>(T gparam_0) where T : new()
			{
				bool flag = gparam_0 == null;
				T t;
				if (flag)
				{
					t = new T();
				}
				else
				{
					t = gparam_0;
				}
				return t;
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00002112 File Offset: 0x00000312
			private void method_1<T>(ref T gparam_0)
			{
				gparam_0 = default(T);
			}

			// Token: 0x0600002D RID: 45 RVA: 0x00002108 File Offset: 0x00000308
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000016 RID: 22
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x0600002E RID: 46 RVA: 0x000027DC File Offset: 0x000009DC
			internal T method_0()
			{
				bool flag = Class1.ThreadSafeObjectProvider<T>.gparam_0 == null;
				if (flag)
				{
					Class1.ThreadSafeObjectProvider<T>.gparam_0 = new T();
				}
				return Class1.ThreadSafeObjectProvider<T>.gparam_0;
			}

			// Token: 0x0600002F RID: 47 RVA: 0x00002108 File Offset: 0x00000308
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x06000030 RID: 48 RVA: 0x00002810 File Offset: 0x00000A10
			internal static bool smethod_0()
			{
				return Class1.ThreadSafeObjectProvider<T>.object_0 == null;
			}

			// Token: 0x06000031 RID: 49 RVA: 0x0000282C File Offset: 0x00000A2C
			internal static object smethod_1()
			{
				return Class1.ThreadSafeObjectProvider<T>.object_0;
			}

			// Token: 0x04000010 RID: 16
			[ThreadStatic]
			[CompilerGenerated]
			private static T gparam_0;

			// Token: 0x04000011 RID: 17
			internal static object object_0;
		}
	}
}
