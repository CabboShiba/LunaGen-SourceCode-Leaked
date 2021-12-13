namespace LunaTokenGenV2
{
	// Token: 0x02000024 RID: 36
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x060000DF RID: 223 RVA: 0x000025D2 File Offset: 0x000007D2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000F9AC File Offset: 0x0000DBAC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::LunaTokenGenV2.Login));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.username = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.password = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.gunaElipse1 = new global::Guna.UI.WinForms.GunaElipse(this.components);
			this.guna2AnimateWindow1 = new global::Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.Controls.Add(this.siticoneControlBox2);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(-4, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(944, 37);
			this.panel1.TabIndex = 0;
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.Animated = false;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.HoveredState.FillColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(834, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.PressedDepth = 0;
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 6;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.Animated = false;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(885, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.PressedDepth = 0;
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 5;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Museo Sans 700", 8.999999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(345, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "LUNA GENERATOR - DISCORD COMMUNITY TOOL | LOGIN";
			this.username.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.username.BorderRadius = 5;
			this.username.BorderThickness = 2;
			this.username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.username.DefaultText = "";
			this.username.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.username.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.username.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.DisabledState.Parent = this.username;
			this.username.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.FillColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.username.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.username.FocusedState.Parent = this.username;
			this.username.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.username.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.username.HoverState.Parent = this.username;
			this.username.Location = new global::System.Drawing.Point(278, 267);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderText = "Username";
			this.username.SelectedText = "";
			this.username.ShadowDecoration.Parent = this.username;
			this.username.Size = new global::System.Drawing.Size(359, 49);
			this.username.TabIndex = 1;
			this.password.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.password.BorderRadius = 5;
			this.password.BorderThickness = 2;
			this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.password.DefaultText = "";
			this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.Parent = this.password;
			this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FillColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.password.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.password.FocusedState.Parent = this.password;
			this.password.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.password.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.password.HoverState.Parent = this.password;
			this.password.Location = new global::System.Drawing.Point(278, 322);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.PlaceholderText = "Password";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(359, 49);
			this.password.TabIndex = 2;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(544, 324);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.PressedColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(91, 45);
			this.guna2Button1.TabIndex = 3;
			this.guna2Button1.Text = "LOGIN";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Museo Sans 700", 48f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.label2.Location = new global::System.Drawing.Point(159, 147);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(604, 77);
			this.label2.TabIndex = 4;
			this.label2.Text = "LUNA GENERATOR";
			this.guna2DragControl1.ContainerControl = this;
			this.guna2DragControl1.TargetControl = this.panel1;
			this.gunaElipse1.Radius = 2;
			this.gunaElipse1.TargetControl = this;
			this.guna2AnimateWindow1.TargetForm = this;
			this.guna2Button2.BorderRadius = 8;
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.HoverState.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Location = new global::System.Drawing.Point(290, 377);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.PressedColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new global::System.Drawing.Size(165, 45);
			this.guna2Button2.TabIndex = 5;
			this.guna2Button2.Text = "LOGIN PAGE";
			this.guna2Button3.BorderRadius = 8;
			this.guna2Button3.CheckedState.Parent = this.guna2Button3;
			this.guna2Button3.CustomImages.Parent = this.guna2Button3;
			this.guna2Button3.FillColor = global::System.Drawing.Color.FromArgb(24, 25, 34);
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button3.HoverState.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button3.HoverState.Parent = this.guna2Button3;
			this.guna2Button3.Location = new global::System.Drawing.Point(461, 377);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.PressedColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
			this.guna2Button3.Size = new global::System.Drawing.Size(165, 45);
			this.guna2Button3.TabIndex = 6;
			this.guna2Button3.Text = "REGISTER PAGE";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			base.ClientSize = new global::System.Drawing.Size(930, 581);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Login_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000126 RID: 294
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000127 RID: 295
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000129 RID: 297
		private global::Guna.UI2.WinForms.Guna2TextBox username;

		// Token: 0x0400012A RID: 298
		private global::Guna.UI2.WinForms.Guna2TextBox password;

		// Token: 0x0400012B RID: 299
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400012D RID: 301
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400012E RID: 302
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400012F RID: 303
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x04000130 RID: 304
		private global::Guna.UI.WinForms.GunaElipse gunaElipse1;

		// Token: 0x04000131 RID: 305
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

		// Token: 0x04000132 RID: 306
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		// Token: 0x04000133 RID: 307
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;
	}
}
