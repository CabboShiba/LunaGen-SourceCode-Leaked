using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using LunaTokenGenV2.Properties;

namespace LunaTokenGenV2
{
	// Token: 0x02000028 RID: 40
	public partial class Settings_Tab : Form
	{
		// Token: 0x060000EE RID: 238 RVA: 0x000026BF File Offset: 0x000008BF
		public Settings_Tab()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000026D4 File Offset: 0x000008D4
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000026DC File Offset: 0x000008DC
		private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.guna2CustomCheckBox1.Checked)
			{
				Settings_Tab.Toppymost = false;
			}
			else
			{
				Settings_Tab.Toppymost = true;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00012168 File Offset: 0x00010368
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Settings.Default.Topmost1 = Settings_Tab.Toppymost;
			Settings.Default.TopmostSetting = this.guna2CustomCheckBox1.Checked;
			Settings.Default.Save();
			LunaTokenCreator lunaTokenCreator = new LunaTokenCreator();
			base.Close();
			lunaTokenCreator.Activate();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000026FC File Offset: 0x000008FC
		private void Settings_Tab_Load(object sender, EventArgs e)
		{
			this.guna2CustomCheckBox1.Checked = Settings.Default.TopmostSetting;
		}

		// Token: 0x04000148 RID: 328
		public static bool Toppymost;
	}
}
