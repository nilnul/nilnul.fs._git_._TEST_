using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.fs._git_._TEST_.nilnul0.fs.git.module.stow.create.collapse
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			

			var path = data.UnitTest1.Address();
			var bakVeredKey = "key";

			var _location = path;
			var bakBranch =
					nilnul.fs.git.module.stow.create._CollapseX._Branch_addressAssumeModule_assumeShelfNub(
						_location, bakVeredKey, out bool newlyCreatedBak
						//, git
				);

			Debug.WriteLine(bakBranch);
		}
	}
}
