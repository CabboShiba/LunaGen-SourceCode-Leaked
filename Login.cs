using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace LunaTokenGenV2
{
	// Token: 0x02000024 RID: 36
	public partial class Login : Form
	{
		// Token: 0x060000DA RID: 218 RVA: 0x000025A8 File Offset: 0x000007A8
		public Login()
		{
			Login.Lunaauth.init();
			this.InitializeComponent();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002568 File Offset: 0x00000768
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000F95C File Offset: 0x0000DB5C
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Login.Lunaauth.login(this.username.Text, this.password.Text);
			if (Login.Lunaauth.checkblack())
			{
				Environment.Exit(0);
			}
			new LunaTokenCreator().Show();
			base.Hide();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000024BD File Offset: 0x000006BD
		private void Login_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000025C0 File Offset: 0x000007C0
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			Control control = new ModernRegistering();
			base.Hide();
			control.Show();
		}

		// Token: 0x04000121 RID: 289
		private static string name = "Luna Token GenV2";

		// Token: 0x04000122 RID: 290
		private static string ownerid = "ug6Y9vPFGT";

		// Token: 0x04000123 RID: 291
		private static string secret = "1c4ba43d21c604c3d54a8b96211402e3a7b08e91dfaac9c3ee8b6d4dcd519757";

		// Token: 0x04000124 RID: 292
		private static string version = "1.o";

		// Token: 0x04000125 RID: 293
		public static api Lunaauth = new api(Login.name, Login.ownerid, Login.secret, Login.version);
	}
}
