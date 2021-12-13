using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using BrotliSharpLib;
using Leaf.xNet;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;

namespace LunaTokenGenV2
{
	// Token: 0x0200002D RID: 45
	public static class Utils
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00012FF0 File Offset: 0x000111F0
		public static bool IsFriendValid(string string_0)
		{
			bool result;
			try
			{
				result = (Utils.smethod_2(string_0) || Utils.IsTagValid(string_0));
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002940 File Offset: 0x00000B40
		public static string GetLagMessage()
		{
			return ":chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains:";
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002954 File Offset: 0x00000B54
		public static string ReplaceFirst(string string_0, string string_1, string string_2)
		{
			try
			{
				int num = string_0.IndexOf(string_1);
				if (num < 0)
				{
					return string_0;
				}
				return string_0.Substring(0, num) + string_2 + string_0.Substring(num + string_1.Length);
			}
			catch
			{
			}
			return string_0;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00013028 File Offset: 0x00011228
		public static bool smethod_0(string string_0)
		{
			bool result;
			try
			{
				string_0 = string_0.Replace(" ", "").Replace('\t'.ToString(), "").Trim();
				if (!string_0.Contains(","))
				{
					if (!Utils.smethod_2(string_0))
					{
						return false;
					}
				}
				else
				{
					try
					{
						string[] array = Strings.Split(string_0, ",", -1, CompareMethod.Binary);
						try
						{
							foreach (string string_ in array)
							{
								try
								{
									if (!Utils.smethod_2(string_))
									{
										return false;
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
					catch
					{
					}
				}
				string_0 = null;
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002A90 File Offset: 0x00000C90
		public static List<string> GetIDs(string string_0)
		{
			List<string> list = new List<string>();
			try
			{
				string_0 = string_0.Replace(" ", "").Replace('\t'.ToString(), "").Trim();
				if (string_0.Contains(","))
				{
					string[] array = Strings.Split(string_0, ",", -1, CompareMethod.Binary);
					foreach (string item in array)
					{
						list.Add(item);
					}
				}
				else
				{
					list.Add(string_0);
				}
				string_0 = null;
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001310C File Offset: 0x0001130C
		public static string GetXCP(DiscordInvite discordInvite_0)
		{
			string result;
			try
			{
				result = Utils.GetXCP(discordInvite_0.guildId.ToString(), discordInvite_0.channelId.ToString(), discordInvite_0.channelType.ToString());
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00013160 File Offset: 0x00011360
		public static string GetXCP(string string_0, string string_1, string string_2)
		{
			string result;
			try
			{
				result = Utils.Base64Encode(string.Concat(new string[]
				{
					"{\"location\":\"Join Guild\",\"location_guild_id\":\"",
					string_0,
					"\",\"location_channel_id\":\"",
					string_1,
					"\",\"location_channel_type\":",
					string_2,
					"}"
				}));
			}
			catch
			{
				result = "eyJsb2NhdGlvbiI6IkpvaW4gR3VpbGQiLCJsb2NhdGlvbl9ndWlsZF9pZCI6IjgyMjU4NDA5NTg5MTY1MjYyOSIsImxvY2F0aW9uX2NoYW5uZWxfaWQiOiI4MjI1ODQwOTYzNzA3MjA3NjgiLCJsb2NhdGlvbl9jaGFubmVsX3R5cGUiOjB9";
			}
			return result;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002BF0 File Offset: 0x00000DF0
		public static string Base64Encode(string string_0)
		{
			string result;
			try
			{
				result = Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0));
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002C2C File Offset: 0x00000E2C
		public static DateTime GetCurrentRealDateTime()
		{
			DateTime result;
			try
			{
				result = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds + 7200.0);
			}
			catch
			{
				result = DateTime.Now;
			}
			return result;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000131C8 File Offset: 0x000113C8
		public static DiscordInvite GetInviteInformations(string string_0, bool bool_0)
		{
			DiscordInvite result;
			try
			{
				string inviteCodeByInviteLink = Utils.GetInviteCodeByInviteLink(string_0);
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				string json;
				if (bool_0)
				{
					json = Utils.DecompressResponse(httpRequest.Get("https://discord.com/api/v9/invites/" + inviteCodeByInviteLink + "?with_counts=true&with_expiration=true", null));
				}
				else
				{
					json = Utils.DecompressResponse(httpRequest.Get(string.Concat(new string[]
					{
						"https://discord.com/api/v9/invites/",
						inviteCodeByInviteLink,
						"?inputValue=https://discord.gg/",
						inviteCodeByInviteLink,
						"&with_counts=true&with_expiration=true"
					}), null));
				}
				object arg = JObject.Parse(json);
				string s = "0";
				string s2 = "0";
				string s3 = "0";
				if (Utils.<>o__13.<>p__1 == null)
				{
					Utils.<>o__13.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Utils)));
				}
				Func<CallSite, object, string> target = Utils.<>o__13.<>p__1.Target;
				CallSite <>p__ = Utils.<>o__13.<>p__1;
				if (Utils.<>o__13.<>p__0 == null)
				{
					Utils.<>o__13.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "code", typeof(Utils), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				string a = target(<>p__, Utils.<>o__13.<>p__0.Target(Utils.<>o__13.<>p__0, arg));
				string s4 = "";
				bool flag = true;
				if (a == "10006" || a == "0" || a != inviteCodeByInviteLink)
				{
					flag = false;
				}
				if (flag)
				{
					if (!bool_0)
					{
						if (Utils.<>o__13.<>p__4 == null)
						{
							Utils.<>o__13.<>p__4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Utils)));
						}
						Func<CallSite, object, string> target2 = Utils.<>o__13.<>p__4.Target;
						CallSite <>p__2 = Utils.<>o__13.<>p__4;
						if (Utils.<>o__13.<>p__3 == null)
						{
							Utils.<>o__13.<>p__3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(Utils), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target3 = Utils.<>o__13.<>p__3.Target;
						CallSite <>p__3 = Utils.<>o__13.<>p__3;
						if (Utils.<>o__13.<>p__2 == null)
						{
							Utils.<>o__13.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "guild", typeof(Utils), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						s = target2(<>p__2, target3(<>p__3, Utils.<>o__13.<>p__2.Target(Utils.<>o__13.<>p__2, arg)));
					}
					if (Utils.<>o__13.<>p__7 == null)
					{
						Utils.<>o__13.<>p__7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Utils)));
					}
					Func<CallSite, object, string> target4 = Utils.<>o__13.<>p__7.Target;
					CallSite <>p__4 = Utils.<>o__13.<>p__7;
					if (Utils.<>o__13.<>p__6 == null)
					{
						Utils.<>o__13.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(Utils), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target5 = Utils.<>o__13.<>p__6.Target;
					CallSite <>p__5 = Utils.<>o__13.<>p__6;
					if (Utils.<>o__13.<>p__5 == null)
					{
						Utils.<>o__13.<>p__5 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "channel", typeof(Utils), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					s2 = target4(<>p__4, target5(<>p__5, Utils.<>o__13.<>p__5.Target(Utils.<>o__13.<>p__5, arg)));
					if (Utils.<>o__13.<>p__10 == null)
					{
						Utils.<>o__13.<>p__10 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Utils)));
					}
					Func<CallSite, object, string> target6 = Utils.<>o__13.<>p__10.Target;
					CallSite <>p__6 = Utils.<>o__13.<>p__10;
					if (Utils.<>o__13.<>p__9 == null)
					{
						Utils.<>o__13.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "type", typeof(Utils), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target7 = Utils.<>o__13.<>p__9.Target;
					CallSite <>p__7 = Utils.<>o__13.<>p__9;
					if (Utils.<>o__13.<>p__8 == null)
					{
						Utils.<>o__13.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "channel", typeof(Utils), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					s3 = target6(<>p__6, target7(<>p__7, Utils.<>o__13.<>p__8.Target(Utils.<>o__13.<>p__8, arg)));
					if (Utils.<>o__13.<>p__12 == null)
					{
						Utils.<>o__13.<>p__12 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Utils)));
					}
					Func<CallSite, object, string> target8 = Utils.<>o__13.<>p__12.Target;
					CallSite <>p__8 = Utils.<>o__13.<>p__12;
					if (Utils.<>o__13.<>p__11 == null)
					{
						Utils.<>o__13.<>p__11 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "approximate_member_count", typeof(Utils), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					s4 = target8(<>p__8, Utils.<>o__13.<>p__11.Target(Utils.<>o__13.<>p__11, arg));
				}
				result = new DiscordInvite(inviteCodeByInviteLink, flag, bool_0, ulong.Parse(s), ulong.Parse(s2), ulong.Parse(s4), int.Parse(s3));
			}
			catch
			{
				result = new DiscordInvite(Utils.GetInviteCodeByInviteLink(string_0), false, false, 0UL, 0UL, 0UL, 0);
			}
			return result;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000136D0 File Offset: 0x000118D0
		public static string GetTest()
		{
			string result;
			try
			{
				string text = "";
				string text2 = "";
				DateTime currentRealDateTime = Utils.GetCurrentRealDateTime();
				string text3 = currentRealDateTime.Day.ToString();
				if (text3.Length == 1)
				{
					text3 = "0" + text3;
				}
				string text4 = currentRealDateTime.Year.ToString();
				string text5 = currentRealDateTime.Hour.ToString();
				string text6 = currentRealDateTime.Minute.ToString();
				string text7 = currentRealDateTime.Second.ToString();
				if (text5.Length == 1)
				{
					text5 = "0" + text5;
				}
				if (text6.Length == 1)
				{
					text6 = "0" + text6;
				}
				if (text7.Length == 1)
				{
					text7 = "0" + text7;
				}
				if (currentRealDateTime.Month == 1)
				{
					text2 = "Jan";
				}
				else if (currentRealDateTime.Month == 2)
				{
					text2 = "Feb";
				}
				else if (currentRealDateTime.Month == 3)
				{
					text2 = "Mar";
				}
				else if (currentRealDateTime.Month == 4)
				{
					text2 = "Apr";
				}
				else if (currentRealDateTime.Month == 5)
				{
					text2 = "May";
				}
				else if (currentRealDateTime.Month == 6)
				{
					text2 = "Jun";
				}
				else if (currentRealDateTime.Month == 7)
				{
					text2 = "Jul";
				}
				else if (currentRealDateTime.Month == 8)
				{
					text2 = "Aug";
				}
				else if (currentRealDateTime.Month == 9)
				{
					text2 = "Sep";
				}
				else if (currentRealDateTime.Month == 10)
				{
					text2 = "Oct";
				}
				else if (currentRealDateTime.Month == 11)
				{
					text2 = "Nov";
				}
				else if (currentRealDateTime.Month == 12)
				{
					text2 = "Dec";
				}
				if (currentRealDateTime.DayOfWeek == DayOfWeek.Monday)
				{
					text = "Mon";
				}
				else if (currentRealDateTime.DayOfWeek == DayOfWeek.Tuesday)
				{
					text = "Tue";
				}
				else if (currentRealDateTime.DayOfWeek == DayOfWeek.Wednesday)
				{
					text = "Wed";
				}
				else if (currentRealDateTime.DayOfWeek == DayOfWeek.Thursday)
				{
					text = "Thu";
				}
				else if (currentRealDateTime.DayOfWeek == DayOfWeek.Friday)
				{
					text = "Fri";
				}
				else if (currentRealDateTime.DayOfWeek == DayOfWeek.Saturday)
				{
					text = "Sat";
				}
				else if (currentRealDateTime.DayOfWeek == DayOfWeek.Sunday)
				{
					text = "Sun";
				}
				result = string.Concat(new string[]
				{
					"isIABGlobal=false&datestamp=",
					text,
					"+",
					text2,
					"+",
					text3,
					"+",
					text4,
					"+",
					text5,
					":",
					text6,
					":",
					text7,
					"+GMT+0200+(Ora+legale+dellâ\u0080\u0099Europa+centrale)&version=6.17.0&hosts=&landingPath=NotLandingPage&groups=C0001:1,C0002:1,C0003:1&geolocation=IT;62&AwaitingReconsent=false"
				});
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000139F8 File Offset: 0x00011BF8
		public static string GetRandomCookie(string string_0)
		{
			string result;
			try
			{
				result = string.Concat(new string[]
				{
					"__cfduid=",
					"ovhcmg06z3t3l6s33u1mz3r3pjqbrrgevquirfwsmgn",
					"; __dcfduid=",
					"5h1harwycqiy8i0vysskc0hxer68xd3k",
					"; rebrand_bucket=",
					"ejqv39nl5q0rixhwlibkav5mq0a5h1wc",
					"; OptanonAlertBoxClosed=2021-05-30T14:59:00.092Z; locale=",
					string_0
				});
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00003544 File Offset: 0x00001744
		public static string GetInviteCodeByInviteLink(string string_0)
		{
			try
			{
				if (string_0.EndsWith("/"))
				{
					string_0 = string_0.Substring(0, string_0.Length - 1);
				}
				if (string_0.Contains("discord") && string_0.Contains("/") && string_0.Contains("http"))
				{
					string[] array = Strings.Split(string_0, "/", -1, CompareMethod.Binary);
					return array[array.Length - 1];
				}
			}
			catch
			{
			}
			return string_0;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002768 File Offset: 0x00000968
		public static IEnumerable<string> SplitToLines(string string_0)
		{
			Utils.<SplitToLines>d__17 <SplitToLines>d__ = new Utils.<SplitToLines>d__17(-2);
			<SplitToLines>d__.<>3__input = string_0;
			return <SplitToLines>d__;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00013A70 File Offset: 0x00011C70
		public static bool IsTokenValid(string string_0)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Authorization", string_0);
				try
				{
					httpRequest.Get("https://discord.com/api/v9/users/@me/library", null);
					if (httpRequest.Response.IsOK)
					{
						return true;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00013AEC File Offset: 0x00011CEC
		public static bool IsProxyValid(string string_0)
		{
			bool result;
			try
			{
				char[] array = string_0.ToCharArray();
				int num = 0;
				foreach (char c in array)
				{
					if (c == ':')
					{
						num++;
					}
				}
				string[] array3 = Strings.Split(string_0, ":", -1, CompareMethod.Binary);
				result = Utils.PingHost(array3[0], int.Parse(array3[1]));
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000036C0 File Offset: 0x000018C0
		public static bool PingHost(string string_0, int int_0)
		{
			bool result;
			try
			{
				bool flag = false;
				try
				{
					new TcpClient(string_0, int_0);
					flag = true;
				}
				catch (Exception)
				{
					return false;
				}
				result = flag;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00013B64 File Offset: 0x00011D64
		public static string smethod_1(DiscordInvite discordInvite_0)
		{
			string result;
			try
			{
				result = Utils.Base64Encode(string.Concat(new string[]
				{
					"{\"location\":\"Invite Button Embed\",\"location_guild_id\":null,\"location_channel_id\":\"",
					discordInvite_0.channelId.ToString(),
					"\",\"location_channel_type\":",
					discordInvite_0.channelType.ToString(),
					",\"location_message_id\":null}"
				}));
			}
			catch
			{
				result = "eyJsb2NhdGlvbiI6Ikludml0ZSBCdXR0b24gRW1iZWQiLCJsb2NhdGlvbl9ndWlsZF9pZCI6bnVsbCwibG9jYXRpb25fY2hhbm5lbF9pZCI6IjgzNzM5NzUzMDAzODg5NDY0MiIsImxvY2F0aW9uX2NoYW5uZWxfdHlwZSI6MSwibG9jYXRpb25fbWVzc2FnZV9pZCI6IjgzNzU5MjQyMDAxNDA5NjM4NCJ9";
			}
			return result;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00003778 File Offset: 0x00001978
		public static string GetCleanToken(string string_0)
		{
			string result;
			try
			{
				result = string_0.Replace(" ", "").Trim().Replace('\t'.ToString(), "");
			}
			catch
			{
				result = string_0;
			}
			return result;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00013BD4 File Offset: 0x00011DD4
		public static bool IsTokenFormatValid(string string_0)
		{
			bool result;
			try
			{
				string cleanToken = Utils.GetCleanToken(string_0);
				if (cleanToken == null || cleanToken == "")
				{
					result = false;
				}
				else if (cleanToken.Length != 88 && cleanToken.Length != 59)
				{
					result = false;
				}
				else
				{
					if (cleanToken.Length == 88)
					{
						if (!cleanToken.StartsWith("mfa."))
						{
							return false;
						}
					}
					else
					{
						char[] array = cleanToken.ToCharArray();
						int num = 0;
						foreach (char c in array)
						{
							if (c == '.')
							{
								num++;
							}
						}
						if (num != 2)
						{
							return false;
						}
						string[] array3 = Strings.Split(cleanToken, ".", -1, CompareMethod.Binary);
						if (array3[0].Length != 24)
						{
							return false;
						}
						if (array3[1].Length != 6)
						{
							return false;
						}
						if (array3[2].Length != 27)
						{
							return false;
						}
						string string_ = Utils.Base64Decode(array3[0]);
						if (!Utils.smethod_2(string_))
						{
							return false;
						}
						string text = Utils.DecimalToBinary(string_);
						if (text.Length != 60)
						{
							return false;
						}
					}
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00013D44 File Offset: 0x00011F44
		public static bool IsProxyFormatValid(string string_0)
		{
			bool result;
			try
			{
				string cleanToken = Utils.GetCleanToken(string_0);
				if (cleanToken == "" || cleanToken == null)
				{
					result = false;
				}
				else
				{
					char[] array = cleanToken.ToCharArray();
					int num = 0;
					foreach (char c in array)
					{
						if (c == ':')
						{
							num++;
						}
					}
					if (num != 1 && num != 3)
					{
						result = false;
					}
					else
					{
						string[] array3 = Strings.Split(cleanToken, ":", -1, CompareMethod.Binary);
						string text = array3[0];
						string text2 = array3[1];
						if (text.Length > 15)
						{
							result = false;
						}
						else if (text2.Length > 5)
						{
							result = false;
						}
						else if (!Information.IsNumeric(text2))
						{
							result = false;
						}
						else
						{
							int num2 = int.Parse(text2);
							if (num2 < 0 || num2 > 65535)
							{
								result = false;
							}
							else
							{
								char[] array4 = text.ToCharArray();
								int num3 = 0;
								foreach (char c2 in array4)
								{
									if (c2 == '.')
									{
										num3++;
									}
								}
								if (num3 != 3)
								{
									result = false;
								}
								else
								{
									string[] array6 = Strings.Split(text, ".", -1, CompareMethod.Binary);
									foreach (string text3 in array6)
									{
										if (text3.Length != 1 && text3.Length != 2 && text3.Length != 3)
										{
											return false;
										}
										if (!Information.IsNumeric(text3))
										{
											return false;
										}
										int num4 = int.Parse(text3);
										if (num4 < 0 || num4 > 255)
										{
											return false;
										}
									}
									if (num == 3 && (Utils.GetCleanToken(array3[2]) == "" || Utils.GetCleanToken(array3[3]) == ""))
									{
										result = false;
									}
									else
									{
										result = true;
									}
								}
							}
						}
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003B60 File Offset: 0x00001D60
		public static bool smethod_2(string string_0)
		{
			bool result;
			try
			{
				if (string_0.Length != 18)
				{
					result = false;
				}
				else if (!Information.IsNumeric(string_0))
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003BAC File Offset: 0x00001DAC
		public static string DecimalToBinary(string string_0)
		{
			string result;
			try
			{
				result = Convert.ToString(long.Parse(string_0), 2);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public static string Base64Decode(string string_0)
		{
			string result;
			try
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00003C20 File Offset: 0x00001E20
		public static HttpRequest CreateCleanRequest()
		{
			HttpRequest result;
			try
			{
				HttpRequest httpRequest = new HttpRequest();
				httpRequest.KeepTemporaryHeadersOnRedirect = false;
				httpRequest.EnableMiddleHeaders = false;
				httpRequest.ClearAllHeaders();
				httpRequest.AllowEmptyHeaderValues = false;
				httpRequest.SslProtocols = SslProtocols.Tls12;
				httpRequest.Proxy = null;
				httpRequest.Username = null;
				httpRequest.UserAgent = null;
				httpRequest.UseCookies = false;
				httpRequest.CookieSingleHeader = true;
				httpRequest.Authorization = null;
				httpRequest.BaseAddress = null;
				httpRequest.Referer = null;
				httpRequest.Reconnect = false;
				httpRequest.ReconnectDelay = 0;
				httpRequest.Password = null;
				httpRequest.KeepAlive = false;
				httpRequest.IgnoreInvalidCookie = true;
				httpRequest.IgnoreProtocolErrors = true;
				httpRequest.KeepTemporaryHeadersOnRedirect = false;
				httpRequest.MaximumKeepAliveRequests = 1;
				httpRequest.Cookies = null;
				httpRequest.CharacterSet = null;
				httpRequest.AcceptEncoding = null;
				httpRequest.Culture = null;
				httpRequest.AllowAutoRedirect = false;
				httpRequest.MaximumAutomaticRedirections = 1;
				result = httpRequest;
			}
			catch
			{
				result = new HttpRequest();
			}
			return result;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00013F68 File Offset: 0x00012168
		public static HttpProxyClient ParseProxy(string string_0)
		{
			HttpProxyClient result;
			try
			{
				char[] array = string_0.ToCharArray();
				int num = 0;
				foreach (char c in array)
				{
					if (c == ':')
					{
						num++;
					}
				}
				string[] array3 = Strings.Split(string_0, ":", -1, CompareMethod.Binary);
				if (num == 1)
				{
					result = new HttpProxyClient(array3[0], int.Parse(array3[1]));
				}
				else
				{
					result = new HttpProxyClient(array3[0], int.Parse(array3[1]), array3[2], array3[3]);
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00003DB0 File Offset: 0x00001FB0
		public static byte[] DecompressGZip(byte[] byte_0)
		{
			byte[] result;
			try
			{
				MemoryStream stream = new MemoryStream(byte_0);
				MemoryStream memoryStream = new MemoryStream();
				using (GZipStream gzipStream = new GZipStream(stream, CompressionMode.Decompress))
				{
					gzipStream.CopyTo(memoryStream);
				}
				result = memoryStream.ToArray();
			}
			catch
			{
				result = Encoding.UTF8.GetBytes("");
			}
			return result;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00003E20 File Offset: 0x00002020
		public static byte[] DecompressDeflate(byte[] byte_0)
		{
			byte[] result;
			try
			{
				MemoryStream stream = new MemoryStream(byte_0);
				MemoryStream memoryStream = new MemoryStream();
				using (DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress))
				{
					deflateStream.CopyTo(memoryStream);
				}
				result = memoryStream.ToArray();
			}
			catch
			{
				result = Encoding.UTF8.GetBytes("");
			}
			return result;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00003E90 File Offset: 0x00002090
		public static byte[] DecompressBr(byte[] byte_0)
		{
			byte[] result;
			try
			{
				result = Brotli.DecompressBuffer(byte_0, 0, byte_0.Length, null);
			}
			catch
			{
				result = Encoding.UTF8.GetBytes("");
			}
			return result;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00014004 File Offset: 0x00012204
		public static string DecompressResponse(HttpResponse httpResponse_0)
		{
			string result;
			try
			{
				if (httpResponse_0["content-encoding"].Equals("br"))
				{
					result = Encoding.UTF8.GetString(Utils.DecompressBr(httpResponse_0.ToBytes()));
				}
				else if (httpResponse_0["content-encoding"].Equals("deflate"))
				{
					result = Encoding.UTF8.GetString(Utils.DecompressDeflate(httpResponse_0.ToBytes()));
				}
				else if (httpResponse_0["content-encoding"].Equals("gzip"))
				{
					result = Encoding.UTF8.GetString(Utils.DecompressGZip(httpResponse_0.ToBytes()));
				}
				else
				{
					result = httpResponse_0.ToString();
				}
			}
			catch
			{
				result = httpResponse_0.ToString();
			}
			return result;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000140C4 File Offset: 0x000122C4
		public static string GetUniqueKey(int int_0)
		{
			string result;
			try
			{
				byte[] array = new byte[4 * int_0];
				using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
				{
					rngcryptoServiceProvider.GetBytes(array);
				}
				StringBuilder stringBuilder = new StringBuilder(int_0);
				for (int i = 0; i < int_0; i++)
				{
					uint num = BitConverter.ToUInt32(array, i * 4);
					long num2 = (long)((ulong)num % (ulong)((long)Utils.chars.Length));
					stringBuilder.Append(Utils.chars[(int)(checked((IntPtr)num2))]);
				}
				result = stringBuilder.ToString();
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00014164 File Offset: 0x00012364
		public static string GetUniqueKey1(int int_0)
		{
			string result;
			try
			{
				byte[] array = new byte[4 * int_0];
				using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
				{
					rngcryptoServiceProvider.GetBytes(array);
				}
				StringBuilder stringBuilder = new StringBuilder(int_0);
				for (int i = 0; i < int_0; i++)
				{
					uint num = BitConverter.ToUInt32(array, i * 4);
					long num2 = (long)((ulong)num % (ulong)((long)Utils.everything.Length));
					stringBuilder.Append(Utils.everything[(int)(checked((IntPtr)num2))]);
				}
				result = stringBuilder.ToString();
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00014204 File Offset: 0x00012404
		public static int GetUniqueInt(int int_0)
		{
			int result;
			try
			{
				byte[] array = new byte[4 * int_0];
				using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
				{
					rngcryptoServiceProvider.GetBytes(array);
				}
				StringBuilder stringBuilder = new StringBuilder(int_0);
				for (int i = 0; i < int_0; i++)
				{
					uint num = BitConverter.ToUInt32(array, i * 4);
					long num2 = (long)((ulong)num % (ulong)((long)Utils.numbers.Length));
					stringBuilder.Append(Utils.numbers[(int)(checked((IntPtr)num2))]);
				}
				result = int.Parse(stringBuilder.ToString());
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000142A8 File Offset: 0x000124A8
		public static long GetUniqueLong(int int_0)
		{
			long result;
			try
			{
				byte[] array = new byte[4 * int_0];
				using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
				{
					rngcryptoServiceProvider.GetBytes(array);
				}
				StringBuilder stringBuilder = new StringBuilder(int_0);
				for (int i = 0; i < int_0; i++)
				{
					uint num = BitConverter.ToUInt32(array, i * 4);
					long num2 = (long)((ulong)num % (ulong)((long)Utils.numbers.Length));
					stringBuilder.Append(Utils.numbers[(int)(checked((IntPtr)num2))]);
				}
				result = long.Parse(stringBuilder.ToString());
			}
			catch
			{
				result = 0L;
			}
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00004220 File Offset: 0x00002420
		public static bool IsCaptchaKeyValid(string string_0)
		{
			bool result;
			try
			{
				result = (string_0.Length == 32);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00014354 File Offset: 0x00012554
		public static void SendMessageToWebhook(string string_0, string string_1, string string_2, string string_3)
		{
			try
			{
				HttpRequest httpRequest = Utils.CreateCleanRequest();
				string text = string.Concat(new string[]
				{
					"username=",
					string_1,
					"&avatar_url=",
					string_2,
					"&content=",
					string_3
				});
				httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
				httpRequest.AddHeader("Content-Length", text.Length.ToString());
				httpRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");
				httpRequest.Post(string_0, text, "application/x-www-form-urlencoded");
			}
			catch
			{
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000042F8 File Offset: 0x000024F8
		public static byte[] Post(string string_0, NameValueCollection nameValueCollection_0)
		{
			byte[] result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					result = webClient.UploadValues(string_0, nameValueCollection_0);
				}
			}
			catch
			{
				result = new byte[0];
			}
			return result;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000143F8 File Offset: 0x000125F8
		public static bool AreFriendsValid(string string_0)
		{
			string_0 = string_0.Replace(" ", "").Replace('\t'.ToString(), "").Trim();
			bool result;
			try
			{
				if (!string_0.Contains(","))
				{
					if (!Utils.smethod_2(string_0) && !Utils.IsTagValid(string_0))
					{
						return false;
					}
				}
				else
				{
					string[] array = Strings.Split(string_0, ",", -1, CompareMethod.Binary);
					foreach (string string_ in array)
					{
						if (!Utils.smethod_2(string_) && !Utils.IsTagValid(string_))
						{
							return false;
						}
					}
				}
				string_0 = null;
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002A90 File Offset: 0x00000C90
		public static List<string> GetFriends(string string_0)
		{
			List<string> list = new List<string>();
			try
			{
				string_0 = string_0.Replace(" ", "").Replace('\t'.ToString(), "").Trim();
				if (string_0.Contains(","))
				{
					string[] array = Strings.Split(string_0, ",", -1, CompareMethod.Binary);
					foreach (string item in array)
					{
						list.Add(item);
					}
				}
				else
				{
					list.Add(string_0);
				}
				string_0 = null;
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004410 File Offset: 0x00002610
		public static bool IsTagValid(string string_0)
		{
			bool result;
			try
			{
				if (string_0.Length > 37)
				{
					result = false;
				}
				else if (!string_0.Contains("#"))
				{
					result = false;
				}
				else
				{
					string[] array = Strings.Split(string_0, "#", -1, CompareMethod.Binary);
					if (array[0].Replace(" ", "").Trim().Replace('\t'.ToString(), "") == "" || array[1].Replace(" ", "").Trim().Replace('\t'.ToString(), "") == "")
					{
						result = false;
					}
					else if (array[1].Replace(" ", "").Trim().Replace('\t'.ToString(), "").Length != 4)
					{
						result = false;
					}
					else if (!Information.IsNumeric(array[1].Replace(" ", "").Trim().Replace('\t'.ToString(), "")))
					{
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000144BC File Offset: 0x000126BC
		public static bool IsWebhookValid(string string_0)
		{
			bool result;
			try
			{
				if (!string_0.StartsWith("https://discord.com/api/webhooks/"))
				{
					result = false;
				}
				else if (string_0.Length != 120)
				{
					result = false;
				}
				else
				{
					string expression = string_0.Replace("https://discord.com/api/webhooks/", "");
					string[] array = Strings.Split(expression, "/", -1, CompareMethod.Binary);
					if (!Utils.smethod_2(array[0]))
					{
						result = false;
					}
					else if (array[1].Length != 68)
					{
						result = false;
					}
					else
					{
						HttpRequest httpRequest = Utils.CreateCleanRequest();
						httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
						result = Utils.DecompressResponse(httpRequest.Get(string_0, null)).Contains("id");
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00014580 File Offset: 0x00012780
		public static bool IsEmojiValid(string string_0)
		{
			return string_0.Length <= 3 && string_0.Replace(" ", "").Trim().Replace('\t'.ToString(), "").Length <= 3;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000145D4 File Offset: 0x000127D4
		public static bool IsEmoteValid(string string_0)
		{
			bool result;
			if (!string_0.Contains(":") && !string_0.Contains("%3A"))
			{
				result = false;
			}
			else
			{
				string[] array;
				if (string_0.Contains(":"))
				{
					array = Strings.Split(string_0, ":", -1, CompareMethod.Binary);
				}
				else
				{
					if (!string_0.Contains("%3A"))
					{
						return false;
					}
					array = Strings.Split(string_0, "%3A", -1, CompareMethod.Binary);
				}
				result = (Utils.smethod_2(array[1]) && !(array[0].Replace(" ", "").Replace('\t'.ToString(), "") == ""));
			}
			return result;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002778 File Offset: 0x00000978
		public static bool IsReactionValid(string string_0)
		{
			return Utils.IsEmoteValid(string_0) || Utils.IsEmojiValid(string_0);
		}

		// Token: 0x0400016E RID: 366
		public static List<string> users = new List<string>();

		// Token: 0x0400016F RID: 367
		public static List<string> roles = new List<string>();

		// Token: 0x04000170 RID: 368
		public static bool globalAutoReconnect = false;

		// Token: 0x04000171 RID: 369
		public static string lastChannelId = "";

		// Token: 0x04000172 RID: 370
		internal static readonly char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

		// Token: 0x04000173 RID: 371
		internal static readonly char[] numbers = "123456789".ToCharArray();

		// Token: 0x04000174 RID: 372
		internal static readonly char[] everything = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
	}
}
