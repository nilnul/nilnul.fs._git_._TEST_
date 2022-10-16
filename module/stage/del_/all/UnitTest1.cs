using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.fs.git._test.module.stage.del_.all
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void removeAllFromStage()
		{

			try
			{
				nilnul.fs.git.module.stage._DelX.RemoveAll(Cfg.current);

			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);

			}
		}
	}
}
