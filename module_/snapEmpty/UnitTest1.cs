using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.fs._git_._TEST_.module_.snapEmtpy
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			nilnul.fs.folder._ExploreX._Explore(
				CreateTmp()
			);
		}

		static public string CreateTmp() {
			var t = module_.t.UnitTest1.CreateTmp();


			//create a file
			nilnul.win.prog_.git.run.exitCode.vow_._NilX._Vod_addressOfModule_ofArgs(t, "commit", "--allow-empty", @"-m""a""");



			return t;
		}
	}
}
