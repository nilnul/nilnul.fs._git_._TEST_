using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs.git._test.module.stage.add
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void mdule_stage_Add()
		{
			nilnul.fs.git.module.stage._AddX._ExeWholeWork(Cfg.current);
		}
	}
}
