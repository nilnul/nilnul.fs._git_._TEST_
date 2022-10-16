using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs._git_._TEST_.module.top
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var module = nilnul.fs.git.Module.FroAddress(
				@"E:\103\data\t._j\presebue(Git"
			);
			var top = module.top;

		}
	}
}
