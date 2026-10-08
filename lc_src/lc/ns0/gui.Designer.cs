namespace ns0
{
	// Token: 0x0200001A RID: 26
	public partial class gui : global::System.Windows.Forms.Form
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00004E78 File Offset: 0x00003078
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.container_0 != null;
				if (flag)
				{
					((global::System.IDisposable)this.container_0).Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004EC4 File Offset: 0x000030C4
		private void InitializeComponent()
		{
			this.container_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.gui));
			this.g1 = new global::System.Windows.Forms.Label();
			this.a1 = new global::System.Windows.Forms.Panel();
			this.s2 = new global::System.Windows.Forms.Label();
			this.tg = new global::System.Windows.Forms.Label();
			this.s1 = new global::System.Windows.Forms.Label();
			this.border_6 = new global::System.Windows.Forms.PictureBox();
			this.border_5 = new global::System.Windows.Forms.PictureBox();
			this.border_2 = new global::System.Windows.Forms.PictureBox();
			this.border_1 = new global::System.Windows.Forms.PictureBox();
			this.main = new global::System.Windows.Forms.Panel();
			this.ByPassMessage = new global::System.Windows.Forms.Panel();
			this.c3 = new global::System.Windows.Forms.PictureBox();
			this.c2 = new global::System.Windows.Forms.PictureBox();
			this.c4 = new global::System.Windows.Forms.PictureBox();
			this.c1 = new global::System.Windows.Forms.PictureBox();
			this.ByPassWarnMsg = new global::System.Windows.Forms.Label();
			this.Safe1 = new global::System.Windows.Forms.PictureBox();
			this.Safe2 = new global::System.Windows.Forms.PictureBox();
			this.ID = new global::System.Windows.Forms.Label();
			this.UserInfo = new global::System.Windows.Forms.Label();
			this.Title = new global::System.Windows.Forms.Label();
			this.menu1 = new global::System.Windows.Forms.Label();
			this.DeadlineTimer = new global::System.Windows.Forms.Label();
			this.a2 = new global::System.Windows.Forms.Panel();
			this.errx = new global::System.Windows.Forms.Label();
			this.border_8 = new global::System.Windows.Forms.PictureBox();
			this.border_7 = new global::System.Windows.Forms.PictureBox();
			this.border_4 = new global::System.Windows.Forms.PictureBox();
			this.border_3 = new global::System.Windows.Forms.PictureBox();
			this.inputPS = new global::System.Windows.Forms.Label();
			this.keytext = new global::System.Windows.Forms.Label();
			this.hdn = new global::System.Windows.Forms.TextBox();
			this.vmethod_1(new global::System.Windows.Forms.Timer(this.container_0));
			this.vmethod_3(new global::System.Windows.Forms.Timer(this.container_0));
			this.art = new global::System.Windows.Forms.Label();
			this.vmethod_5(new global::System.Windows.Forms.Timer(this.container_0));
			this.vmethod_7(new global::System.Windows.Forms.Timer(this.container_0));
			this.vmethod_9(new global::System.Windows.Forms.Timer(this.container_0));
			this.a1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.border_6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_1).BeginInit();
			this.main.SuspendLayout();
			this.ByPassMessage.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.c3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.c2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.c4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.c1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Safe1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Safe2).BeginInit();
			this.a2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.border_8).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_3).BeginInit();
			base.SuspendLayout();
			this.g1.Font = new global::System.Drawing.Font("Pixelify Sans", 14.25f);
			this.g1.ForeColor = global::System.Drawing.Color.Magenta;
			this.g1.Location = new global::System.Drawing.Point(6, 1);
			this.g1.Size = new global::System.Drawing.Size(807, 153);
			this.g1.Text = componentResourceManager.GetString("g1.Text");
			this.g1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.a1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.a1.Controls.Add(this.s2);
			this.a1.Controls.Add(this.tg);
			this.a1.Controls.Add(this.s1);
			this.a1.Controls.Add(this.border_6);
			this.a1.Controls.Add(this.border_5);
			this.a1.Controls.Add(this.border_2);
			this.a1.Controls.Add(this.border_1);
			this.a1.Controls.Add(this.g1);
			this.a1.Font = new global::System.Drawing.Font("Pixelify Sans", 12f);
			this.a1.Location = new global::System.Drawing.Point(97, 147);
			this.a1.Size = new global::System.Drawing.Size(813, 200);
			this.a1.Visible = false;
			this.s2.Font = new global::System.Drawing.Font("Pixelify Sans", 15.75f);
			this.s2.ForeColor = global::System.Drawing.Color.Magenta;
			this.s2.Location = new global::System.Drawing.Point(665, 155);
			this.s2.Size = new global::System.Drawing.Size(140, 40);
			this.s2.Text = "(тг)";
			this.tg.BackColor = global::System.Drawing.Color.Transparent;
			this.tg.Font = new global::System.Drawing.Font("Consolas", 15.75f, global::System.Drawing.FontStyle.Bold);
			this.tg.ForeColor = global::System.Drawing.Color.HotPink;
			this.tg.Location = new global::System.Drawing.Point(365, 155);
			this.tg.Size = new global::System.Drawing.Size(295, 40);
			this.tg.Text = "@gxrge";
			this.tg.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.s1.Font = new global::System.Drawing.Font("Pixelify Sans", 15.75f);
			this.s1.ForeColor = global::System.Drawing.Color.Fuchsia;
			this.s1.Location = new global::System.Drawing.Point(10, 155);
			this.s1.Size = new global::System.Drawing.Size(350, 40);
			this.s1.Text = "Уебок ты пиши";
			this.border_6.BackColor = global::System.Drawing.Color.Magenta;
			this.border_6.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.border_6.Location = new global::System.Drawing.Point(811, 1);
			this.border_6.Size = new global::System.Drawing.Size(2, 198);
			this.border_5.BackColor = global::System.Drawing.Color.Magenta;
			this.border_5.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.border_5.Location = new global::System.Drawing.Point(0, 1);
			this.border_5.Size = new global::System.Drawing.Size(2, 198);
			this.border_2.BackColor = global::System.Drawing.Color.Magenta;
			this.border_2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.border_2.Location = new global::System.Drawing.Point(0, 177);
			this.border_2.Size = new global::System.Drawing.Size(813, 1);
			this.border_1.BackColor = global::System.Drawing.Color.Magenta;
			this.border_1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.border_1.Location = new global::System.Drawing.Point(0, 0);
			this.border_1.Size = new global::System.Drawing.Size(813, 1);
			this.main.BackColor = global::System.Drawing.Color.Black;
			this.main.Controls.Add(this.ByPassMessage);
			this.main.Controls.Add(this.Safe1);
			this.main.Controls.Add(this.Safe2);
			this.main.Controls.Add(this.DeadlineTimer);
			this.main.Controls.Add(this.ID);
			this.main.Controls.Add(this.UserInfo);
			this.main.Controls.Add(this.Title);
			this.main.Controls.Add(this.menu1);
			this.main.Controls.Add(this.a2);
			this.main.Controls.Add(this.hdn);
			this.main.Controls.Add(this.a1);
			this.main.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.main.Font = new global::System.Drawing.Font("Pixelify Sans", 9.75f);
			this.main.Location = new global::System.Drawing.Point(0, 0);
			this.main.Size = new global::System.Drawing.Size(1006, 540);
			this.main.Visible = false;
			this.ByPassMessage.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.ByPassMessage.Controls.Add(this.c3);
			this.ByPassMessage.Controls.Add(this.c2);
			this.ByPassMessage.Controls.Add(this.c4);
			this.ByPassMessage.Controls.Add(this.c1);
			this.ByPassMessage.Controls.Add(this.ByPassWarnMsg);
			this.ByPassMessage.Font = new global::System.Drawing.Font("Pixelify Sans", 12f);
			this.ByPassMessage.Location = new global::System.Drawing.Point(324, 208);
			this.ByPassMessage.Size = new global::System.Drawing.Size(373, 178);
			this.ByPassMessage.Visible = false;
			this.c3.BackColor = global::System.Drawing.Color.Magenta;
			this.c3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.c3.Location = new global::System.Drawing.Point(371, 1);
			this.c3.Size = new global::System.Drawing.Size(2, 176);
			this.c2.BackColor = global::System.Drawing.Color.Magenta;
			this.c2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.c2.Location = new global::System.Drawing.Point(0, 1);
			this.c2.Size = new global::System.Drawing.Size(2, 176);
			this.c4.BackColor = global::System.Drawing.Color.Magenta;
			this.c4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.c4.Location = new global::System.Drawing.Point(0, 177);
			this.c4.Size = new global::System.Drawing.Size(373, 1);
			this.c1.BackColor = global::System.Drawing.Color.Magenta;
			this.c1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.c1.Location = new global::System.Drawing.Point(0, 0);
			this.c1.Size = new global::System.Drawing.Size(373, 1);
			this.ByPassWarnMsg.BackColor = global::System.Drawing.Color.HotPink;
			this.ByPassWarnMsg.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ByPassWarnMsg.Font = new global::System.Drawing.Font("Pixelify Sans", 14.25f);
			this.ByPassWarnMsg.ForeColor = global::System.Drawing.Color.White;
			this.ByPassWarnMsg.Text = "Замечена и остановлена попытка снять блокировку!";
			this.ByPassWarnMsg.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Safe1.BackColor = global::System.Drawing.Color.Black;
			this.Safe1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Safe1.Size = new global::System.Drawing.Size(70, 540);
			this.Safe2.BackColor = global::System.Drawing.Color.Black;
			this.Safe2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Safe2.Size = new global::System.Drawing.Size(70, 540);
			this.ID.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
			this.ID.Font = new global::System.Drawing.Font("Pixelify Sans", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.ID.ForeColor = global::System.Drawing.Color.Magenta;
			this.ID.Location = new global::System.Drawing.Point(74, 517);
			this.ID.Size = new global::System.Drawing.Size(856, 23);
			this.ID.Text = "ID: Ошибка идентификации. Обратитесь за резервным кодом.";
			this.ID.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ID.Visible = false;
			this.DeadlineTimer.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.DeadlineTimer.Font = new global::System.Drawing.Font("Pixelify Sans", 20f, global::System.Drawing.FontStyle.Bold);
			this.DeadlineTimer.ForeColor = global::System.Drawing.Color.Magenta;
			this.DeadlineTimer.Location = new global::System.Drawing.Point(600, 10);
			this.DeadlineTimer.Size = new global::System.Drawing.Size(250, 35);
			this.DeadlineTimer.Text = "12:00:00";
			this.DeadlineTimer.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.DeadlineTimer.Visible = false;
			this.UserInfo.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.UserInfo.Font = new global::System.Drawing.Font("Pixelify Sans", 11.25f);
			this.UserInfo.ForeColor = global::System.Drawing.Color.Magenta;
			this.UserInfo.Location = new global::System.Drawing.Point(97, 427);
			this.UserInfo.Size = new global::System.Drawing.Size(645, 23);
			this.UserInfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.UserInfo.Visible = false;
			this.Title.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.Title.BackColor = global::System.Drawing.Color.Magenta;
			this.Title.Font = new global::System.Drawing.Font("Pixelify Sans", 14.25f, global::System.Drawing.FontStyle.Bold);
			this.Title.ForeColor = global::System.Drawing.Color.Black;
			this.Title.Location = new global::System.Drawing.Point(332, 119);
			this.Title.Size = new global::System.Drawing.Size(342, 23);
			this.Title.Text = "Ваши файлы зашифрованы QYABAAAB!";
			this.Title.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.menu1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.menu1.BackColor = global::System.Drawing.Color.Black;
			this.menu1.Font = new global::System.Drawing.Font("Pixelify Sans", 15.75f, global::System.Drawing.FontStyle.Bold);
			this.menu1.ForeColor = global::System.Drawing.Color.Magenta;
			this.menu1.Location = new global::System.Drawing.Point(744, 427);
			this.menu1.Size = new global::System.Drawing.Size(166, 23);
			this.menu1.Text = "[Enter]";
			this.menu1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.menu1.Visible = false;
			this.a2.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.a2.Controls.Add(this.errx);
			this.a2.Controls.Add(this.border_8);
			this.a2.Controls.Add(this.border_7);
			this.a2.Controls.Add(this.border_4);
			this.a2.Controls.Add(this.border_3);
			this.a2.Controls.Add(this.inputPS);
			this.a2.Controls.Add(this.keytext);
			this.a2.Font = new global::System.Drawing.Font("Pixelify Sans", 12f);
			this.a2.Location = new global::System.Drawing.Point(97, 330);
			this.a2.Size = new global::System.Drawing.Size(813, 94);
			this.a2.Visible = false;
			this.errx.BackColor = global::System.Drawing.Color.Transparent;
			this.errx.Font = new global::System.Drawing.Font("Pixelify Sans", 15.75f);
			this.errx.ForeColor = global::System.Drawing.Color.HotPink;
			this.errx.Location = new global::System.Drawing.Point(3, 62);
			this.errx.Size = new global::System.Drawing.Size(807, 30);
			this.errx.Text = "Введённый код не совпадает с кодом разблокировки!";
			this.errx.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.errx.Visible = false;
			this.border_8.BackColor = global::System.Drawing.Color.Magenta;
			this.border_8.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.border_8.Location = new global::System.Drawing.Point(811, 1);
			this.border_8.Size = new global::System.Drawing.Size(2, 92);
			this.border_7.BackColor = global::System.Drawing.Color.Magenta;
			this.border_7.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.border_7.Location = new global::System.Drawing.Point(0, 1);
			this.border_7.Size = new global::System.Drawing.Size(2, 92);
			this.border_4.BackColor = global::System.Drawing.Color.Magenta;
			this.border_4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.border_4.Location = new global::System.Drawing.Point(0, 93);
			this.border_4.Size = new global::System.Drawing.Size(813, 1);
			this.border_3.BackColor = global::System.Drawing.Color.Magenta;
			this.border_3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.border_3.Location = new global::System.Drawing.Point(0, 0);
			this.border_3.Size = new global::System.Drawing.Size(813, 1);
			this.inputPS.BackColor = global::System.Drawing.Color.Magenta;
			this.inputPS.Font = new global::System.Drawing.Font("Pixelify Sans", 15.75f);
			this.inputPS.ForeColor = global::System.Drawing.Color.Black;
			this.inputPS.Location = new global::System.Drawing.Point(8, 29);
			this.inputPS.Size = new global::System.Drawing.Size(797, 25);
			this.inputPS.Text = " ";
			this.inputPS.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.keytext.Font = new global::System.Drawing.Font("Pixelify Sans", 15.75f);
			this.keytext.Location = new global::System.Drawing.Point(3, 6);
			this.keytext.Size = new global::System.Drawing.Size(807, 24);
			this.keytext.Text = "Введите код разблокировки:";
			this.keytext.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.hdn.Location = new global::System.Drawing.Point(-17, 4);
			this.hdn.MaxLength = 45;
			this.hdn.Size = new global::System.Drawing.Size(10, 22);
			this.vmethod_0().Enabled = true;
			this.vmethod_0().Interval = 5;
			this.vmethod_2().Enabled = true;
			this.vmethod_2().Interval = 9;
			this.art.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.art.Font = new global::System.Drawing.Font("Consolas", 15.75f);
			this.art.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("art.Image");
			this.art.Location = new global::System.Drawing.Point(0, 0);
			this.art.Size = new global::System.Drawing.Size(1006, 540);
			this.vmethod_4().Interval = 40;
			this.vmethod_6().Enabled = true;
			this.vmethod_6().Interval = 500;
			this.vmethod_8().Interval = 10;
			this.g1.Click += new global::System.EventHandler(this.method_15);
			this.hdn.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.GForm2_KeyDown);
			this.hdn.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.method_3);
			this.hdn.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.method_7);
			this.inputPS.Click += new global::System.EventHandler(this.method_2);
			this.ByPassWarnMsg.Click += new global::System.EventHandler(this.method_14);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(1006, 540);
			base.Controls.Add(this.main);
			base.Controls.Add(this.art);
			this.ForeColor = global::System.Drawing.Color.Magenta;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			this.a1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.border_6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_1).EndInit();
			this.main.ResumeLayout(false);
			this.main.PerformLayout();
			this.ByPassMessage.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.c3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.c2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.c4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.c1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Safe1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Safe2).EndInit();
			this.a2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.border_8).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.border_3).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400001D RID: 29
		private global::System.ComponentModel.Container container_0;

		// Token: 0x04000027 RID: 39
		public global::System.Windows.Forms.Label g1;

		// Token: 0x04000028 RID: 40
		public global::System.Windows.Forms.Panel a1;

		// Token: 0x04000029 RID: 41
		public global::System.Windows.Forms.Panel main;

		// Token: 0x0400002A RID: 42
		public global::System.Windows.Forms.Panel a2;

		// Token: 0x0400002B RID: 43
		public global::System.Windows.Forms.Label keytext;

		// Token: 0x0400002C RID: 44
		public global::System.Windows.Forms.TextBox hdn;

		// Token: 0x0400002D RID: 45
		public global::System.Windows.Forms.Label inputPS;

		// Token: 0x0400002E RID: 46
		public global::System.Windows.Forms.PictureBox border_6;

		// Token: 0x0400002F RID: 47
		public global::System.Windows.Forms.PictureBox border_5;

		// Token: 0x04000030 RID: 48
		public global::System.Windows.Forms.PictureBox border_2;

		// Token: 0x04000031 RID: 49
		public global::System.Windows.Forms.PictureBox border_1;

		// Token: 0x04000032 RID: 50
		public global::System.Windows.Forms.PictureBox border_8;

		// Token: 0x04000033 RID: 51
		public global::System.Windows.Forms.PictureBox border_7;

		// Token: 0x04000034 RID: 52
		public global::System.Windows.Forms.PictureBox border_4;

		// Token: 0x04000035 RID: 53
		public global::System.Windows.Forms.PictureBox border_3;

		// Token: 0x04000036 RID: 54
		public global::System.Windows.Forms.Label s2;

		// Token: 0x04000037 RID: 55
		public global::System.Windows.Forms.Label s1;

		// Token: 0x04000038 RID: 56
		public global::System.Windows.Forms.Label menu1;

		// Token: 0x04000039 RID: 57
		public global::System.Windows.Forms.Label Title;

		// Token: 0x0400003A RID: 58
		public global::System.Windows.Forms.Label art;

		// Token: 0x0400003B RID: 59
		public global::System.Windows.Forms.Label errx;

		// Token: 0x0400003C RID: 60
		public global::System.Windows.Forms.Label UserInfo;

		// Token: 0x0400003D RID: 61
		public global::System.Windows.Forms.Label ID;

		// Token: 0x0400003E RID: 62
		public global::System.Windows.Forms.PictureBox Safe1;

		// Token: 0x0400003F RID: 63
		public global::System.Windows.Forms.PictureBox Safe2;

		// Token: 0x04000040 RID: 64
		public global::System.Windows.Forms.Panel ByPassMessage;

		// Token: 0x04000041 RID: 65
		public global::System.Windows.Forms.PictureBox c3;

		// Token: 0x04000042 RID: 66
		public global::System.Windows.Forms.PictureBox c2;

		// Token: 0x04000043 RID: 67
		public global::System.Windows.Forms.PictureBox c4;

		// Token: 0x04000044 RID: 68
		public global::System.Windows.Forms.PictureBox c1;

		// Token: 0x04000045 RID: 69
		public global::System.Windows.Forms.Label ByPassWarnMsg;

		// Token: 0x04000046 RID: 70
		public global::System.Windows.Forms.Label DeadlineTimer;
	}
}
