using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Leaf.xNet;
using LunaTokenGenV2.Properties;
using Microsoft.VisualBasic;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace LunaTokenGenV2
{
	// Token: 0x02000010 RID: 16
	public partial class LunaTokenCreator : Form
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00006FE0 File Offset: 0x000051E0
		public LunaTokenCreator()
		{
			this.InitializeComponent();
			this.user = Login.Lunaauth.user_data.username;
			if (this.user == Login.Lunaauth.user_data.username)
			{
				this.urlserver1 = Login.Lunaauth.var("Nemic");
				this.urlserver2 = Login.Lunaauth.var("Tfhnql");
				this.urlserver3 = Login.Lunaauth.var("Nwtlk");
			}
			else
			{
				MessageBox.Show("Failed to authenticate user, Servers are now locked for protection. Please try and reopen and login again. If this issue continues please contact a develop+ on the community discord server!");
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000717C File Offset: 0x0000537C
		public void LoadTokens()
		{
			foreach (string string_ in Utils.SplitToLines(this.outpostedtokens.Text))
			{
				try
				{
					string cleanToken = Utils.GetCleanToken(string_);
					bool flag = false;
					if (Utils.IsTokenFormatValid(cleanToken))
					{
						try
						{
							foreach (DiscordClient discordClient in this.clients)
							{
								try
								{
									if (discordClient.token == cleanToken)
									{
										flag = true;
										break;
									}
								}
								catch
								{
								}
							}
						}
						catch
						{
						}
						if (!flag)
						{
							this.clients.Add(new DiscordClient(cleanToken));
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00007288 File Offset: 0x00005488
		private void Center(Form form_0)
		{
			form_0.Location = new Point(Screen.PrimaryScreen.Bounds.Size.Width / 2 - form_0.Size.Width / 2, Screen.PrimaryScreen.Bounds.Size.Height / 2 - form_0.Size.Height / 2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000072FC File Offset: 0x000054FC
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.guna2Button1.FillColor = Color.FromArgb(23, 24, 33);
			if (this.ServerSelection.SelectedIndex == 1)
			{
				this.tokensload.Text = this.WebClient1.DownloadString(this.urlserver1);
				Thread.Sleep(1000);
				Thread thread = new Thread(new ThreadStart(this.GetTokens));
				thread.Start();
			}
			if (this.ServerSelection.SelectedIndex == 2)
			{
				this.tokensload.Text = this.WebClient1.DownloadString(this.urlserver2);
				Thread.Sleep(1000);
				Thread thread2 = new Thread(new ThreadStart(this.GetTokens));
				thread2.Start();
			}
			if (this.ServerSelection.SelectedIndex == 3)
			{
				this.tokensload.Text = this.WebClient1.DownloadString(this.urlserver3);
				Thread.Sleep(1000);
				Thread thread3 = new Thread(new ThreadStart(this.GetTokens));
				thread3.Start();
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000740C File Offset: 0x0000560C
		public void GetTokens()
		{
			if (!(this.tokensload.Text == ""))
			{
				string[] allLines = this.tokensload.Text.Split(new char[]
				{
					'\n'
				});
				Task.Factory.StartNew(delegate()
				{
					if (!this.joindizzy.Checked)
					{
						string[] allLines;
						foreach (string text in allLines)
						{
							Thread.Sleep(500);
							if (this.outpostedtokens.Text == "")
							{
								this.outpostedtokens.Text = text;
								this.outpostedtokens.Text = this.outpostedtokens.Text + Environment.NewLine;
								this.outpostedtokens.SelectionStart = this.outpostedtokens.TextLength;
								this.outpostedtokens.ScrollToCaret();
								int num = this.outpostedtokens.Lines.Count<string>();
								this.label5.Text = "This session: " + num.ToString();
								this.label9.Text = num.ToString();
								this.label10.Text = num.ToString();
							}
							else
							{
								this.outpostedtokens.AppendText(text);
								this.outpostedtokens.Text = this.outpostedtokens.Text + Environment.NewLine;
								this.outpostedtokens.SelectionStart = this.outpostedtokens.TextLength;
								this.outpostedtokens.ScrollToCaret();
								int num2 = this.outpostedtokens.Lines.Count<string>();
								this.label5.Text = "This session: " + num2.ToString();
								this.label9.Text = num2.ToString();
								this.label10.Text = num2.ToString();
							}
							Thread.Sleep(500);
						}
					}
					else
					{
						string[] allLines;
						foreach (string text2 in allLines)
						{
							Thread.Sleep(500);
							if (this.outpostedtokens.Text == "")
							{
								this.outpostedtokens.Text = text2;
								this.outpostedtokens.Text = this.outpostedtokens.Text + Environment.NewLine;
								this.outpostedtokens.SelectionStart = this.outpostedtokens.TextLength;
								this.outpostedtokens.ScrollToCaret();
								int num3 = this.outpostedtokens.Lines.Count<string>();
								this.label5.Text = "This session: " + num3.ToString();
								this.label9.Text = num3.ToString();
								this.label10.Text = num3.ToString();
								string text3 = this.ServerInvite.Text;
								text3 = text3.Replace("https://discord.gg/", "");
								TokenSettings.JoinServer(text2, text3, false, "", Color.FromArgb(105, 105, 205));
							}
							else
							{
								this.outpostedtokens.AppendText(text2);
								this.outpostedtokens.Text = this.outpostedtokens.Text + Environment.NewLine;
								this.outpostedtokens.SelectionStart = this.outpostedtokens.TextLength;
								this.outpostedtokens.ScrollToCaret();
								int num4 = this.outpostedtokens.Lines.Count<string>();
								this.label5.Text = "This session: " + num4.ToString();
								this.label9.Text = num4.ToString();
								this.label10.Text = num4.ToString();
								string text4 = this.ServerInvite.Text;
								text4 = text4.Replace("https://discord.gg/", "");
								TokenSettings.JoinServer(text2, text4, false, "", Color.FromArgb(105, 105, 205));
							}
							Thread.Sleep(500);
						}
					}
				});
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00007478 File Offset: 0x00005678
		public HttpProxyClient GetProxy()
		{
			HttpProxyClient result;
			try
			{
				result = null;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000074A0 File Offset: 0x000056A0
		public void JoinGuild(string string_0, string string_1, string string_2, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
		{
			try
			{
				DiscordInvite invite = Utils.GetInviteInformations(string_0, bool_3);
				string contextProperties = "";
				if (!bool_3)
				{
					contextProperties = Utils.GetXCP(invite);
				}
				else
				{
					contextProperties = Utils.smethod_1(invite);
				}
				using (List<DiscordClient>.Enumerator enumerator = this.GetClients().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DiscordClient client = enumerator.Current;
						try
						{
							Thread.Sleep(5);
							Thread thread = new Thread(delegate()
							{
								this.ClientJoin(client, invite, contextProperties, string_1, string_2, bool_0, bool_1, bool_2, bool_3, this.GetProxy(), null);
							});
							thread.Start();
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000024E4 File Offset: 0x000006E4
		private void LunaTokenCreator_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.Totalgenlog = this.label9.Text;
			Settings.Default.Validgentoken = this.label10.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000075E0 File Offset: 0x000057E0
		public List<DiscordClient> GetClients()
		{
			List<DiscordClient> result;
			if (this.guna2CustomCheckBox1.Checked)
			{
				List<DiscordClient> list = new List<DiscordClient>();
				int num = 1;
				string text = this.gunaLineTextBox1.Text.Replace(" ", "").Replace('\t'.ToString(), "");
				if (text.Length <= 6 && Information.IsNumeric(text))
				{
					int num2 = int.Parse(text);
					if (num2 > 0)
					{
						num = num2;
					}
				}
				int num3 = 0;
				foreach (DiscordClient discordClient in this.clients)
				{
					if (num3 == num)
					{
						break;
					}
					list.Add(this.clients[num3]);
					num3++;
				}
				result = list;
			}
			else
			{
				result = this.clients;
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000076D0 File Offset: 0x000058D0
		public void ClientJoin(DiscordClient discordClient_0, DiscordInvite discordInvite_0, string string_0, string string_1, string string_2, bool bool_0, bool bool_1, bool bool_2, bool bool_3, HttpProxyClient httpProxyClient_0, string string_3)
		{
			discordClient_0.JoinGuild1(discordInvite_0, string_0, string_1, string_2, bool_0, bool_1, bool_2, bool_3, httpProxyClient_0, string_3);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000076F8 File Offset: 0x000058F8
		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			Form form = new Form();
			try
			{
				using (Settings_Tab settings_Tab = new Settings_Tab())
				{
					form.StartPosition = FormStartPosition.Manual;
					form.FormBorderStyle = FormBorderStyle.None;
					form.Opacity = 0.7;
					form.BackColor = Color.Black;
					form.WindowState = FormWindowState.Maximized;
					form.TopMost = true;
					form.Location = base.Location;
					form.ShowInTaskbar = false;
					form.Show();
					settings_Tab.Owner = form;
					settings_Tab.ShowDialog();
					form.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				form.Dispose();
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000251A File Offset: 0x0000071A
		private void LunaTokenCreator_Load(object sender, EventArgs e)
		{
			this.label9.Text = Settings.Default.Totalgenlog;
			this.label10.Text = Settings.Default.Validgentoken;
			this.Center(this);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000254D File Offset: 0x0000074D
		private void LunaTokenCreator_Activated(object sender, EventArgs e)
		{
			base.TopMost = Settings.Default.Topmost1;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000255F File Offset: 0x0000075F
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			this.processing = false;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000024BD File Offset: 0x000006BD
		private void outpostedtokens_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000255F File Offset: 0x0000075F
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			this.processing = false;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002568 File Offset: 0x00000768
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0400005D RID: 93
		public List<DiscordClient> clients = new List<DiscordClient>();

		// Token: 0x0400005E RID: 94
		public List<string> invalidTokens = new List<string>();

		// Token: 0x0400005F RID: 95
		public int doneCheckingTokens = 0;

		// Token: 0x04000060 RID: 96
		public List<string> proxies = new List<string>();

		// Token: 0x04000061 RID: 97
		public List<string> invalidProxies = new List<string>();

		// Token: 0x04000062 RID: 98
		public int doneCheckingProxies = 0;

		// Token: 0x04000063 RID: 99
		public int proxyIndex = 0;

		// Token: 0x04000064 RID: 100
		public bool serverSpammer;

		// Token: 0x04000065 RID: 101
		public bool dmSpammer;

		// Token: 0x04000066 RID: 102
		public bool typingSpammer;

		// Token: 0x04000067 RID: 103
		public bool webhookSpammer;

		// Token: 0x04000068 RID: 104
		public bool massDmAdvertiser;

		// Token: 0x04000069 RID: 105
		public int multipleMessageIndex = 0;

		// Token: 0x0400006A RID: 106
		public int multipleDmMessageIndex = 0;

		// Token: 0x0400006B RID: 107
		public int multipleWebhookMessageIndex = 0;

		// Token: 0x0400006C RID: 108
		public int multipleDmAdvertiserMessageIndex = 0;

		// Token: 0x0400006D RID: 109
		public int tagAllIndex = 0;

		// Token: 0x0400006E RID: 110
		public int rolesTagAllIndex = 0;

		// Token: 0x0400006F RID: 111
		public int completedUsers = 0;

		// Token: 0x04000070 RID: 112
		private string[] mediaFormats = new string[]
		{
			"jpg",
			"png",
			"bmp",
			"jpeg",
			"jfif",
			"jpe",
			"rle",
			"dib",
			"svg",
			"svgz"
		};

		// Token: 0x04000071 RID: 113
		public bool tokensChanged;

		// Token: 0x04000072 RID: 114
		private string user;

		// Token: 0x04000073 RID: 115
		private string urlserver1;

		// Token: 0x04000074 RID: 116
		private string urlserver2;

		// Token: 0x04000075 RID: 117
		private string urlserver3;

		// Token: 0x04000076 RID: 118
		private string mainurl;

		// Token: 0x04000077 RID: 119
		private string tokenslist;

		// Token: 0x04000078 RID: 120
		private bool processing = false;

		// Token: 0x04000079 RID: 121
		private bool totalgenedtoggle = false;

		// Token: 0x0400007A RID: 122
		private bool Validgenedtoggle = false;

		// Token: 0x0400007B RID: 123
		private bool InValidgenedtoggle = false;

		// Token: 0x0400007C RID: 124
		private bool alreadystarted = false;

		// Token: 0x0400007D RID: 125
		private WebClient WebClient1 = new WebClient();
	}
}
