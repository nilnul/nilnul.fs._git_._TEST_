using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.fs.git._test.module.cfg.ignore
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void showGlobalIgnoreFileAddress()
		{
			Debug.WriteLine(
				nilnul.fs.git.module.cfg.Ignore.GetGlobalIgnoreFileAddress_ofAddress(
					@"E:\170203\data\nilnul.fs"
				)
			);
		}
	}
}
