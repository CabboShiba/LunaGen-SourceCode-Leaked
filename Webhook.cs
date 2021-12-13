using System;
using System.Net;
using System.Net.Http;

namespace LunaTokenGenV2
{
	// Token: 0x02000030 RID: 48
	internal class Webhook
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000027D1 File Offset: 0x000009D1
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000027D9 File Offset: 0x000009D9
		public string Name { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000027E2 File Offset: 0x000009E2
		// (set) Token: 0x06000138 RID: 312 RVA: 0x000027EA File Offset: 0x000009EA
		public string ProfilePictureUrl { get; set; }

		// Token: 0x06000139 RID: 313 RVA: 0x000027F3 File Offset: 0x000009F3
		public Webhook(string string_0)
		{
			this.Client = new HttpClient();
			this.Url = string_0;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001482C File Offset: 0x00012A2C
		public bool SendMessage(string string_0, string string_1 = null)
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			multipartFormDataContent.Add(new StringContent(this.Name), "username");
			multipartFormDataContent.Add(new StringContent(this.ProfilePictureUrl), "avatar_url");
			multipartFormDataContent.Add(new StringContent(string_0), "content");
			return this.Client.PostAsync(this.Url, multipartFormDataContent).Result.StatusCode == HttpStatusCode.NoContent;
		}

		// Token: 0x04000189 RID: 393
		private HttpClient Client;

		// Token: 0x0400018A RID: 394
		private string Url;
	}
}
