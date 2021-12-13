using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using Leaf.xNet;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace LunaTokenGenV2
{
	// Token: 0x02000016 RID: 22
	public class DiscordClient
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x0000A2C0 File Offset: 0x000084C0
		public DiscordClient(string string_0)
		{
			try
			{
				this.token = string_0;
				this.userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0";
			}
			catch
			{
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000A360 File Offset: 0x00008560
		public string GetUserId()
		{
			string result2;
			try
			{
				if (!(this.userId != ""))
				{
					try
					{
						HttpRequest httpRequest = Utils.CreateCleanRequest();
						httpRequest.AddHeader("Accept", "*/*");
						httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
						httpRequest.AddHeader("Accept-Language", this.GetLanguage());
						httpRequest.AddHeader("Alt-Used", "discord.com");
						httpRequest.AddHeader("Authorization", this.token);
						httpRequest.AddHeader("Connection", "keep-alive");
						httpRequest.AddHeader("Cookie", this.GetCookie(""));
						httpRequest.AddHeader("DNT", "1");
						httpRequest.AddHeader("Host", "discord.com");
						httpRequest.AddHeader("Origin", "https://discord.com");
						httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
						httpRequest.AddHeader("TE", "Trailers");
						httpRequest.AddHeader("User-Agent", this.userAgent);
						httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
						object arg = JObject.Parse(Utils.DecompressResponse(httpRequest.Get("https://discord.com/api/v9/users/@me", null)));
						if (DiscordClient.<>o__17.<>p__1 == null)
						{
							DiscordClient.<>o__17.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
						}
						Func<CallSite, object, string> target = DiscordClient.<>o__17.<>p__1.Target;
						CallSite <>p__ = DiscordClient.<>o__17.<>p__1;
						if (DiscordClient.<>o__17.<>p__0 == null)
						{
							DiscordClient.<>o__17.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						string result = target(<>p__, DiscordClient.<>o__17.<>p__0.Target(DiscordClient.<>o__17.<>p__0, arg));
						this.userId = result;
						return result;
					}
					catch
					{
						return "";
					}
				}
				result2 = this.userId;
			}
			catch
			{
				result2 = "";
			}
			return result2;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000A580 File Offset: 0x00008780
		public void SetNickname(string string_0, string string_1, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				string text = "{\"nick\":\"" + string_1 + "\"}";
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Length", text.Length.ToString());
				httpRequest.AddHeader("Content-Type", "application/json");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				httpRequest.Patch("https://discord.com/api/v9/guilds/" + string_0 + "/members/@me", text, "application/json");
			}
			catch
			{
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000A710 File Offset: 0x00008910
		public string GetDMChannel(string string_0, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				string value = Utils.DecompressResponse(httpRequest.Get("https://discord.com/api/v9/users/@me/channels", null));
				object arg = JsonConvert.DeserializeObject(value);
				if (DiscordClient.<>o__19.<>p__6 == null)
				{
					DiscordClient.<>o__19.<>p__6 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(DiscordClient)));
				}
				foreach (object arg2 in DiscordClient.<>o__19.<>p__6.Target(DiscordClient.<>o__19.<>p__6, arg))
				{
					try
					{
						if (DiscordClient.<>o__19.<>p__5 == null)
						{
							DiscordClient.<>o__19.<>p__5 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(DiscordClient)));
						}
						Func<CallSite, object, IEnumerable> target = DiscordClient.<>o__19.<>p__5.Target;
						CallSite <>p__ = DiscordClient.<>o__19.<>p__5;
						if (DiscordClient.<>o__19.<>p__0 == null)
						{
							DiscordClient.<>o__19.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "recipients", typeof(DiscordClient), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						foreach (object arg3 in target(<>p__, DiscordClient.<>o__19.<>p__0.Target(DiscordClient.<>o__19.<>p__0, arg2)))
						{
							try
							{
								if (DiscordClient.<>o__19.<>p__2 == null)
								{
									DiscordClient.<>o__19.<>p__2 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
								}
								Func<CallSite, object, string> target2 = DiscordClient.<>o__19.<>p__2.Target;
								CallSite <>p__2 = DiscordClient.<>o__19.<>p__2;
								if (DiscordClient.<>o__19.<>p__1 == null)
								{
									DiscordClient.<>o__19.<>p__1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								if (target2(<>p__2, DiscordClient.<>o__19.<>p__1.Target(DiscordClient.<>o__19.<>p__1, arg3)) == string_0)
								{
									if (DiscordClient.<>o__19.<>p__4 == null)
									{
										DiscordClient.<>o__19.<>p__4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
									}
									Func<CallSite, object, string> target3 = DiscordClient.<>o__19.<>p__4.Target;
									CallSite <>p__3 = DiscordClient.<>o__19.<>p__4;
									if (DiscordClient.<>o__19.<>p__3 == null)
									{
										DiscordClient.<>o__19.<>p__3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									return target3(<>p__3, DiscordClient.<>o__19.<>p__3.Target(DiscordClient.<>o__19.<>p__3, arg2));
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
				}
				return this.CreateDM(string_0, httpProxyClient_0);
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000AB3C File Offset: 0x00008D3C
		public void SetAvatar(Image image_0, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				image_0.Save(memoryStream, image_0.RawFormat);
				this.SetAvatar(Convert.ToBase64String(memoryStream.ToArray()), httpProxyClient_0);
			}
			catch
			{
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000AB84 File Offset: 0x00008D84
		public void SetAvatar(string string_0, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				string text = "{\"avatar\":\"data:image/png;base64," + string_0 + "\"}";
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Length", text.Length.ToString());
				httpRequest.AddHeader("Content-Type", "application/json");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				httpRequest.Patch("https://discord.com/api/v9/users/@me", text, "application/json");
			}
			catch
			{
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		public void ResetAvatar(HttpProxyClient httpProxyClient_0)
		{
			try
			{
				string text = "{\"avatar\":null}";
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Length", text.Length.ToString());
				httpRequest.AddHeader("Content-Type", "application/json");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				httpRequest.Patch("https://discord.com/api/v9/users/@me", text, "application/json");
			}
			catch
			{
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000AE60 File Offset: 0x00009060
		public string CreateDM(string string_0, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				string text = "{\"recipients\":[\"" + string_0 + "\"]}";
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Length", text.Length.ToString());
				httpRequest.AddHeader("Content-Type", "application/json");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Context-Properties", "e30=");
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				string json = Utils.DecompressResponse(httpRequest.Post("https://discord.com/api/v9/users/@me/channels", text, "application/json"));
				object arg = JObject.Parse(json);
				if (DiscordClient.<>o__23.<>p__1 == null)
				{
					DiscordClient.<>o__23.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
				}
				Func<CallSite, object, string> target = DiscordClient.<>o__23.<>p__1.Target;
				CallSite <>p__ = DiscordClient.<>o__23.<>p__1;
				if (DiscordClient.<>o__23.<>p__0 == null)
				{
					DiscordClient.<>o__23.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				return target(<>p__, DiscordClient.<>o__23.<>p__0.Target(DiscordClient.<>o__23.<>p__0, arg));
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000B09C File Offset: 0x0000929C
		public bool IsPhoneVerified()
		{
			bool result;
			try
			{
				if (!(this.phoneNumber != ""))
				{
					try
					{
						HttpRequest httpRequest = Utils.CreateCleanRequest();
						httpRequest.AddHeader("Accept", "*/*");
						httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
						httpRequest.AddHeader("Accept-Language", this.GetLanguage());
						httpRequest.AddHeader("Alt-Used", "discord.com");
						httpRequest.AddHeader("Authorization", this.token);
						httpRequest.AddHeader("Connection", "keep-alive");
						httpRequest.AddHeader("Cookie", this.GetCookie(""));
						httpRequest.AddHeader("DNT", "1");
						httpRequest.AddHeader("Host", "discord.com");
						httpRequest.AddHeader("Origin", "https://discord.com");
						httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
						httpRequest.AddHeader("TE", "Trailers");
						httpRequest.AddHeader("User-Agent", this.userAgent);
						httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
						Utils.DecompressResponse(httpRequest.Get("https://discord.com/api/v9/users/@me", null));
						object arg = JObject.Parse(Utils.DecompressResponse(httpRequest.Get("https://discord.com/api/v9/users/@me", null)));
						if (DiscordClient.<>o__24.<>p__1 == null)
						{
							DiscordClient.<>o__24.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
						}
						Func<CallSite, object, string> target = DiscordClient.<>o__24.<>p__1.Target;
						CallSite <>p__ = DiscordClient.<>o__24.<>p__1;
						if (DiscordClient.<>o__24.<>p__0 == null)
						{
							DiscordClient.<>o__24.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "phone", typeof(DiscordClient), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						string text = target(<>p__, DiscordClient.<>o__24.<>p__0.Target(DiscordClient.<>o__24.<>p__0, arg));
						try
						{
							if (text == null || text == "null")
							{
								this.phoneNumber = "n";
								this.phoneVerified = false;
							}
						}
						catch
						{
							if (DiscordClient.<>o__24.<>p__3 == null)
							{
								DiscordClient.<>o__24.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
							}
							Func<CallSite, object, string> target2 = DiscordClient.<>o__24.<>p__3.Target;
							CallSite <>p__2 = DiscordClient.<>o__24.<>p__3;
							if (DiscordClient.<>o__24.<>p__2 == null)
							{
								DiscordClient.<>o__24.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "phone", typeof(DiscordClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							this.phoneNumber = target2(<>p__2, DiscordClient.<>o__24.<>p__2.Target(DiscordClient.<>o__24.<>p__2, arg));
							this.phoneVerified = true;
						}
						return this.phoneVerified;
					}
					catch
					{
						return false;
					}
				}
				result = this.phoneVerified;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public void ParseGuild(DiscordInvite discordInvite_0, HttpProxyClient httpProxyClient_0, string string_0)
		{
			try
			{
				if (Utils.lastChannelId == string_0)
				{
					this.payloads = 0;
					Utils.users.Clear();
					try
					{
						int num = 0;
						int num2 = 99;
						if (Utils.lastChannelId == string_0)
						{
							try
							{
								this.ws.Send(string.Concat(new string[]
								{
									"{\"op\":14,\"d\":{\"guild_id\":\"",
									discordInvite_0.guildId.ToString(),
									"\",\"typing\":true,\"activities\":true,\"threads\":true,\"channels\":{\"",
									string_0.ToString(),
									"\":[[",
									num.ToString(),
									",",
									num2.ToString(),
									"]]}}}"
								}));
							}
							catch
							{
							}
							ulong num3 = discordInvite_0.membersCount;
							for (;;)
							{
								if (num3 > 100UL)
								{
									goto IL_17E;
								}
								bool flag = false;
								IL_B4:
								if (!flag)
								{
									break;
								}
								try
								{
									if (this.payloads >= 2)
									{
										this.payloads = 0;
										num += 100;
										num2 += 100;
										num3 -= 100UL;
										if (Utils.lastChannelId != string_0)
										{
											break;
										}
										try
										{
											this.ws.Send(string.Concat(new string[]
											{
												"{\"op\":14,\"d\":{\"guild_id\":\"",
												discordInvite_0.guildId.ToString(),
												"\",\"typing\":true,\"activities\":true,\"threads\":true,\"channels\":{\"",
												string_0.ToString(),
												"\":[[",
												num.ToString(),
												",",
												num2.ToString(),
												"]]}}}"
											}));
										}
										catch
										{
										}
										if (Utils.lastChannelId != string_0)
										{
											break;
										}
									}
									continue;
								}
								catch
								{
									continue;
								}
								IL_17E:
								flag = (Utils.lastChannelId == string_0);
								goto IL_B4;
							}
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
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B5D8 File Offset: 0x000097D8
		public void ThreadSpammer(string string_0, string string_1, string string_2)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Type", "application/json");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/" + string_0);
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				httpRequest.Post(string.Concat(new string[]
				{
					"https://discord.com/api/v9/channels/",
					string_0,
					"/messages/",
					string_1,
					"/threads"
				}));
			}
			catch
			{
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000B750 File Offset: 0x00009950
		public void ReadChannel(string string_0, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me/" + string_0);
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				httpRequest.Get("https://discord.com/api/v9/channels/" + string_0 + "/messages?limit=50", null);
			}
			catch
			{
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000B880 File Offset: 0x00009A80
		public void SendMessage(string string_0, string string_1, string string_2, HttpProxyClient httpProxyClient_0, bool bool_0 = false)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				string text;
				if (string_2 == "")
				{
					text = string.Concat(new string[]
					{
						"{\"content\":\"",
						string_1,
						"\",\"nonce\":\"",
						Utils.GetUniqueLong(18).ToString(),
						"\",\"tts\":false}"
					});
				}
				else
				{
					text = string.Concat(new string[]
					{
						"{\"content\":\"",
						string_1,
						"\",\"nonce\":\"",
						Utils.GetUniqueLong(18).ToString(),
						"\",\"tts\":false,\"message_reference\":{\"channel_id\":\"",
						string_0,
						"\",\"message_id\":\"",
						string_2,
						"\"}}"
					});
				}
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Length", text.Length.ToString());
				httpRequest.AddHeader("Content-Type", "application/json");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me/" + string_0);
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				object arg = JObject.Parse(Utils.DecompressResponse(httpRequest.Post("https://discord.com/api/v9/channels/" + string_0 + "/messages", text, "application/json")));
				if (DiscordClient.<>o__28.<>p__1 == null)
				{
					DiscordClient.<>o__28.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
				}
				Func<CallSite, object, string> target = DiscordClient.<>o__28.<>p__1.Target;
				CallSite <>p__ = DiscordClient.<>o__28.<>p__1;
				if (DiscordClient.<>o__28.<>p__0 == null)
				{
					DiscordClient.<>o__28.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				string string_3 = target(<>p__, DiscordClient.<>o__28.<>p__0.Target(DiscordClient.<>o__28.<>p__0, arg));
				if (bool_0)
				{
					this.DeleteMessage(string_0, string_3, httpProxyClient_0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000BB4C File Offset: 0x00009D4C
		public void DeleteMessage(string string_0, string string_1, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me/" + string_0);
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				httpRequest.Delete("https://discord.com/api/v9/channels/" + string_0 + "/messages/" + string_1);
			}
			catch
			{
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		public string GetLanguage()
		{
			string result;
			try
			{
				if (this.language != "")
				{
					result = this.language;
				}
				else
				{
					HttpRequest httpRequest = new HttpRequest();
					httpRequest.AddHeader("Accept", "*/*");
					httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
					httpRequest.AddHeader("Accept-Language", "it");
					httpRequest.AddHeader("Alt-Used", "discord.com");
					httpRequest.AddHeader("Authorization", this.token);
					httpRequest.AddHeader("Connection", "keep-alive");
					httpRequest.AddHeader("Cookie", this.GetCookie("it"));
					httpRequest.AddHeader("DNT", "1");
					httpRequest.AddHeader("Host", "discord.com");
					httpRequest.AddHeader("Origin", "https://discord.com");
					httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
					httpRequest.AddHeader("TE", "Trailers");
					httpRequest.AddHeader("User-Agent", this.userAgent);
					httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
					string json = Utils.DecompressResponse(httpRequest.Get("https://discord.com/api/v9/users/@me", null));
					object arg = JObject.Parse(json);
					if (DiscordClient.<>o__30.<>p__1 == null)
					{
						DiscordClient.<>o__30.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
					}
					Func<CallSite, object, string> target = DiscordClient.<>o__30.<>p__1.Target;
					CallSite <>p__ = DiscordClient.<>o__30.<>p__1;
					if (DiscordClient.<>o__30.<>p__0 == null)
					{
						DiscordClient.<>o__30.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "locale", typeof(DiscordClient), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					this.language = target(<>p__, DiscordClient.<>o__30.<>p__0.Target(DiscordClient.<>o__30.<>p__0, arg));
					if (DiscordClient.<>o__30.<>p__3 == null)
					{
						DiscordClient.<>o__30.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
					}
					Func<CallSite, object, string> target2 = DiscordClient.<>o__30.<>p__3.Target;
					CallSite <>p__2 = DiscordClient.<>o__30.<>p__3;
					if (DiscordClient.<>o__30.<>p__2 == null)
					{
						DiscordClient.<>o__30.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					this.userId = target2(<>p__2, DiscordClient.<>o__30.<>p__2.Target(DiscordClient.<>o__30.<>p__2, arg));
					try
					{
						if (DiscordClient.<>o__30.<>p__5 == null)
						{
							DiscordClient.<>o__30.<>p__5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
						}
						Func<CallSite, object, string> target3 = DiscordClient.<>o__30.<>p__5.Target;
						CallSite <>p__3 = DiscordClient.<>o__30.<>p__5;
						if (DiscordClient.<>o__30.<>p__4 == null)
						{
							DiscordClient.<>o__30.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "phone", typeof(DiscordClient), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						bool flag;
						if (target3(<>p__3, DiscordClient.<>o__30.<>p__4.Target(DiscordClient.<>o__30.<>p__4, arg)) != null)
						{
							if (DiscordClient.<>o__30.<>p__7 == null)
							{
								DiscordClient.<>o__30.<>p__7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
							}
							Func<CallSite, object, string> target4 = DiscordClient.<>o__30.<>p__7.Target;
							CallSite <>p__4 = DiscordClient.<>o__30.<>p__7;
							if (DiscordClient.<>o__30.<>p__6 == null)
							{
								DiscordClient.<>o__30.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "phone", typeof(DiscordClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							flag = (target4(<>p__4, DiscordClient.<>o__30.<>p__6.Target(DiscordClient.<>o__30.<>p__6, arg)) != "null");
						}
						else
						{
							flag = false;
						}
						if (flag)
						{
							this.phoneVerified = true;
							if (DiscordClient.<>o__30.<>p__9 == null)
							{
								DiscordClient.<>o__30.<>p__9 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
							}
							Func<CallSite, object, string> target5 = DiscordClient.<>o__30.<>p__9.Target;
							CallSite <>p__5 = DiscordClient.<>o__30.<>p__9;
							if (DiscordClient.<>o__30.<>p__8 == null)
							{
								DiscordClient.<>o__30.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "phone", typeof(DiscordClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							this.phoneNumber = target5(<>p__5, DiscordClient.<>o__30.<>p__8.Target(DiscordClient.<>o__30.<>p__8, arg));
						}
						else
						{
							this.phoneVerified = false;
							this.phoneNumber = "n";
						}
					}
					catch
					{
						this.phoneVerified = false;
						this.phoneNumber = "n";
					}
					result = this.language;
				}
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000C13C File Offset: 0x0000A33C
		public string GetCookie(string string_0 = "")
		{
			string result;
			try
			{
				if (this.cookie != "")
				{
					result = string.Concat(new string[]
					{
						this.cookie,
						"; OptanonConsent=",
						Utils.GetTest(),
						"; __cfruid=",
						"umxpjfzqreslzaa5uodtm9ei0w5ted1bqeqf4tdv",
						"-1625931828"
					});
				}
				else
				{
					if (string_0 == "")
					{
						this.cookie = Utils.GetRandomCookie(this.GetLanguage());
					}
					else
					{
						this.cookie = Utils.GetRandomCookie(string_0);
					}
					result = this.cookie + "; OptanonConsent=" + Utils.GetTest();
				}
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000C1FC File Offset: 0x0000A3FC
		public string GetSuperProperties()
		{
			string result;
			try
			{
				if (this.superProperties != "")
				{
					result = this.superProperties;
				}
				else
				{
					this.client_build_number = Utils.GetUniqueInt(5).ToString();
					this.superProperties = Utils.Base64Encode(string.Concat(new string[]
					{
						"{\"os\":\"Windows\",\"browser\":\"Firefox\",\"device\":\"\",\"system_locale\":\"it-IT\",\"browser_user_agent\":\"",
						this.userAgent,
						"\",\"browser_version\":\"89.0\",\"os_version\":\"10\",\"referrer\":\"\",\"referring_domain\":\"\",\"referrer_current\":\"\",\"referring_domain_current\":\"\",\"release_channel\":\"stable\",\"client_build_number\":",
						this.client_build_number,
						",\"client_event_source\":null}"
					}));
					result = this.superProperties;
				}
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000C29C File Offset: 0x0000A49C
		public void ConnectToWebSocket()
		{
			try
			{
				if (!this.connected)
				{
					this.ws = new WebSocket("wss://gateway.discord.gg/?encoding=json&v=9", Array.Empty<string>());
					this.ws.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;
					this.ws.Origin = "https://discord.com";
					this.ws.EnableRedirection = false;
					this.ws.EmitOnPing = false;
					this.ws.CustomHeaders = new Dictionary<string, string>
					{
						{
							"Accept",
							"*/*"
						},
						{
							"Accept-Encoding",
							"gzip, deflate, br"
						},
						{
							"Accept-Language",
							"it-IT,it;q=0.8,en-US;q=0.5,en;q=0.3"
						},
						{
							"Cache-Control",
							"no-cache"
						},
						{
							"Connection",
							"keep-alive, Upgrade"
						},
						{
							"DNT",
							"1"
						},
						{
							"Host",
							"gateway.discord.gg"
						},
						{
							"Origin",
							"https://discord.com"
						},
						{
							"Pragma",
							"no-cache"
						},
						{
							"Sec-WebSocket-Extensions",
							"permessage-deflate"
						},
						{
							"Sec-WebSocket-Version",
							"13"
						},
						{
							"Upgrade",
							"WebSocket"
						},
						{
							"User-Agent",
							this.userAgent
						}
					};
					this.GetSuperProperties();
					new Thread(new ThreadStart(this.fetchQueue)).Start();
					this.ws.OnMessage += this.Ws_OnMessage;
					this.ws.Connect();
					this.ws.Send(string.Concat(new string[]
					{
						"{\"op\":2,\"d\":{\"token\":\"",
						this.token,
						"\",\"capabilities\":125,\"properties\":{\"os\":\"Windows\",\"browser\":\"Firefox\",\"device\":\"\",\"system_locale\":\"it-IT\",\"browser_user_agent\":\"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0\",\"browser_version\":\"89.0\",\"os_version\":\"10\",\"referrer\":\"\",\"referring_domain\":\"\",\"referrer_current\":\"\",\"referring_domain_current\":\"\",\"release_channel\":\"stable\",\"client_build_number\":",
						this.client_build_number.ToString(),
						",\"client_event_source\":null},\"presence\":{\"status\":\"online\",\"since\":0,\"activities\":[],\"afk\":false},\"compress\":false,\"client_state\":{\"guild_hashes\":{},\"highest_last_message_id\":\"0\",\"read_state_version\":0,\"user_guild_settings_version\":-1}}}"
					}));
					this.connected = true;
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000C498 File Offset: 0x0000A698
		public void JoinGuild1(DiscordInvite discordInvite_0, string string_0, string string_1, string string_2, bool bool_0, bool bool_1, bool bool_2, bool bool_3, HttpProxyClient httpProxyClient_0, string string_3)
		{
			try
			{
				if (!bool_3)
				{
					if (!this.FirstlyFetchInvite(discordInvite_0, httpProxyClient_0))
					{
						return;
					}
					HttpRequest httpRequest = Utils.CreateCleanRequest();
					httpRequest.Proxy = httpProxyClient_0;
					httpRequest.AddHeader("Accept", "*/*");
					httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
					httpRequest.AddHeader("Accept-Language", this.GetLanguage());
					httpRequest.AddHeader("Alt-Used", "discord.com");
					httpRequest.AddHeader("Authorization", this.token);
					httpRequest.AddHeader("Connection", "keep-alive");
					httpRequest.AddHeader("Content-Length", "0");
					httpRequest.AddHeader("Cookie", this.GetCookie(""));
					httpRequest.AddHeader("DNT", "1");
					httpRequest.AddHeader("Host", "discord.com");
					httpRequest.AddHeader("Origin", "https://discord.com");
					httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
					httpRequest.AddHeader("TE", "Trailers");
					httpRequest.AddHeader("User-Agent", this.userAgent);
					httpRequest.AddHeader("X-Context-Properties", string_0);
					httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
					try
					{
						httpRequest.Post("https://discord.com/api/v9/invites/" + discordInvite_0.inviteCode);
					}
					catch
					{
					}
					try
					{
						if (httpRequest.Response.IsOK && httpRequest.Response.StatusCode == HttpStatusCode.OK)
						{
							try
							{
								if (bool_0)
								{
									string json = Utils.DecompressResponse(httpRequest.Response);
									object arg = JObject.Parse(json);
									if (DiscordClient.<>o__34.<>p__1 == null)
									{
										DiscordClient.<>o__34.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(bool), typeof(DiscordClient)));
									}
									Func<CallSite, object, bool> target = DiscordClient.<>o__34.<>p__1.Target;
									CallSite <>p__ = DiscordClient.<>o__34.<>p__1;
									if (DiscordClient.<>o__34.<>p__0 == null)
									{
										DiscordClient.<>o__34.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "show_verification_form", typeof(DiscordClient), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									if (target(<>p__, DiscordClient.<>o__34.<>p__0.Target(DiscordClient.<>o__34.<>p__0, arg)))
									{
										Thread.Sleep(350);
										string rules = this.GetRules(discordInvite_0, httpProxyClient_0);
										this.BypassRules(discordInvite_0, rules, httpProxyClient_0);
									}
								}
							}
							catch
							{
							}
							try
							{
								Thread.Sleep(1000);
								if (bool_1)
								{
									this.BypassReactionVerification(discordInvite_0, true, httpProxyClient_0);
								}
								else
								{
									this.BypassReactionVerification(discordInvite_0, false, httpProxyClient_0);
								}
								Thread.Sleep(1250);
							}
							catch
							{
							}
							try
							{
							}
							catch
							{
							}
						}
						goto IL_3FC;
					}
					catch
					{
						goto IL_3FC;
					}
				}
				if (this.FirstlyFetchGroupInvite(discordInvite_0, httpProxyClient_0))
				{
					HttpRequest httpRequest2 = Utils.CreateCleanRequest();
					httpRequest2.Proxy = httpProxyClient_0;
					httpRequest2.AddHeader("Accept", "*/*");
					httpRequest2.AddHeader("Accept-Encoding", "gzip, deflate, br");
					httpRequest2.AddHeader("Accept-Language", this.GetLanguage());
					httpRequest2.AddHeader("Alt-Used", "discord.com");
					httpRequest2.AddHeader("Authorization", this.token);
					httpRequest2.AddHeader("Connection", "keep-alive");
					httpRequest2.AddHeader("Content-Length", "0");
					httpRequest2.AddHeader("Cookie", this.GetCookie(""));
					httpRequest2.AddHeader("DNT", "1");
					httpRequest2.AddHeader("Host", "discord.com");
					httpRequest2.AddHeader("Origin", "https://discord.com");
					httpRequest2.AddHeader("Referer", "https://discord.com/channels/@me");
					httpRequest2.AddHeader("TE", "Trailers");
					httpRequest2.AddHeader("User-Agent", this.userAgent);
					httpRequest2.AddHeader("X-Context-Properties", string_0);
					httpRequest2.AddHeader("X-Super-Properties", this.GetSuperProperties());
					try
					{
						httpRequest2.Post("https://discord.com/api/v9/invites/" + discordInvite_0.inviteCode);
					}
					catch
					{
					}
				}
				IL_3FC:;
			}
			catch
			{
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000C954 File Offset: 0x0000AB54
		public string GetRules(DiscordInvite discordInvite_0, HttpProxyClient httpProxyClient_0)
		{
			string result;
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/" + discordInvite_0.guildId.ToString() + "/" + discordInvite_0.channelId.ToString());
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				string text = Utils.DecompressResponse(httpRequest.Get("https://discord.com/api/v9/guilds/" + discordInvite_0.guildId.ToString() + "/member-verification?with_guild=false&invite_code=" + discordInvite_0.inviteCode, null));
				string text2;
				if (text.Contains("\"form_fields\": []") || text.Contains("\"form_fields\":[]"))
				{
					string expression = Strings.Split(text, "{\"version\": \"", -1, CompareMethod.Binary)[1];
					string str = Strings.Split(expression, "\"", -1, CompareMethod.Binary)[0];
					text2 = "{\"version\": \"" + str + "\",\"form_fields\": []}";
				}
				else
				{
					string str2 = Strings.Split(text, "}], \"description\":", -1, CompareMethod.Binary)[0];
					text2 = str2 + ",\"response\":true}]}";
				}
				result = text2;
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000CB48 File Offset: 0x0000AD48
		public void SendMessage1(string string_0, string string_1, string string_2, HttpProxyClient httpProxyClient_0, bool bool_0 = false)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				string text;
				if (string_2 == "")
				{
					text = string.Concat(new string[]
					{
						"{\"content\":\"",
						string_1,
						"\",\"nonce\":\"",
						Utils.GetUniqueLong(18).ToString(),
						"\",\"tts\":false}"
					});
				}
				else
				{
					text = string.Concat(new string[]
					{
						"{\"content\":\"",
						string_1,
						"\",\"nonce\":\"",
						Utils.GetUniqueLong(18).ToString(),
						"\",\"tts\":false,\"message_reference\":{\"channel_id\":\"",
						string_0,
						"\",\"message_id\":\"",
						string_2,
						"\"}}"
					});
				}
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Length", text.Length.ToString());
				httpRequest.AddHeader("Content-Type", "application/json");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me/" + string_0);
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				object arg = JObject.Parse(Utils.DecompressResponse(httpRequest.Post("https://discord.com/api/v9/channels/" + string_0 + "/messages", text, "application/json")));
				if (DiscordClient.<>o__36.<>p__1 == null)
				{
					DiscordClient.<>o__36.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
				}
				Func<CallSite, object, string> target = DiscordClient.<>o__36.<>p__1.Target;
				CallSite <>p__ = DiscordClient.<>o__36.<>p__1;
				if (DiscordClient.<>o__36.<>p__0 == null)
				{
					DiscordClient.<>o__36.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				string string_3 = target(<>p__, DiscordClient.<>o__36.<>p__0.Target(DiscordClient.<>o__36.<>p__0, arg));
				if (bool_0)
				{
					this.DeleteMessage(string_0, string_3, httpProxyClient_0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000CE18 File Offset: 0x0000B018
		public void AnswerToCaptcha(string string_0, string string_1, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				string text = string.Concat(new string[]
				{
					"{\"content\":\"",
					string_1,
					"\",\"nonce\":\"",
					Utils.GetUniqueLong(18).ToString(),
					"\",\"tts\":false}"
				});
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Length", text.Length.ToString());
				httpRequest.AddHeader("Content-Type", "application/json");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me/" + string_0);
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				httpRequest.Post("https://discord.com/api/v9/channels/" + string_0 + "/messages", text, "application/json");
			}
			catch
			{
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		public string method_0(string string_0, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me/" + string_0);
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				string value = Utils.DecompressResponse(httpRequest.Get("https://discord.com/api/v9/channels/" + string_0 + "/messages?limit=50", null));
				object arg = JsonConvert.DeserializeObject(value);
				if (DiscordClient.<>o__38.<>p__5 == null)
				{
					DiscordClient.<>o__38.<>p__5 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(DiscordClient)));
				}
				foreach (object arg2 in DiscordClient.<>o__38.<>p__5.Target(DiscordClient.<>o__38.<>p__5, arg))
				{
					try
					{
						if (DiscordClient.<>o__38.<>p__4 == null)
						{
							DiscordClient.<>o__38.<>p__4 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(DiscordClient)));
						}
						Func<CallSite, object, IEnumerable> target = DiscordClient.<>o__38.<>p__4.Target;
						CallSite <>p__ = DiscordClient.<>o__38.<>p__4;
						if (DiscordClient.<>o__38.<>p__0 == null)
						{
							DiscordClient.<>o__38.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "embeds", typeof(DiscordClient), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						foreach (object arg3 in target(<>p__, DiscordClient.<>o__38.<>p__0.Target(DiscordClient.<>o__38.<>p__0, arg2)))
						{
							try
							{
								if (DiscordClient.<>o__38.<>p__3 == null)
								{
									DiscordClient.<>o__38.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
								}
								Func<CallSite, object, string> target2 = DiscordClient.<>o__38.<>p__3.Target;
								CallSite <>p__2 = DiscordClient.<>o__38.<>p__3;
								if (DiscordClient.<>o__38.<>p__2 == null)
								{
									DiscordClient.<>o__38.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "url", typeof(DiscordClient), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> target3 = DiscordClient.<>o__38.<>p__2.Target;
								CallSite <>p__3 = DiscordClient.<>o__38.<>p__2;
								if (DiscordClient.<>o__38.<>p__1 == null)
								{
									DiscordClient.<>o__38.<>p__1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "image", typeof(DiscordClient), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								return target2(<>p__2, target3(<>p__3, DiscordClient.<>o__38.<>p__1.Target(DiscordClient.<>o__38.<>p__1, arg3)));
							}
							catch
							{
							}
						}
						break;
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000D394 File Offset: 0x0000B594
		public bool FirstlyFetchInvite(DiscordInvite discordInvite_0, HttpProxyClient httpProxyClient_0)
		{
			bool result;
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				try
				{
					result = httpRequest.Get(string.Concat(new string[]
					{
						"https://discord.com/api/v9/invites/",
						discordInvite_0.inviteCode,
						"?inputValue=",
						discordInvite_0.inviteCode,
						"&with_counts=true&with_expiration=true"
					}), null).IsOK;
				}
				catch
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000D52C File Offset: 0x0000B72C
		public void BypassRules(DiscordInvite discordInvite_0, string string_0, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Length", string_0.Length.ToString());
				httpRequest.AddHeader("Content-Type", "application/json");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/" + discordInvite_0.guildId.ToString() + "/" + discordInvite_0.channelId.ToString());
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				httpRequest.Put("https://discord.com/api/v9/guilds/" + discordInvite_0.guildId.ToString() + "/requests/@me", string_0, "application/json");
			}
			catch
			{
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000D6D4 File Offset: 0x0000B8D4
		public bool FirstlyFetchGroupInvite(DiscordInvite discordInvite_0, HttpProxyClient httpProxyClient_0)
		{
			bool result;
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				try
				{
					result = httpRequest.Get("https://discord.com/api/v9/invites/" + discordInvite_0.inviteCode + "?with_counts=true&with_expiration=true", null).IsOK;
				}
				catch
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000D83C File Offset: 0x0000BA3C
		public void BypassReactionVerification(DiscordInvite discordInvite_0, bool bool_0, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				string value = Utils.DecompressResponse(httpRequest.Get("https://discord.com/api/v9/channels/" + discordInvite_0.channelId.ToString() + "/messages?limit=50", null));
				if (bool_0)
				{
					object arg = JsonConvert.DeserializeObject(value);
					if (DiscordClient.<>o__42.<>p__10 == null)
					{
						DiscordClient.<>o__42.<>p__10 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(DiscordClient)));
					}
					foreach (object arg2 in DiscordClient.<>o__42.<>p__10.Target(DiscordClient.<>o__42.<>p__10, arg))
					{
						try
						{
							if (DiscordClient.<>o__42.<>p__9 == null)
							{
								DiscordClient.<>o__42.<>p__9 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(DiscordClient)));
							}
							Func<CallSite, object, IEnumerable> target = DiscordClient.<>o__42.<>p__9.Target;
							CallSite <>p__ = DiscordClient.<>o__42.<>p__9;
							if (DiscordClient.<>o__42.<>p__0 == null)
							{
								DiscordClient.<>o__42.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "reactions", typeof(DiscordClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							foreach (object arg3 in target(<>p__, DiscordClient.<>o__42.<>p__0.Target(DiscordClient.<>o__42.<>p__0, arg2)))
							{
								try
								{
									if (DiscordClient.<>o__42.<>p__3 == null)
									{
										DiscordClient.<>o__42.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(DiscordClient)));
									}
									Func<CallSite, object, string> target2 = DiscordClient.<>o__42.<>p__3.Target;
									CallSite <>p__2 = DiscordClient.<>o__42.<>p__3;
									if (DiscordClient.<>o__42.<>p__2 == null)
									{
										DiscordClient.<>o__42.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target3 = DiscordClient.<>o__42.<>p__2.Target;
									CallSite <>p__3 = DiscordClient.<>o__42.<>p__2;
									if (DiscordClient.<>o__42.<>p__1 == null)
									{
										DiscordClient.<>o__42.<>p__1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "emoji", typeof(DiscordClient), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									string text = target2(<>p__2, target3(<>p__3, DiscordClient.<>o__42.<>p__1.Target(DiscordClient.<>o__42.<>p__1, arg3)));
									if (DiscordClient.<>o__42.<>p__6 == null)
									{
										DiscordClient.<>o__42.<>p__6 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(DiscordClient)));
									}
									Func<CallSite, object, string> target4 = DiscordClient.<>o__42.<>p__6.Target;
									CallSite <>p__4 = DiscordClient.<>o__42.<>p__6;
									if (DiscordClient.<>o__42.<>p__5 == null)
									{
										DiscordClient.<>o__42.<>p__5 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "name", typeof(DiscordClient), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target5 = DiscordClient.<>o__42.<>p__5.Target;
									CallSite <>p__5 = DiscordClient.<>o__42.<>p__5;
									if (DiscordClient.<>o__42.<>p__4 == null)
									{
										DiscordClient.<>o__42.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "emoji", typeof(DiscordClient), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									string text2 = target4(<>p__4, target5(<>p__5, DiscordClient.<>o__42.<>p__4.Target(DiscordClient.<>o__42.<>p__4, arg3)));
									if (text != null && text != "")
									{
										text2 = text2 + ":" + text;
									}
									Thread.Sleep(1500);
									string string_ = text2;
									string string_2 = discordInvite_0.channelId.ToString();
									if (DiscordClient.<>o__42.<>p__8 == null)
									{
										DiscordClient.<>o__42.<>p__8 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
									}
									Func<CallSite, object, string> target6 = DiscordClient.<>o__42.<>p__8.Target;
									CallSite <>p__6 = DiscordClient.<>o__42.<>p__8;
									if (DiscordClient.<>o__42.<>p__7 == null)
									{
										DiscordClient.<>o__42.<>p__7 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									this.AddReaction(string_, string_2, target6(<>p__6, DiscordClient.<>o__42.<>p__7.Target(DiscordClient.<>o__42.<>p__7, arg2)), httpProxyClient_0);
								}
								catch
								{
								}
							}
						}
						catch
						{
						}
					}
					try
					{
						string b = discordInvite_0.channelId.ToString();
						foreach (string text3 in this.GetGuildChannels(discordInvite_0.guildId.ToString(), httpProxyClient_0))
						{
							if (!(text3 == b))
							{
								try
								{
									HttpRequest httpRequest2 = Utils.CreateCleanRequest();
									httpRequest2.Proxy = httpProxyClient_0;
									httpRequest2.AddHeader("Accept", "*/*");
									httpRequest2.AddHeader("Accept-Encoding", "gzip, deflate, br");
									httpRequest2.AddHeader("Accept-Language", this.GetLanguage());
									httpRequest2.AddHeader("Alt-Used", "discord.com");
									httpRequest2.AddHeader("Authorization", this.token);
									httpRequest2.AddHeader("Connection", "keep-alive");
									httpRequest2.AddHeader("Cookie", this.GetCookie(""));
									httpRequest2.AddHeader("Host", "discord.com");
									httpRequest2.AddHeader("Referer", "https://discord.com/channels/@me");
									httpRequest2.AddHeader("TE", "Trailers");
									httpRequest2.AddHeader("User-Agent", this.userAgent);
									httpRequest2.AddHeader("X-Super-Properties", this.GetSuperProperties());
									string value2 = Utils.DecompressResponse(httpRequest2.Get("https://discord.com/api/v9/channels/" + text3 + "/messages?limit=50", null));
									object arg4 = JsonConvert.DeserializeObject(value2);
									if (DiscordClient.<>o__42.<>p__21 == null)
									{
										DiscordClient.<>o__42.<>p__21 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(DiscordClient)));
									}
									foreach (object arg5 in DiscordClient.<>o__42.<>p__21.Target(DiscordClient.<>o__42.<>p__21, arg4))
									{
										try
										{
											if (DiscordClient.<>o__42.<>p__20 == null)
											{
												DiscordClient.<>o__42.<>p__20 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(DiscordClient)));
											}
											Func<CallSite, object, IEnumerable> target7 = DiscordClient.<>o__42.<>p__20.Target;
											CallSite <>p__7 = DiscordClient.<>o__42.<>p__20;
											if (DiscordClient.<>o__42.<>p__11 == null)
											{
												DiscordClient.<>o__42.<>p__11 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "reactions", typeof(DiscordClient), new CSharpArgumentInfo[]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											foreach (object arg6 in target7(<>p__7, DiscordClient.<>o__42.<>p__11.Target(DiscordClient.<>o__42.<>p__11, arg5)))
											{
												try
												{
													if (DiscordClient.<>o__42.<>p__14 == null)
													{
														DiscordClient.<>o__42.<>p__14 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(DiscordClient)));
													}
													Func<CallSite, object, string> target8 = DiscordClient.<>o__42.<>p__14.Target;
													CallSite <>p__8 = DiscordClient.<>o__42.<>p__14;
													if (DiscordClient.<>o__42.<>p__13 == null)
													{
														DiscordClient.<>o__42.<>p__13 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
														{
															CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
														}));
													}
													Func<CallSite, object, object> target9 = DiscordClient.<>o__42.<>p__13.Target;
													CallSite <>p__9 = DiscordClient.<>o__42.<>p__13;
													if (DiscordClient.<>o__42.<>p__12 == null)
													{
														DiscordClient.<>o__42.<>p__12 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "emoji", typeof(DiscordClient), new CSharpArgumentInfo[]
														{
															CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
														}));
													}
													string text4 = target8(<>p__8, target9(<>p__9, DiscordClient.<>o__42.<>p__12.Target(DiscordClient.<>o__42.<>p__12, arg6)));
													if (DiscordClient.<>o__42.<>p__17 == null)
													{
														DiscordClient.<>o__42.<>p__17 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(DiscordClient)));
													}
													Func<CallSite, object, string> target10 = DiscordClient.<>o__42.<>p__17.Target;
													CallSite <>p__10 = DiscordClient.<>o__42.<>p__17;
													if (DiscordClient.<>o__42.<>p__16 == null)
													{
														DiscordClient.<>o__42.<>p__16 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "name", typeof(DiscordClient), new CSharpArgumentInfo[]
														{
															CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
														}));
													}
													Func<CallSite, object, object> target11 = DiscordClient.<>o__42.<>p__16.Target;
													CallSite <>p__11 = DiscordClient.<>o__42.<>p__16;
													if (DiscordClient.<>o__42.<>p__15 == null)
													{
														DiscordClient.<>o__42.<>p__15 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "emoji", typeof(DiscordClient), new CSharpArgumentInfo[]
														{
															CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
														}));
													}
													string text5 = target10(<>p__10, target11(<>p__11, DiscordClient.<>o__42.<>p__15.Target(DiscordClient.<>o__42.<>p__15, arg6)));
													if (text4 != null && text4 != "")
													{
														text5 = text5 + ":" + text4;
													}
													Thread.Sleep(1500);
													string string_3 = text5;
													string string_4 = text3;
													if (DiscordClient.<>o__42.<>p__19 == null)
													{
														DiscordClient.<>o__42.<>p__19 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
													}
													Func<CallSite, object, string> target12 = DiscordClient.<>o__42.<>p__19.Target;
													CallSite <>p__12 = DiscordClient.<>o__42.<>p__19;
													if (DiscordClient.<>o__42.<>p__18 == null)
													{
														DiscordClient.<>o__42.<>p__18 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
														{
															CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
														}));
													}
													this.AddReaction(string_3, string_4, target12(<>p__12, DiscordClient.<>o__42.<>p__18.Target(DiscordClient.<>o__42.<>p__18, arg5)), httpProxyClient_0);
												}
												catch
												{
												}
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
							}
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
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		public List<string> GetGuildChannels(string string_0, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				List<string> list = new List<string>();
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/@me");
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				string value = Utils.DecompressResponse(httpRequest.Get("https://discord.com/api/v9/guilds/" + string_0 + "/channels", null));
				object arg = JsonConvert.DeserializeObject(value);
				if (DiscordClient.<>o__43.<>p__4 == null)
				{
					DiscordClient.<>o__43.<>p__4 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(DiscordClient)));
				}
				foreach (object arg2 in DiscordClient.<>o__43.<>p__4.Target(DiscordClient.<>o__43.<>p__4, arg))
				{
					try
					{
						if (DiscordClient.<>o__43.<>p__1 == null)
						{
							DiscordClient.<>o__43.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
						}
						Func<CallSite, object, string> target = DiscordClient.<>o__43.<>p__1.Target;
						CallSite <>p__ = DiscordClient.<>o__43.<>p__1;
						if (DiscordClient.<>o__43.<>p__0 == null)
						{
							DiscordClient.<>o__43.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "type", typeof(DiscordClient), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (target(<>p__, DiscordClient.<>o__43.<>p__0.Target(DiscordClient.<>o__43.<>p__0, arg2)) == "0")
						{
							List<string> list2 = list;
							if (DiscordClient.<>o__43.<>p__3 == null)
							{
								DiscordClient.<>o__43.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
							}
							Func<CallSite, object, string> target2 = DiscordClient.<>o__43.<>p__3.Target;
							CallSite <>p__2 = DiscordClient.<>o__43.<>p__3;
							if (DiscordClient.<>o__43.<>p__2 == null)
							{
								DiscordClient.<>o__43.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							list2.Add(target2(<>p__2, DiscordClient.<>o__43.<>p__2.Target(DiscordClient.<>o__43.<>p__2, arg2)));
						}
					}
					catch
					{
					}
				}
				return list;
			}
			catch
			{
			}
			return new List<string>();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000E6F0 File Offset: 0x0000C8F0
		public void AddReaction(string string_0, string string_1, string string_2, HttpProxyClient httpProxyClient_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.Proxy = httpProxyClient_0;
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Length", "0");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/" + string_1 + "/" + string_2);
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				httpRequest.Put(string.Concat(new string[]
				{
					"https://discord.com/api/v9/channels/",
					string_1,
					"/messages/",
					string_2,
					"/reactions/",
					string_0,
					"/@me"
				}));
			}
			catch
			{
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000E880 File Offset: 0x0000CA80
		public void LeaveVoice()
		{
			try
			{
				if (this.connectedToVoice)
				{
					this.connectedToVoice = false;
					this.SendToWS("{\"op\":4,\"d\":{\"guild_id\":null,\"channel_id\":null,\"self_mute\":false,\"self_deaf\":false,\"self_video\":false}}");
				}
			}
			catch
			{
				this.connectedToVoice = true;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
		private void Ws_OnMessage(object sender, MessageEventArgs e)
		{
			try
			{
				string @string = Encoding.UTF8.GetString(e.RawData);
				this.queue.Add(@string);
				object arg = JObject.Parse(@string);
				if (DiscordClient.<>o__46.<>p__2 == null)
				{
					DiscordClient.<>o__46.<>p__2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(DiscordClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = DiscordClient.<>o__46.<>p__2.Target;
				CallSite <>p__ = DiscordClient.<>o__46.<>p__2;
				if (DiscordClient.<>o__46.<>p__1 == null)
				{
					DiscordClient.<>o__46.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(DiscordClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target2 = DiscordClient.<>o__46.<>p__1.Target;
				CallSite <>p__2 = DiscordClient.<>o__46.<>p__1;
				if (DiscordClient.<>o__46.<>p__0 == null)
				{
					DiscordClient.<>o__46.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "op", typeof(DiscordClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target(<>p__, target2(<>p__2, DiscordClient.<>o__46.<>p__0.Target(DiscordClient.<>o__46.<>p__0, arg), 10)))
				{
					DiscordClient.<>c__DisplayClass46_0 CS$<>8__locals1 = new DiscordClient.<>c__DisplayClass46_0();
					CS$<>8__locals1.<>4__this = this;
					DiscordClient.<>c__DisplayClass46_0 CS$<>8__locals2 = CS$<>8__locals1;
					if (DiscordClient.<>o__46.<>p__5 == null)
					{
						DiscordClient.<>o__46.<>p__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(DiscordClient)));
					}
					Func<CallSite, object, int> target3 = DiscordClient.<>o__46.<>p__5.Target;
					CallSite <>p__3 = DiscordClient.<>o__46.<>p__5;
					if (DiscordClient.<>o__46.<>p__4 == null)
					{
						DiscordClient.<>o__46.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "heartbeat_interval", typeof(DiscordClient), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target4 = DiscordClient.<>o__46.<>p__4.Target;
					CallSite <>p__4 = DiscordClient.<>o__46.<>p__4;
					if (DiscordClient.<>o__46.<>p__3 == null)
					{
						DiscordClient.<>o__46.<>p__3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "d", typeof(DiscordClient), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					CS$<>8__locals2.heartbeat_interval = target3(<>p__3, target4(<>p__4, DiscordClient.<>o__46.<>p__3.Target(DiscordClient.<>o__46.<>p__3, arg)));
					new Thread(delegate()
					{
						CS$<>8__locals1.<>4__this.doHeartbeat(CS$<>8__locals1.heartbeat_interval);
					}).Start();
				}
				if (DiscordClient.<>o__46.<>p__8 == null)
				{
					DiscordClient.<>o__46.<>p__8 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(DiscordClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target5 = DiscordClient.<>o__46.<>p__8.Target;
				CallSite <>p__5 = DiscordClient.<>o__46.<>p__8;
				if (DiscordClient.<>o__46.<>p__7 == null)
				{
					DiscordClient.<>o__46.<>p__7 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(DiscordClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target6 = DiscordClient.<>o__46.<>p__7.Target;
				CallSite <>p__6 = DiscordClient.<>o__46.<>p__7;
				if (DiscordClient.<>o__46.<>p__6 == null)
				{
					DiscordClient.<>o__46.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "t", typeof(DiscordClient), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target5(<>p__5, target6(<>p__6, DiscordClient.<>o__46.<>p__6.Target(DiscordClient.<>o__46.<>p__6, arg), "GUILD_MEMBER_LIST_UPDATE")))
				{
					this.idQueue.Add(@string);
					this.payloads++;
				}
				else
				{
					if (DiscordClient.<>o__46.<>p__10 == null)
					{
						DiscordClient.<>o__46.<>p__10 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
					}
					Func<CallSite, object, string> target7 = DiscordClient.<>o__46.<>p__10.Target;
					CallSite <>p__7 = DiscordClient.<>o__46.<>p__10;
					if (DiscordClient.<>o__46.<>p__9 == null)
					{
						DiscordClient.<>o__46.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "t", typeof(DiscordClient), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (target7(<>p__7, DiscordClient.<>o__46.<>p__9.Target(DiscordClient.<>o__46.<>p__9, arg)) == "VOICE_STATE_UPDATE")
					{
						try
						{
							if (DiscordClient.<>o__46.<>p__15 == null)
							{
								DiscordClient.<>o__46.<>p__15 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
							}
							Func<CallSite, object, string> target8 = DiscordClient.<>o__46.<>p__15.Target;
							CallSite <>p__8 = DiscordClient.<>o__46.<>p__15;
							if (DiscordClient.<>o__46.<>p__14 == null)
							{
								DiscordClient.<>o__46.<>p__14 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(DiscordClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target9 = DiscordClient.<>o__46.<>p__14.Target;
							CallSite <>p__9 = DiscordClient.<>o__46.<>p__14;
							if (DiscordClient.<>o__46.<>p__13 == null)
							{
								DiscordClient.<>o__46.<>p__13 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "user", typeof(DiscordClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target10 = DiscordClient.<>o__46.<>p__13.Target;
							CallSite <>p__10 = DiscordClient.<>o__46.<>p__13;
							if (DiscordClient.<>o__46.<>p__12 == null)
							{
								DiscordClient.<>o__46.<>p__12 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "member", typeof(DiscordClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target11 = DiscordClient.<>o__46.<>p__12.Target;
							CallSite <>p__11 = DiscordClient.<>o__46.<>p__12;
							if (DiscordClient.<>o__46.<>p__11 == null)
							{
								DiscordClient.<>o__46.<>p__11 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "d", typeof(DiscordClient), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							if (target8(<>p__8, target9(<>p__9, target10(<>p__10, target11(<>p__11, DiscordClient.<>o__46.<>p__11.Target(DiscordClient.<>o__46.<>p__11, arg))))) == this.GetUserId())
							{
								if (DiscordClient.<>o__46.<>p__18 == null)
								{
									DiscordClient.<>o__46.<>p__18 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
								}
								Func<CallSite, object, string> target12 = DiscordClient.<>o__46.<>p__18.Target;
								CallSite <>p__12 = DiscordClient.<>o__46.<>p__18;
								if (DiscordClient.<>o__46.<>p__17 == null)
								{
									DiscordClient.<>o__46.<>p__17 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "channel_id", typeof(DiscordClient), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> target13 = DiscordClient.<>o__46.<>p__17.Target;
								CallSite <>p__13 = DiscordClient.<>o__46.<>p__17;
								if (DiscordClient.<>o__46.<>p__16 == null)
								{
									DiscordClient.<>o__46.<>p__16 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "d", typeof(DiscordClient), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								bool flag;
								if (target12(<>p__12, target13(<>p__13, DiscordClient.<>o__46.<>p__16.Target(DiscordClient.<>o__46.<>p__16, arg))) != null)
								{
									if (DiscordClient.<>o__46.<>p__21 == null)
									{
										DiscordClient.<>o__46.<>p__21 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(DiscordClient)));
									}
									Func<CallSite, object, string> target14 = DiscordClient.<>o__46.<>p__21.Target;
									CallSite <>p__14 = DiscordClient.<>o__46.<>p__21;
									if (DiscordClient.<>o__46.<>p__20 == null)
									{
										DiscordClient.<>o__46.<>p__20 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "channel_id", typeof(DiscordClient), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target15 = DiscordClient.<>o__46.<>p__20.Target;
									CallSite <>p__15 = DiscordClient.<>o__46.<>p__20;
									if (DiscordClient.<>o__46.<>p__19 == null)
									{
										DiscordClient.<>o__46.<>p__19 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "d", typeof(DiscordClient), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									flag = (target14(<>p__14, target15(<>p__15, DiscordClient.<>o__46.<>p__19.Target(DiscordClient.<>o__46.<>p__19, arg))) == "null");
								}
								else
								{
									flag = true;
								}
								if (flag)
								{
									this.connectedToVoice = false;
									if (this.data != null && Utils.globalAutoReconnect)
									{
										this.JoinVoice(this.data.guildId, this.data.channelId, this.data.userIdGoLive, this.data.microphoneMuted, this.data.headphonesMuted, this.data.videoEnabled, this.data.goLive, this.data.joinGoLive, this.data.speakInStage);
									}
								}
								else
								{
									this.connectedToVoice = true;
								}
							}
						}
						catch
						{
							this.connectedToVoice = false;
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000F08C File Offset: 0x0000D28C
		public void doHeartbeat(int int_0)
		{
			try
			{
				for (;;)
				{
					try
					{
						Thread.Sleep(int_0);
						this.ws.Send("{\"op\":1,\"d\":null}");
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		public void fetchQueue()
		{
			for (;;)
			{
				Thread.Sleep(250);
				try
				{
					if (this.queue.Count > 0)
					{
						string text = this.queue[0];
						this.queue.RemoveAt(0);
					}
				}
				catch
				{
				}
				try
				{
					if (this.idQueue.Count > 0)
					{
						string text2 = this.idQueue[0];
						this.idQueue.RemoveAt(0);
						string[] array = Strings.Split(text2, "\"id\":\"", -1, CompareMethod.Binary);
						for (int i = 1; i < array.Length; i++)
						{
							try
							{
								string expression = array[i];
								string[] array2 = Strings.Split(expression, "\"", -1, CompareMethod.Binary);
								string text3 = array2[0];
								if (Information.IsNumeric(text3) && text3.Length == 18 && text2.Contains(text3 + "\",\"discriminator") && !Utils.users.Contains(text3))
								{
									Utils.users.Add(text3);
								}
							}
							catch
							{
							}
						}
						for (int j = 0; j < Utils.users.Count; j++)
						{
							try
							{
								for (int k = 0; k < Utils.users.Count; k++)
								{
									try
									{
										if (j != k && Utils.users[j] == Utils.users[k])
										{
											Utils.users.RemoveAt(j);
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
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000F2D8 File Offset: 0x0000D4D8
		public void SendToWS(string string_0)
		{
			try
			{
				if (!this.connected)
				{
					this.ConnectToWebSocket();
				}
				this.ws.Send(string_0);
			}
			catch
			{
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000F318 File Offset: 0x0000D518
		public void SendSpeakRequestToStageChannel(string string_0, string string_1)
		{
			try
			{
				string text = DateTime.Now.Year.ToString();
				string text2 = DateTime.Now.Month.ToString();
				if (text2.Length == 1)
				{
					text2 = "0" + text2;
				}
				string text3 = DateTime.Now.Day.ToString();
				if (text3.Length == 1)
				{
					text3 = "0" + text3;
				}
				string text4 = DateTime.Now.Hour.ToString();
				if (text4.Length == 1)
				{
					text4 = "0" + text4;
				}
				string text5 = DateTime.Now.Minute.ToString();
				if (text5.Length == 1)
				{
					text5 = "0" + text5;
				}
				string text6 = DateTime.Now.Minute.ToString();
				if (text6.Length == 1)
				{
					text6 = "0" + text6;
				}
				string text7 = string.Concat(new string[]
				{
					text,
					"-",
					text2,
					"-",
					text3,
					"T",
					text4,
					":",
					text5,
					":",
					text6,
					".",
					DateTime.Now.Millisecond.ToString(),
					"Z"
				});
				string text8 = string.Concat(new string[]
				{
					"{\"request_to_speak_timestamp\":\"",
					text7,
					"\",\"channel_id\":\"",
					string_1,
					"\"}"
				});
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.AddHeader("Accept", "*/*");
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Accept-Language", this.GetLanguage());
				httpRequest.AddHeader("Alt-Used", "discord.com");
				httpRequest.AddHeader("Authorization", this.token);
				httpRequest.AddHeader("Connection", "keep-alive");
				httpRequest.AddHeader("Content-Length", text8.Length.ToString());
				httpRequest.AddHeader("Content-Type", "application/json");
				httpRequest.AddHeader("Cookie", this.GetCookie(""));
				httpRequest.AddHeader("DNT", "1");
				httpRequest.AddHeader("Host", "discord.com");
				httpRequest.AddHeader("Origin", "https://discord.com");
				httpRequest.AddHeader("Referer", "https://discord.com/channels/" + string_0 + "/" + string_1);
				httpRequest.AddHeader("TE", "Trailers");
				httpRequest.AddHeader("User-Agent", this.userAgent);
				httpRequest.AddHeader("X-Super-Properties", this.GetSuperProperties());
				httpRequest.Patch("https://discord.com/api/v9/guilds/" + string_0 + "/voice-states/@me", text8, "application/json");
			}
			catch
			{
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000F698 File Offset: 0x0000D898
		public void GoLive(string string_0, string string_1)
		{
			try
			{
				this.SendToWS(string.Concat(new string[]
				{
					"{\"op\":18,\"d\":{\"type\":\"guild\",\"guild_id\":\"",
					string_0,
					"\",\"channel_id\":\"",
					string_1,
					"\",\"preferred_region\":null}}"
				}));
				this.SendToWS(string.Concat(new string[]
				{
					"{\"op\":22,\"d\":{\"stream_key\":\"guild:",
					string_0,
					":",
					string_1,
					":",
					this.GetUserId(),
					"\",\"paused\":false}}"
				}));
			}
			catch
			{
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000F730 File Offset: 0x0000D930
		public void StopGoLive(string string_0, string string_1)
		{
			try
			{
				this.SendToWS(string.Concat(new string[]
				{
					"{\"op\":19,\"d\":{\"stream_key\":\"guild:",
					string_0,
					":",
					string_1,
					":",
					this.GetUserId(),
					"\"}}"
				}));
			}
			catch
			{
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000F798 File Offset: 0x0000D998
		public void JoinGoLive(string string_0, string string_1, string string_2)
		{
			try
			{
				this.SendToWS(string.Concat(new string[]
				{
					"{\"op\":20,\"d\":{\"stream_key\":\"guild:",
					string_0,
					":",
					string_1,
					":",
					string_2,
					"\"}}"
				}));
			}
			catch
			{
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		public void LeaveGoLive(string string_0, string string_1, string string_2)
		{
			try
			{
				this.SendToWS(string.Concat(new string[]
				{
					"{\"op\":19,\"d\":{\"stream_key\":\"guild:",
					string_0,
					":",
					string_1,
					":",
					string_2,
					"\"}}"
				}));
			}
			catch
			{
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000F858 File Offset: 0x0000DA58
		public void JoinVoice(string string_0, string string_1, string string_2, bool bool_0, bool bool_1, bool bool_2, bool bool_3, bool bool_4, bool bool_5)
		{
			try
			{
				if (!this.connectedToVoice)
				{
					this.connectedToVoice = true;
					this.data = new AutoReconnectData(string_0, string_1, string_2, bool_0, bool_1, bool_2, bool_3, bool_4, bool_5);
					this.SendToWS(string.Concat(new string[]
					{
						"{\"op\":4,\"d\":{\"guild_id\":\"",
						string_0,
						"\",\"channel_id\":\"",
						string_1,
						"\",\"self_mute\":",
						bool_0.ToString().ToLower(),
						",\"self_deaf\":",
						bool_1.ToString().ToLower(),
						",\"self_video\":",
						bool_2.ToString().ToLower(),
						",\"preferred_region\":null}}"
					}));
					if (bool_5)
					{
						this.SendSpeakRequestToStageChannel(string_0, string_1);
					}
					else
					{
						if (bool_3)
						{
							this.GoLive(string_0, string_1);
						}
						if (bool_4 && Utils.smethod_2(string_2))
						{
							this.JoinGoLive(string_0, string_1, string_2);
						}
					}
				}
			}
			catch
			{
				this.connectedToVoice = false;
			}
		}

		// Token: 0x040000B9 RID: 185
		public string token;

		// Token: 0x040000BA RID: 186
		public string language = "";

		// Token: 0x040000BB RID: 187
		public string cookie = "";

		// Token: 0x040000BC RID: 188
		public string superProperties = "";

		// Token: 0x040000BD RID: 189
		public string userAgent = "";

		// Token: 0x040000BE RID: 190
		public string userId = "";

		// Token: 0x040000BF RID: 191
		public WebSocket ws;

		// Token: 0x040000C0 RID: 192
		public bool connected;

		// Token: 0x040000C1 RID: 193
		public bool phoneVerified;

		// Token: 0x040000C2 RID: 194
		public string client_build_number;

		// Token: 0x040000C3 RID: 195
		public List<string> queue = new List<string>();

		// Token: 0x040000C4 RID: 196
		public List<string> idQueue = new List<string>();

		// Token: 0x040000C5 RID: 197
		private string phoneNumber = "";

		// Token: 0x040000C6 RID: 198
		private AutoReconnectData data = null;

		// Token: 0x040000C7 RID: 199
		public bool connectedToVoice;

		// Token: 0x040000C8 RID: 200
		public int payloads = 0;
	}
}
