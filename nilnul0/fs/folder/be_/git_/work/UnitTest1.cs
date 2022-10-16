using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs.folder.be_.git_.work
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var a = @"E:\170203\data\t._research_\fund_\prc_\province_\教育科学规划\year_\y15\2015年省教育科学规划课题申报通知及附件\171130).git\";

			var shiled = nilnul.fs.address_.shield_.BaseDir.FroAddress(a);

			Debug.WriteLine(
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(shiled.parent)
			);


			Debug.WriteLine(
				nilnul.fs.folder_.git_.work.be_._TopX._Be(shiled.parent)
			);

			Debug.WriteLine(
				nilnul.fs.folder.be_.git_._WorkX.Be_ofAddress(@"E:\170203\data\t._research_\fund_\prc_\province_\教育科学规划\year_\y15\2015年省教育科学规划课题申报通知及附件\171130).git\")
			);

			Debug.WriteLine(
				nilnul.fs.folder_.git_.repo.be_._BareX._Be_ofAddress(a)
			);
		}
	}
}
