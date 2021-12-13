using System;
using Leaf.xNet;

namespace LunaTokenGenV2
{
	// Token: 0x02000027 RID: 39
	public static class Request
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00012040 File Offset: 0x00010240
		public static void Settings(this HttpRequest httpRequest_0, string string_0)
		{
			httpRequest_0.IgnoreProtocolErrors = true;
			httpRequest_0.KeepTemporaryHeadersOnRedirect = false;
			httpRequest_0.ClearAllHeaders();
			httpRequest_0.EnableMiddleHeaders = false;
			httpRequest_0.AllowEmptyHeaderValues = false;
			httpRequest_0.AddHeader("Accept", "*/*");
			httpRequest_0.AddHeader("Accept-Encoding", "gzip, deflate, br");
			httpRequest_0.AddHeader("Accept-Language", "en-US");
			httpRequest_0.AddHeader("Authorization", string_0);
			httpRequest_0.AddHeader("Connection", "keep-alive");
			httpRequest_0.AddHeader("Cookie", string.Concat(new string[]
			{
				"__cfduid=",
				"bubzym4akql32k76dmw1s5skxwsj4sa3hzic0ilbsiy",
				"; __dcfduid=",
				"xtxgz9fwzbg2gc0bb4vg1qsvcc5g4buj",
				"; locale=en-US"
			}));
			httpRequest_0.AddHeader("DNT", "1");
			httpRequest_0.AddHeader("origin", "https://discord.com");
			httpRequest_0.AddHeader("Referer", "https://discord.com/channels/@me");
			httpRequest_0.AddHeader("TE", "Trailers");
			httpRequest_0.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/1.0.9001 Chrome/83.0.4103.122 Electron/9.3.5 Safari/537.36");
			httpRequest_0.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
		}
	}
}
