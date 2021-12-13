using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace LunaTokenGenV2
{
	// Token: 0x0200000D RID: 13
	public class json_wrapper
	{
		// Token: 0x0600008D RID: 141 RVA: 0x0000243F File Offset: 0x0000063F
		public static bool is_serializable(Type type_0)
		{
			return type_0.IsSerializable || type_0.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000060E8 File Offset: 0x000042E8
		public json_wrapper(object object_0)
		{
			this.current_object = object_0;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000613C File Offset: 0x0000433C
		public object string_to_object(string string_0)
		{
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000245D File Offset: 0x0000065D
		public T string_to_generic<T>(string string_0)
		{
			return (T)((object)this.string_to_object(string_0));
		}

		// Token: 0x04000046 RID: 70
		private DataContractJsonSerializer serializer;

		// Token: 0x04000047 RID: 71
		private object current_object;
	}
}
