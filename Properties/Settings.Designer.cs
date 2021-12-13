using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LunaTokenGenV2.Properties
{
	// Token: 0x02000032 RID: 50
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00014918 File Offset: 0x00012B18
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00002815 File Offset: 0x00000A15
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002827 File Offset: 0x00000A27
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool Topmost1
		{
			get
			{
				return (bool)this["Topmost1"];
			}
			set
			{
				this["Topmost1"] = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000283A File Offset: 0x00000A3A
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000284C File Offset: 0x00000A4C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool TopmostSetting
		{
			get
			{
				return (bool)this["TopmostSetting"];
			}
			set
			{
				this["TopmostSetting"] = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0001492C File Offset: 0x00012B2C
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000285F File Offset: 0x00000A5F
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string Totalgenlog
		{
			get
			{
				return (string)this["Totalgenlog"];
			}
			set
			{
				this["Totalgenlog"] = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0001494C File Offset: 0x00012B4C
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000286D File Offset: 0x00000A6D
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string Validgentoken
		{
			get
			{
				return (string)this["Validgentoken"];
			}
			set
			{
				this["Validgentoken"] = value;
			}
		}

		// Token: 0x0400018F RID: 399
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
