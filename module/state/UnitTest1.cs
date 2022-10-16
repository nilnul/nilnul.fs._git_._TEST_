using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.fs.git._test.module.state
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void module_state()
		{
			Debug.WriteLine(
				nilnul.fs.git.module.State._GetStatus(_test.module.Cfg.current)
			);


		}


	}
}
