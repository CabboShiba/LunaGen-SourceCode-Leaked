namespace LunaTokenGenV2
{
	// Token: 0x02000028 RID: 40
	public partial class Settings_Tab : global::System.Windows.Forms.Form
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00002713 File Offset: 0x00000913
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000121B8 File Offset: 0x000103B8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.guna2CustomCheckBox1 = new global::Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.gunaElipse1 = new global::Guna.UI.WinForms.GunaElipse(this.components);
			this.guna2AnimateWindow1 = new global::Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			base.SuspendLayout();
			this.guna2CustomCheckBox1.Animated = true;
			this.guna2CustomCheckBox1.BackColor = global::System.Drawing.Color.FromArgb(22, 23, 33);
			this.guna2CustomCheckBox1.Checked = true;
			this.guna2CustomCheckBox1.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(127, 120, 222);
			this.guna2CustomCheckBox1.CheckedState.BorderRadius = 2;
			this.guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
			this.guna2CustomCheckBox1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(127, 120, 222);
			this.guna2CustomCheckBox1.CheckedState.Parent = this.guna2CustomCheckBox1;
			this.guna2CustomCheckBox1.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.guna2CustomCheckBox1.Location = new global::System.Drawing.Point(275, 37);
			this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
			this.guna2CustomCheckBox1.ShadowDecoration.Parent = this.guna2CustomCheckBox1;
			this.guna2CustomCheckBox1.Size = new global::System.Drawing.Size(20, 20);
			this.guna2CustomCheckBox1.TabIndex = 7;
			this.guna2CustomCheckBox1.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(127, 120, 222);
			this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 2;
			this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 1;
			this.guna2CustomCheckBox1.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.guna2CustomCheckBox1.UncheckedState.Parent = this.guna2CustomCheckBox1;
			this.guna2CustomCheckBox1.CheckedChanged += new global::System.EventHandler(this.guna2CustomCheckBox1_CheckedChanged);
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.FromArgb(22, 23, 33);
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(12, 37);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(133, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "Overlay Application";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.FromArgb(22, 23, 33);
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(72, 18);
			this.label1.TabIndex = 9;
			this.label1.Text = "TopMost:";
			this.guna2Button2.Animated = true;
			this.guna2Button2.BorderColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.guna2Button2.BorderRadius = 4;
			this.guna2Button2.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = global::System.Drawing.Color.FromArgb(26, 26, 36);
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.HoverState.FillColor = global::System.Drawing.Color.FromArgb(99, 74, 171);
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Location = new global::System.Drawing.Point(213, 270);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.PressedColor = global::System.Drawing.Color.FromArgb(23, 24, 33);
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new global::System.Drawing.Size(89, 30);
			this.guna2Button2.TabIndex = 11;
			this.guna2Button2.Text = "Close";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.guna2Button1.Animated = true;
			this.guna2Button1.BorderColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.guna2Button1.BorderRadius = 4;
			this.guna2Button1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(99, 74, 171);
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(118, 270);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.PressedColor = global::System.Drawing.Color.FromArgb(23, 24, 33);
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(89, 30);
			this.guna2Button1.TabIndex = 12;
			this.guna2Button1.Text = "Save Settings";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.gunaElipse1.Radius = 6;
			this.gunaElipse1.TargetControl = this;
			this.guna2AnimateWindow1.Interval = 100;
			this.guna2AnimateWindow1.TargetForm = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(22, 23, 33);
			base.ClientSize = new global::System.Drawing.Size(314, 312);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.guna2CustomCheckBox1);
			base.Controls.Add(this.label4);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Settings_Tab";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings_Tab";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Settings_Tab_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000149 RID: 329
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400014A RID: 330
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400014D RID: 333
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x0400014E RID: 334
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x0400014F RID: 335
		private global::Guna.UI.WinForms.GunaElipse gunaElipse1;

		// Token: 0x04000150 RID: 336
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
	}
}
