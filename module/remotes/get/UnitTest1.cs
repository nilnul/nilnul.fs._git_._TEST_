using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.fs.git._test.module.remotes.get
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void module_remotes_get()
		{
			Debug.WriteLine(
				nilnul.fs.git.module.cfg.remotes.Show.GetVerboseMsg(
											@"C:\160803\data\nilnul.human"

				)
			);

		}
	}
}
