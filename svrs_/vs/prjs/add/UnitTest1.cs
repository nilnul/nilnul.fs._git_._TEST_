using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace wyt.data._test.git.svrs_.vs.prjs.add
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void SvcsCreatePrj()
		{

			Debug.WriteLine(
				nilnul.dev.git.svr_.vs.projects.add.ByWebClient_basicUser.Eval(
					"w2"
					,

					""
					//,"wangyoutian@msn.com"	//@msn.com"   //@msn.com
					,
					wyt.data._test.git.srv_.vs.UnitTest1.token
					,
					"wt.ax"

					,
					"2.0-preview"
				)
			);


		}
		/// <summary>
		/// this will fail
		/// </summary>
	[TestMethod]
		public void VsCreatePrj_nameHeadedByUnderscore()
		{

			Debug.WriteLine(
				nilnul.dev.git.svr_.vs.projects.add.ByWebClient_basicUser.Eval(
					"t2"
					,

					""
					//,"wangyoutian@msn.com"	//@msn.com"   //@msn.com
					,
					wyt.data._test.git.srv_.vs.UnitTest1.token
					,
					"_testTempDeletable" + nilnul.guid.X.ToTxtNoHyphen( Guid.NewGuid())

					,
					"2.0-preview"
				)
			);
		}
	}
}
