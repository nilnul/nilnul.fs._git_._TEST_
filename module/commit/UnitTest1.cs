using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs.git._test.module.commit
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void module_commit()
		{
			nilnul.fs.git.module.Commit.Exe(Cfg.current, "changing to passAround with  SideBar Content under ");
		}
	}
}
