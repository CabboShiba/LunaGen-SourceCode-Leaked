using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LunaTokenGenV2
{
	// Token: 0x0200000C RID: 12
	public static class encryption
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00005DDC File Offset: 0x00003FDC
		public static string byte_arr_to_str(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
			foreach (byte b in byte_0)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005E24 File Offset: 0x00004024
		public static byte[] str_to_byte_arr(string string_0)
		{
			byte[] result;
			try
			{
				int length = string_0.Length;
				byte[] array = new byte[length / 2];
				for (int i = 0; i < length; i += 2)
				{
					array[i / 2] = Convert.ToByte(string_0.Substring(i, 2), 16);
				}
				result = array;
			}
			catch
			{
				MessageBox.Show("The session has ended, open program again.");
				Environment.Exit(0);
				result = null;
			}
			return result;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005E90 File Offset: 0x00004090
		public static string encrypt_string(string string_0, byte[] byte_0, byte[] byte_1)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = byte_0;
			aes.IV = byte_1;
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ICryptoTransform cryptoTransform = aes.CreateEncryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
					{
						byte[] bytes = Encoding.Default.GetBytes(string_0);
						cryptoStream.Write(bytes, 0, bytes.Length);
						cryptoStream.FlushFinalBlock();
						byte[] byte_2 = memoryStream.ToArray();
						result = encryption.byte_arr_to_str(byte_2);
					}
				}
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005F4C File Offset: 0x0000414C
		public static string decrypt_string(string string_0, byte[] byte_0, byte[] byte_1)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = byte_0;
			aes.IV = byte_1;
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ICryptoTransform cryptoTransform = aes.CreateDecryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
					{
						byte[] array = encryption.str_to_byte_arr(string_0);
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.FlushFinalBlock();
						byte[] array2 = memoryStream.ToArray();
						@string = Encoding.Default.GetString(array2, 0, array2.Length);
					}
				}
			}
			return @string;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000600C File Offset: 0x0000420C
		public static string iv_key()
		{
			return Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-", StringComparison.Ordinal));
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002423 File Offset: 0x00000623
		public static string sha256(string string_0)
		{
			return encryption.byte_arr_to_str(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(string_0)));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00006050 File Offset: 0x00004250
		public static string encrypt(string string_0, string string_1, string string_2)
		{
			byte[] bytes = Encoding.Default.GetBytes(encryption.sha256(string_1).Substring(0, 32));
			byte[] bytes2 = Encoding.Default.GetBytes(encryption.sha256(string_2).Substring(0, 16));
			return encryption.encrypt_string(string_0, bytes, bytes2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000609C File Offset: 0x0000429C
		public static string decrypt(string string_0, string string_1, string string_2)
		{
			byte[] bytes = Encoding.Default.GetBytes(encryption.sha256(string_1).Substring(0, 32));
			byte[] bytes2 = Encoding.Default.GetBytes(encryption.sha256(string_2).Substring(0, 16));
			return encryption.decrypt_string(string_0, bytes, bytes2);
		}
	}
}
