using System;
using System.Windows.Forms;

namespace LunaTokenGenV2
{
	// Token: 0x02000026 RID: 38
	internal static class Program
	{
		// Token: 0x060000EC RID: 236 RVA: 0x000026A8 File Offset: 0x000008A8
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
