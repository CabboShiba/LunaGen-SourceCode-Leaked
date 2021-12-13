using System;

namespace LunaTokenGenV2
{
	// Token: 0x02000015 RID: 21
	public class AutoReconnectData
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000A268 File Offset: 0x00008468
		public AutoReconnectData(string string_0, string string_1, string string_2, bool bool_0, bool bool_1, bool bool_2, bool bool_3, bool bool_4, bool bool_5)
		{
			this.guildId = string_0;
			this.channelId = string_1;
			this.userIdGoLive = string_2;
			this.microphoneMuted = bool_0;
			this.headphonesMuted = bool_1;
			this.videoEnabled = bool_2;
			this.goLive = bool_3;
			this.joinGoLive = bool_4;
			this.speakInStage = bool_5;
		}

		// Token: 0x040000B0 RID: 176
		public string guildId;

		// Token: 0x040000B1 RID: 177
		public string channelId;

		// Token: 0x040000B2 RID: 178
		public string userIdGoLive;

		// Token: 0x040000B3 RID: 179
		public bool microphoneMuted;

		// Token: 0x040000B4 RID: 180
		public bool headphonesMuted;

		// Token: 0x040000B5 RID: 181
		public bool videoEnabled;

		// Token: 0x040000B6 RID: 182
		public bool goLive;

		// Token: 0x040000B7 RID: 183
		public bool joinGoLive;

		// Token: 0x040000B8 RID: 184
		public bool speakInStage;
	}
}
