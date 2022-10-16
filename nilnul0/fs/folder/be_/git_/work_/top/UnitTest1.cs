using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs.folder.be_.git_.work_.top
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var a = @"D:\170203\data\nilnul._plant_";

			var shiled = nilnul.fs.address_.shield_.BaseDir.FroAddress(a);

			Debug.WriteLine(
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(shiled)
			);


			Debug.WriteLine(
				nilnul.fs.folder_.git_.work.be_._TopX._Be(shiled)
			);

			Debug.WriteLine(
				nilnul.fs.folder.be_.git_._WorkX.Be_ofAddress(a)
			);

			Debug.WriteLine(
				nilnul.fs.folder_.git_.repo.be_._BareX._Be_ofAddress(a)
			);
		}
	}
}
