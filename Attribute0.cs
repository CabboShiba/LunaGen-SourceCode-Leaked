using System;
using System.Runtime.InteropServices;

// Token: 0x02000036 RID: 54
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
internal sealed class Attribute0 : Attribute
{
	// Token: 0x17000029 RID: 41
	// (get) Token: 0x0600014F RID: 335 RVA: 0x00002899 File Offset: 0x00000A99
	// (set) Token: 0x06000150 RID: 336 RVA: 0x000028A1 File Offset: 0x00000AA1
	public bool ApplyToMembers
	{
		get
		{
			return this.applyToMembers;
		}
		set
		{
			this.applyToMembers = value;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000151 RID: 337 RVA: 0x000028AA File Offset: 0x00000AAA
	// (set) Token: 0x06000152 RID: 338 RVA: 0x000028B2 File Offset: 0x00000AB2
	public bool Exclude
	{
		get
		{
			return this.exclude;
		}
		set
		{
			this.exclude = value;
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000153 RID: 339 RVA: 0x000028BB File Offset: 0x00000ABB
	// (set) Token: 0x06000154 RID: 340 RVA: 0x000028C3 File Offset: 0x00000AC3
	public string Feature
	{
		get
		{
			return this.feature;
		}
		set
		{
			this.feature = value;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000155 RID: 341 RVA: 0x000028CC File Offset: 0x00000ACC
	// (set) Token: 0x06000156 RID: 342 RVA: 0x000028D4 File Offset: 0x00000AD4
	public bool StripAfterObfuscation
	{
		get
		{
			return this.strip;
		}
		set
		{
			this.strip = value;
		}
	}

	// Token: 0x04000191 RID: 401
	private bool applyToMembers = true;

	// Token: 0x04000192 RID: 402
	private bool exclude = true;

	// Token: 0x04000193 RID: 403
	private bool strip = true;

	// Token: 0x04000194 RID: 404
	private string feature = "";
}
