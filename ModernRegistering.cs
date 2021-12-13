using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace LunaTokenGenV2
{
	// Token: 0x02000025 RID: 37
	public partial class ModernRegistering : Form
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x000025F1 File Offset: 0x000007F1
		public ModernRegistering()
		{
			Login.Lunaauth.init();
			this.InitializeComponent();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002568 File Offset: 0x00000768
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000107F4 File Offset: 0x0000E9F4
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Login.Lunaauth.register(this.username.Text, this.password.Text, this.key.Text);
			LunaTokenCreator lunaTokenCreator = new LunaTokenCreator();
			lunaTokenCreator.Show();
			base.Hide();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002610 File Offset: 0x00000810
		private void Login_Load(object sender, EventArgs e)
		{
			if (Login.Lunaauth.checkblack())
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00010840 File Offset: 0x0000EA40
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			base.Hide();
			login.Show();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002624 File Offset: 0x00000824
		private void smo_CheckedChanged(object sender, EventArgs e)
		{
			if (this.smo.Checked)
			{
				this.password.UseSystemPasswordChar = false;
			}
			else
			{
				this.password.UseSystemPasswordChar = true;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000264D File Offset: 0x0000084D
		private void termsofservice_CheckedChanged(object sender, EventArgs e)
		{
			if (this.termsofservice.Checked)
			{
				this.guna2Button1.Enabled = true;
			}
			else
			{
				this.guna2Button1.Enabled = false;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002676 File Offset: 0x00000876
		private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.lunaraids.com/tos.html");
		}
	}
}
