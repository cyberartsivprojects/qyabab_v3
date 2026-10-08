using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{
	// Token: 0x02000019 RID: 25
	[DesignerGenerated]
	public class GForm0 : Form
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003150 File Offset: 0x00001350
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002187 File Offset: 0x00000387
		internal virtual Label g1 { get; set; }

		// Token: 0x0600003D RID: 61 RVA: 0x00002191 File Offset: 0x00000391
		public GForm0()
		{
			base.FormClosing += this.GForm0_FormClosing;
			this.method_0();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003168 File Offset: 0x00001368
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.idisposable_0 != null;
				if (flag)
				{
					this.idisposable_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000031B8 File Offset: 0x000013B8
		private void method_0()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
			this.g1 = new Label();
			base.SuspendLayout();
			this.g1.Dock = DockStyle.Fill;
			this.g1.Font = new Font("Lucida Console", 48f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.g1.ForeColor = Color.Magenta;
			this.g1.Location = new Point(0, 0);
			this.g1.Name = "g1";
			this.g1.Size = new Size(874, 408);
			this.g1.TabIndex = 1;
			this.g1.Text = ":3";
			this.g1.TextAlign = ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(874, 408);
			base.Controls.Add(this.g1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "empty";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.WindowState = FormWindowState.Maximized;
			base.ResumeLayout(false);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021BC File Offset: 0x000003BC
		private void GForm0_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x04000014 RID: 20
		private IDisposable idisposable_0 = null;

		// Token: 0x04000015 RID: 21
		[CompilerGenerated]
		[AccessedThroughProperty("g1")]
		private Label label_0;
	}
}
