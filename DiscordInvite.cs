using System;

namespace LunaTokenGenV2
{
	// Token: 0x0200000E RID: 14
	public class DiscordInvite
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0000246B File Offset: 0x0000066B
		public DiscordInvite(string string_0, bool bool_0, bool bool_1, ulong ulong_0, ulong ulong_1, ulong ulong_2, int int_0)
		{
			this.inviteCode = string_0;
			this.valid = bool_0;
			this.isGroup = bool_1;
			this.guildId = ulong_0;
			this.channelId = ulong_1;
			this.membersCount = ulong_2;
			this.channelType = int_0;
		}

		// Token: 0x04000048 RID: 72
		public string inviteCode;

		// Token: 0x04000049 RID: 73
		public bool valid;

		// Token: 0x0400004A RID: 74
		public bool isGroup;

		// Token: 0x0400004B RID: 75
		public ulong guildId;

		// Token: 0x0400004C RID: 76
		public ulong channelId;

		// Token: 0x0400004D RID: 77
		public ulong membersCount;

		// Token: 0x0400004E RID: 78
		public int channelType;
	}
}
