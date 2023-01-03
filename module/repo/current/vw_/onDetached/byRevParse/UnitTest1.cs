using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.module.repo.current.vw_.onDetached.byRevParse
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var detached = module_.detached.UnitTest1.CreateTmp();
			nilnul.fs.folder.explore_._ByExeSelfX.OfAddress(detached);

			var r=nilnul.fs.git.module.repo.current._VwX.Txt(detached);
			Debug.WriteLine(r);

			//fs.git.module.shelf._CreateX._Branch(detached, "shelf");
		}
	}
}
