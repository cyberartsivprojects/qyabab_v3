namespace ns0
{
	// Token: 0x0200001D RID: 29
	public partial class main : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00007608 File Offset: 0x00005808
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

		// Token: 0x0600007C RID: 124 RVA: 0x00007658 File Offset: 0x00005858
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.main));
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(120, 0);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "loader";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "System32";
			base.TransparencyKey = global::System.Drawing.Color.White;
			base.WindowState = global::System.Windows.Forms.FormWindowState.Minimized;
			base.ResumeLayout(false);
		}

		// Token: 0x0400004E RID: 78
		private global::System.IDisposable idisposable_0 = null;
	}
}
