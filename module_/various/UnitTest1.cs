using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.module_.various
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var detached = module_.born.UnitTest1.CreateTmp();
			nilnul.fs.folder.explore_._ByExeSelfX.OfAddress(detached);

			var b=fs.git.module.stow._CreateX._Branch_addressAssumeModule_assumeNub(detached, "shelf");
			Debug.WriteLine(b);


		}

		static public IEnumerable<string> Addresses()
		{
			yield return module_.unborn.UnitTest1.CreateTmpAsAddress();
			yield return module_.born.UnitTest1.CreateTmp();
			yield return module_.detached.UnitTest1.CreateTmp();

		}

	}
}
