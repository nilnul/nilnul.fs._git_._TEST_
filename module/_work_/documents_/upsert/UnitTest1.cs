using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.module._work_.documents_.upsert
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var t = CreateTmp();

			nilnul.fs.folder._ExploreX._Explore(
				t
			);

			var upserts = nilnul.fs.git.module._work_.documents_._UpsertX.Documents(
	t
);
			upserts.ForEach(
				d => Debug.WriteLine(d)
			);
		}

		static public string CreateTmp()
		{
			var t = module_.born.UnitTest1.CreateTmp();


			//create a file
			System.IO.File.CreateText(
				nilnul.fs.folder.dnt_.mainVered_.minVer_.Next.OvAddress(t).address("a.txt")
			);

			nilnul.win.prog_.git.run.exitCode.vow_._NilX._Vod_addressOfModule_ofArgs(t,
				"checkout"
				,
				"@"
			//"HEAD"
			);



			return t;
		}
	}
}
