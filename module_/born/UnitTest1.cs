using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.fs._git_._TEST_.module_.born
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

		static public string CreateTmp(string key="born") {
			var t = module_.unborn.UnitTest1.CreateTmpAsAddress(key);

			nilnul.fs.git.module.stage.commit_.emptible_._MsglessX._Commit_addressAssumeModule(
				t
			);

			////create a file
			//nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(t, "commit --allow-empty --allow-empty-message --message=\"\"");


			//nilnul.win.prog_.git.run.exitCode.vow_._NilX._Vod_addressOfModule_ofArgs(t, "commit", "--allow-empty", @"-m""a""");



			return t;
		}
	}
}
