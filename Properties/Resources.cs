using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace LunaTokenGenV2.Properties
{
	// Token: 0x02000031 RID: 49
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	internal class Resources
	{
		// Token: 0x0600013B RID: 315 RVA: 0x000022E9 File Offset: 0x000004E9
		internal Resources()
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000148A0 File Offset: 0x00012AA0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("LunaTokenGenV2.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000148E0 File Offset: 0x00012AE0
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000280D File Offset: 0x00000A0D
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000148F4 File Offset: 0x00012AF4
		internal static string d
		{
			get
			{
				return Resources.ResourceManager.GetString("d", Resources.resourceCulture);
			}
		}

		// Token: 0x0400018D RID: 397
		private static ResourceManager resourceMan;

		// Token: 0x0400018E RID: 398
		private static CultureInfo resourceCulture;
	}
}
