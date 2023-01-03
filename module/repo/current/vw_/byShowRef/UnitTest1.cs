using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.module.repo.current.vw_.byShowRef
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var modules = module_.various.UnitTest1.Addresses();

			modules.Each(
				m =>
				{
					nilnul.fs.folder.explore_._ByExeSelfX.OfAddress(m);
					try
					{
						var r = nilnul.fs.git.module.repo.current_.reified.snap.vw_._ShowRefX.Txt(m);
						Debug.WriteLine(r);
					}
					catch (Exception e)
					{
						Debug.WriteLine(e);
					}
				}
			);
		}
	}
}