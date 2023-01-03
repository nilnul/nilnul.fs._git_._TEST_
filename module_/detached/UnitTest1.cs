using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.fs._git_._TEST_.module_.detached
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

		static public string CreateTmp(string key="detached") {

			var t = module_.born.UnitTest1.CreateTmp(key);


			nilnul.fs.git.module.repo.current._DetachX._Detach_addressAssumeModule(
				t
			);



			return t;
		}
	}
}
