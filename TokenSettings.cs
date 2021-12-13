using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LunaTokenGenV2
{
	// Token: 0x02000029 RID: 41
	public class TokenSettings
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00012944 File Offset: 0x00010B44
		public static string RandomCookie(int int_0)
		{
			return new string((from string_0 in Enumerable.Repeat<string>("abcdefghijklmnopqrstuvwxyz0123456789", int_0)
			select string_0[TokenSettings.random.Next(string_0.Length)]).ToArray<char>());
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0001298C File Offset: 0x00010B8C
		[DebuggerStepThrough]
		public static void JoinServer(string string_0, string string_1, bool bool_0, string string_2, Color color_0)
		{
			TokenSettings.<JoinServer>d__2 <JoinServer>d__ = new TokenSettings.<JoinServer>d__2();
			<JoinServer>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<JoinServer>d__.Token = string_0;
			<JoinServer>d__.invite = string_1;
			<JoinServer>d__.proxied = bool_0;
			<JoinServer>d__.proxy = string_2;
			<JoinServer>d__.btnColor = color_0;
			<JoinServer>d__.<>1__state = -1;
			<JoinServer>d__.<>t__builder.Start<TokenSettings.<JoinServer>d__2>(ref <JoinServer>d__);
		}

		// Token: 0x04000151 RID: 337
		private static Random random = new Random();
	}
}
