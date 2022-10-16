using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs.git._test.module.repo.branches.add_.orphan
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void addOrphanBranch()
		{

			nilnul.fs.git.module.repo.branches.add_.NoHistory._Exe(

				@"E:\170203\data(app_\hbue.audit\_web"
				,
				"sidebar"

			);
		}
	}
}
