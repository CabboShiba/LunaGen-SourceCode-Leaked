namespace LunaTokenGenV2
{
	// Token: 0x02000025 RID: 37
	public partial class ModernRegistering : global::System.Windows.Forms.Form
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00002683 File Offset: 0x00000883
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00010860 File Offset: 0x0000EA60
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::LunaTokenGenV2.ModernRegistering));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.Email = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.key = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.gunaElipse1 = new global::Guna.UI.WinForms.GunaElipse(this.components);
			this.guna2AnimateWindow1 = new global::Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2Button4 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button5 = new global::Guna.UI2.WinForms.Guna2Button();
			this.username = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.password = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.smo = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.termsofservice = new global::Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.gunaLinkLabel1 = new global::Guna.UI.WinForms.GunaLinkLabel();
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
			this.label1.Size = new global::System.Drawing.Size(364, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "LUNA GENERATOR - DISCORD COMMUNITY TOOL | REGISTER";
			this.Email.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.Email.BorderRadius = 5;
			this.Email.BorderThickness = 2;
			this.Email.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Email.DefaultText = "";
			this.Email.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Email.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Email.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Email.DisabledState.Parent = this.Email;
			this.Email.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Email.FillColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.Email.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.Email.FocusedState.Parent = this.Email;
			this.Email.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Email.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.Email.HoverState.Parent = this.Email;
			this.Email.Location = new global::System.Drawing.Point(278, 187);
			this.Email.Name = "Email";
			this.Email.PasswordChar = '\0';
			this.Email.PlaceholderText = "Email";
			this.Email.SelectedText = "";
			this.Email.ShadowDecoration.Parent = this.Email;
			this.Email.Size = new global::System.Drawing.Size(359, 49);
			this.Email.TabIndex = 1;
			this.key.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.key.BorderRadius = 5;
			this.key.BorderThickness = 2;
			this.key.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.key.DefaultText = "";
			this.key.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.key.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.key.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.DisabledState.Parent = this.key;
			this.key.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.FillColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.key.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.key.FocusedState.Parent = this.key;
			this.key.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.key.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.key.HoverState.Parent = this.key;
			this.key.Location = new global::System.Drawing.Point(278, 395);
			this.key.Name = "key";
			this.key.PasswordChar = '\0';
			this.key.PlaceholderText = "License";
			this.key.SelectedText = "";
			this.key.ShadowDecoration.Parent = this.key;
			this.key.Size = new global::System.Drawing.Size(359, 49);
			this.key.TabIndex = 2;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.DialogResult = global::System.Windows.Forms.DialogResult.Yes;
			this.guna2Button1.Enabled = false;
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(43, 120, 237);
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(544, 397);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.PressedColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(91, 45);
			this.guna2Button1.TabIndex = 3;
			this.guna2Button1.Text = "REGISTER";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Museo Sans 700", 48f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.label2.Location = new global::System.Drawing.Point(155, 95);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(604, 77);
			this.label2.TabIndex = 4;
			this.label2.Text = "LUNA GENERATOR";
			this.guna2DragControl1.ContainerControl = this;
			this.guna2DragControl1.TargetControl = this.panel1;
			this.gunaElipse1.Radius = 2;
			this.gunaElipse1.TargetControl = this;
			this.guna2AnimateWindow1.TargetForm = this;
			this.guna2Button4.BorderRadius = 8;
			this.guna2Button4.CheckedState.Parent = this.guna2Button4;
			this.guna2Button4.CustomImages.Parent = this.guna2Button4;
			this.guna2Button4.FillColor = global::System.Drawing.Color.FromArgb(24, 25, 34);
			this.guna2Button4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button4.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button4.HoverState.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button4.HoverState.Parent = this.guna2Button4;
			this.guna2Button4.Location = new global::System.Drawing.Point(289, 450);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.PressedColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
			this.guna2Button4.Size = new global::System.Drawing.Size(165, 45);
			this.guna2Button4.TabIndex = 8;
			this.guna2Button4.Text = "LOGIN PAGE";
			this.guna2Button4.Click += new global::System.EventHandler(this.guna2Button4_Click);
			this.guna2Button5.BorderRadius = 8;
			this.guna2Button5.CheckedState.Parent = this.guna2Button5;
			this.guna2Button5.CustomImages.Parent = this.guna2Button5;
			this.guna2Button5.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button5.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button5.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button5.HoverState.FillColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button5.HoverState.Parent = this.guna2Button5;
			this.guna2Button5.Location = new global::System.Drawing.Point(460, 450);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.PressedColor = global::System.Drawing.Color.FromArgb(129, 120, 221);
			this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
			this.guna2Button5.Size = new global::System.Drawing.Size(165, 45);
			this.guna2Button5.TabIndex = 7;
			this.guna2Button5.Text = "REGISTER PAGE";
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
			this.username.Location = new global::System.Drawing.Point(278, 242);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderText = "Username";
			this.username.SelectedText = "";
			this.username.ShadowDecoration.Parent = this.username;
			this.username.Size = new global::System.Drawing.Size(359, 49);
			this.username.TabIndex = 9;
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
			this.password.Location = new global::System.Drawing.Point(278, 297);
			this.password.Name = "password";
			this.password.PasswordChar = '\0';
			this.password.PlaceholderText = "Password";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(359, 49);
			this.password.TabIndex = 10;
			this.password.UseSystemPasswordChar = true;
			this.smo.Animated = true;
			this.smo.AutoSize = true;
			this.smo.BackColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.smo.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.smo.CheckedState.BorderRadius = 2;
			this.smo.CheckedState.BorderThickness = 1;
			this.smo.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.smo.ForeColor = global::System.Drawing.Color.White;
			this.smo.Location = new global::System.Drawing.Point(411, 501);
			this.smo.Name = "smo";
			this.smo.Size = new global::System.Drawing.Size(101, 17);
			this.smo.TabIndex = 48;
			this.smo.Text = "Show password";
			this.smo.UncheckedState.BorderColor = global::System.Drawing.Color.Gray;
			this.smo.UncheckedState.BorderRadius = 2;
			this.smo.UncheckedState.BorderThickness = 1;
			this.smo.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 43);
			this.smo.UseVisualStyleBackColor = false;
			this.smo.CheckedChanged += new global::System.EventHandler(this.smo_CheckedChanged);
			this.termsofservice.Animated = true;
			this.termsofservice.BackColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.termsofservice.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.termsofservice.CheckedState.BorderRadius = 2;
			this.termsofservice.CheckedState.BorderThickness = 0;
			this.termsofservice.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.termsofservice.CheckedState.Parent = this.termsofservice;
			this.termsofservice.Location = new global::System.Drawing.Point(278, 358);
			this.termsofservice.Name = "termsofservice";
			this.termsofservice.ShadowDecoration.Parent = this.termsofservice;
			this.termsofservice.Size = new global::System.Drawing.Size(30, 28);
			this.termsofservice.TabIndex = 51;
			this.termsofservice.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(168, 171, 174);
			this.termsofservice.UncheckedState.BorderRadius = 5;
			this.termsofservice.UncheckedState.BorderThickness = 1;
			this.termsofservice.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(54, 57, 63);
			this.termsofservice.UncheckedState.Parent = this.termsofservice;
			this.termsofservice.CheckedChanged += new global::System.EventHandler(this.termsofservice_CheckedChanged);
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.label6.Font = new global::System.Drawing.Font("Museo Sans 500", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.FromArgb(168, 171, 174);
			this.label6.Location = new global::System.Drawing.Point(313, 359);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(172, 13);
			this.label6.TabIndex = 50;
			this.label6.Text = "I have read and agree to Luna's ";
			this.gunaLinkLabel1.ActiveLinkColor = global::System.Drawing.Color.FromArgb(9, 156, 214);
			this.gunaLinkLabel1.AutoSize = true;
			this.gunaLinkLabel1.BackColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			this.gunaLinkLabel1.Font = new global::System.Drawing.Font("Museo Sans 300", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.gunaLinkLabel1.LinkBehavior = global::System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.gunaLinkLabel1.LinkColor = global::System.Drawing.Color.FromArgb(9, 156, 214);
			this.gunaLinkLabel1.Location = new global::System.Drawing.Point(313, 372);
			this.gunaLinkLabel1.Name = "gunaLinkLabel1";
			this.gunaLinkLabel1.Size = new global::System.Drawing.Size(90, 13);
			this.gunaLinkLabel1.TabIndex = 49;
			this.gunaLinkLabel1.TabStop = true;
			this.gunaLinkLabel1.Text = "Terms of Service";
			this.gunaLinkLabel1.VisitedLinkColor = global::System.Drawing.Color.FromArgb(9, 156, 218);
			this.gunaLinkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(21, 23, 32);
			base.ClientSize = new global::System.Drawing.Size(930, 581);
			base.Controls.Add(this.termsofservice);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.gunaLinkLabel1);
			base.Controls.Add(this.smo);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.guna2Button4);
			base.Controls.Add(this.guna2Button5);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.key);
			base.Controls.Add(this.Email);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "ModernRegistering";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Login_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000134 RID: 308
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000137 RID: 311
		private global::Guna.UI2.WinForms.Guna2TextBox Email;

		// Token: 0x04000138 RID: 312
		private global::Guna.UI2.WinForms.Guna2TextBox key;

		// Token: 0x04000139 RID: 313
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400013B RID: 315
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400013C RID: 316
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400013D RID: 317
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x0400013E RID: 318
		private global::Guna.UI.WinForms.GunaElipse gunaElipse1;

		// Token: 0x0400013F RID: 319
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

		// Token: 0x04000140 RID: 320
		private global::Guna.UI2.WinForms.Guna2Button guna2Button4;

		// Token: 0x04000141 RID: 321
		private global::Guna.UI2.WinForms.Guna2Button guna2Button5;

		// Token: 0x04000142 RID: 322
		private global::Guna.UI2.WinForms.Guna2TextBox password;

		// Token: 0x04000143 RID: 323
		private global::Guna.UI2.WinForms.Guna2TextBox username;

		// Token: 0x04000144 RID: 324
		private global::Guna.UI2.WinForms.Guna2CheckBox smo;

		// Token: 0x04000145 RID: 325
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox termsofservice;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000147 RID: 327
		private global::Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
	}
}
