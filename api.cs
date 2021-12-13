using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace LunaTokenGenV2
{
	// Token: 0x02000006 RID: 6
	public class api
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000048D8 File Offset: 0x00002AD8
		public api(string string_0, string string_1, string string_2, string string_3)
		{
			if (string.IsNullOrWhiteSpace(string_0) || string.IsNullOrWhiteSpace(string_1) || string.IsNullOrWhiteSpace(string_2) || string.IsNullOrWhiteSpace(string_3))
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = string_0;
			this.ownerid = string_1;
			this.secret = string_2;
			this.version = string_3;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004958 File Offset: 0x00002B58
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string text2 = api.req(nameValueCollection_);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (response_structure.success)
			{
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else if (response_structure.message == "invalidver")
			{
				Process.Start(response_structure.download);
				Environment.Exit(0);
			}
			else
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004AE0 File Offset: 0x00002CE0
		public void register(string string_0, string string_1, string string_2)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(string_1, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(string_2, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_3 = api.req(nameValueCollection_);
			string_3 = encryption.decrypt(string_3, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_3);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			else
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004C64 File Offset: 0x00002E64
		public void login(string string_0, string string_1)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(string_1, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_2 = api.req(nameValueCollection_);
			string_2 = encryption.decrypt(string_2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			else
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004DD0 File Offset: 0x00002FD0
		public void upgrade(string string_0, string string_1)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(string_1, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_2 = api.req(nameValueCollection_);
			string_2 = encryption.decrypt(string_2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004F14 File Offset: 0x00003114
		public void license(string string_0)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_ = api.req(nameValueCollection_);
			string_ = encryption.decrypt(string_, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			else
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005068 File Offset: 0x00003268
		public void setvar(string string_0, string string_1)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(string_1, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_2 = api.req(nameValueCollection_);
			string_2 = encryption.decrypt(string_2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000519C File Offset: 0x0000339C
		public string getvar(string string_0)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_ = api.req(nameValueCollection_);
			string_ = encryption.decrypt(string_, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_);
			string result;
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				result = null;
			}
			else
			{
				result = response_structure.response;
			}
			return result;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000052C8 File Offset: 0x000034C8
		public void ban()
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_ = api.req(nameValueCollection_);
			string_ = encryption.decrypt(string_, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000053CC File Offset: 0x000035CC
		public string var(string string_0)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_ = api.req(nameValueCollection_);
			string_ = encryption.decrypt(string_, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_);
			string result;
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				result = null;
			}
			else
			{
				result = response_structure.message;
			}
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005508 File Offset: 0x00003708
		public List<api.msg> chatget(string string_0)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_ = api.req(nameValueCollection_);
			string_ = encryption.decrypt(string_, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_);
			List<api.msg> result;
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				result = null;
			}
			else
			{
				result = response_structure.messages;
			}
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005634 File Offset: 0x00003834
		public bool chatsend(string string_0, string string_1)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(string_1, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_2 = api.req(nameValueCollection_);
			string_2 = encryption.decrypt(string_2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_2);
			bool result;
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000576C File Offset: 0x0000396C
		public bool checkblack()
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_ = api.req(nameValueCollection_);
			string_ = encryption.decrypt(string_, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_);
			return response_structure.success;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005894 File Offset: 0x00003A94
		public void webhook(string string_0, string string_1)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(string_1, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_2 = api.req(nameValueCollection_);
			string_2 = encryption.decrypt(string_2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000059C8 File Offset: 0x00003BC8
		public byte[] download(string string_0)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first. File is empty since no request could be made.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			string string_ = api.req(nameValueCollection_);
			string_ = encryption.decrypt(string_, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(string_);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			return encryption.str_to_byte_arr(response_structure.contents);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005AF4 File Offset: 0x00003CF4
		public void log(string string_0)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(string_0, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection_ = nameValueCollection;
			api.req(nameValueCollection_);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005BF4 File Offset: 0x00003DF4
		public static string checksum(string string_0)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(string_0))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005C6C File Offset: 0x00003E6C
		public static void error(string string_0)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + string_0 + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005CBC File Offset: 0x00003EBC
		private static string req(NameValueCollection nameValueCollection_0)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", nameValueCollection_0);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005D68 File Offset: 0x00003F68
		private void load_user_data(api.user_data_structure user_data_structure_0)
		{
			this.user_data.username = user_data_structure_0.username;
			this.user_data.ip = user_data_structure_0.ip;
			this.user_data.hwid = user_data_structure_0.hwid;
			this.user_data.createdate = user_data_structure_0.createdate;
			this.user_data.lastlogin = user_data_structure_0.lastlogin;
			this.user_data.subscriptions = user_data_structure_0.subscriptions;
		}

		// Token: 0x04000023 RID: 35
		public string name;

		// Token: 0x04000024 RID: 36
		public string ownerid;

		// Token: 0x04000025 RID: 37
		public string secret;

		// Token: 0x04000026 RID: 38
		public string version;

		// Token: 0x04000027 RID: 39
		private string sessionid;

		// Token: 0x04000028 RID: 40
		private string enckey;

		// Token: 0x04000029 RID: 41
		private bool initzalized;

		// Token: 0x0400002A RID: 42
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400002B RID: 43
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000007 RID: 7
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000003 RID: 3
			// (get) Token: 0x0600004C RID: 76 RVA: 0x00002261 File Offset: 0x00000461
			// (set) Token: 0x0600004D RID: 77 RVA: 0x00002269 File Offset: 0x00000469
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600004E RID: 78 RVA: 0x00002272 File Offset: 0x00000472
			// (set) Token: 0x0600004F RID: 79 RVA: 0x0000227A File Offset: 0x0000047A
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000050 RID: 80 RVA: 0x00002283 File Offset: 0x00000483
			// (set) Token: 0x06000051 RID: 81 RVA: 0x0000228B File Offset: 0x0000048B
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000052 RID: 82 RVA: 0x00002294 File Offset: 0x00000494
			// (set) Token: 0x06000053 RID: 83 RVA: 0x0000229C File Offset: 0x0000049C
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000054 RID: 84 RVA: 0x000022A5 File Offset: 0x000004A5
			// (set) Token: 0x06000055 RID: 85 RVA: 0x000022AD File Offset: 0x000004AD
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000056 RID: 86 RVA: 0x000022B6 File Offset: 0x000004B6
			// (set) Token: 0x06000057 RID: 87 RVA: 0x000022BE File Offset: 0x000004BE
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000058 RID: 88 RVA: 0x000022C7 File Offset: 0x000004C7
			// (set) Token: 0x06000059 RID: 89 RVA: 0x000022CF File Offset: 0x000004CF
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600005A RID: 90 RVA: 0x000022D8 File Offset: 0x000004D8
			// (set) Token: 0x0600005B RID: 91 RVA: 0x000022E0 File Offset: 0x000004E0
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x02000008 RID: 8
		public class msg
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600005D RID: 93 RVA: 0x000022F1 File Offset: 0x000004F1
			// (set) Token: 0x0600005E RID: 94 RVA: 0x000022F9 File Offset: 0x000004F9
			public string message { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600005F RID: 95 RVA: 0x00002302 File Offset: 0x00000502
			// (set) Token: 0x06000060 RID: 96 RVA: 0x0000230A File Offset: 0x0000050A
			public string author { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000061 RID: 97 RVA: 0x00002313 File Offset: 0x00000513
			// (set) Token: 0x06000062 RID: 98 RVA: 0x0000231B File Offset: 0x0000051B
			public string timestamp { get; set; }
		}

		// Token: 0x02000009 RID: 9
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000064 RID: 100 RVA: 0x00002324 File Offset: 0x00000524
			// (set) Token: 0x06000065 RID: 101 RVA: 0x0000232C File Offset: 0x0000052C
			[DataMember]
			public string username { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00002335 File Offset: 0x00000535
			// (set) Token: 0x06000067 RID: 103 RVA: 0x0000233D File Offset: 0x0000053D
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000068 RID: 104 RVA: 0x00002346 File Offset: 0x00000546
			// (set) Token: 0x06000069 RID: 105 RVA: 0x0000234E File Offset: 0x0000054E
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600006A RID: 106 RVA: 0x00002357 File Offset: 0x00000557
			// (set) Token: 0x0600006B RID: 107 RVA: 0x0000235F File Offset: 0x0000055F
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600006C RID: 108 RVA: 0x00002368 File Offset: 0x00000568
			// (set) Token: 0x0600006D RID: 109 RVA: 0x00002370 File Offset: 0x00000570
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600006E RID: 110 RVA: 0x00002379 File Offset: 0x00000579
			// (set) Token: 0x0600006F RID: 111 RVA: 0x00002381 File Offset: 0x00000581
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000A RID: 10
		public class user_data_class
		{
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000071 RID: 113 RVA: 0x0000238A File Offset: 0x0000058A
			// (set) Token: 0x06000072 RID: 114 RVA: 0x00002392 File Offset: 0x00000592
			public string username { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000073 RID: 115 RVA: 0x0000239B File Offset: 0x0000059B
			// (set) Token: 0x06000074 RID: 116 RVA: 0x000023A3 File Offset: 0x000005A3
			public string ip { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000075 RID: 117 RVA: 0x000023AC File Offset: 0x000005AC
			// (set) Token: 0x06000076 RID: 118 RVA: 0x000023B4 File Offset: 0x000005B4
			public string hwid { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000077 RID: 119 RVA: 0x000023BD File Offset: 0x000005BD
			// (set) Token: 0x06000078 RID: 120 RVA: 0x000023C5 File Offset: 0x000005C5
			public string createdate { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000079 RID: 121 RVA: 0x000023CE File Offset: 0x000005CE
			// (set) Token: 0x0600007A RID: 122 RVA: 0x000023D6 File Offset: 0x000005D6
			public string lastlogin { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600007B RID: 123 RVA: 0x000023DF File Offset: 0x000005DF
			// (set) Token: 0x0600007C RID: 124 RVA: 0x000023E7 File Offset: 0x000005E7
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000B RID: 11
		public class Data
		{
			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600007E RID: 126 RVA: 0x000023F0 File Offset: 0x000005F0
			// (set) Token: 0x0600007F RID: 127 RVA: 0x000023F8 File Offset: 0x000005F8
			public string subscription { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000080 RID: 128 RVA: 0x00002401 File Offset: 0x00000601
			// (set) Token: 0x06000081 RID: 129 RVA: 0x00002409 File Offset: 0x00000609
			public string expiry { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000082 RID: 130 RVA: 0x00002412 File Offset: 0x00000612
			// (set) Token: 0x06000083 RID: 131 RVA: 0x0000241A File Offset: 0x0000061A
			public string timeleft { get; set; }
		}
	}
}
