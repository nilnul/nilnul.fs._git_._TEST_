using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace wyt.data._test.git.srv_.vs.projects.add
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void VsCreatePrj()
		{

			Debug.WriteLine(
				nilnul.dev.git.svr_.vs.projects.add.ByWebClient_basicUser.Eval(
					"wyt2"
					,

					""
					//,"wangyoutian@msn.com"	//@msn.com"   //@msn.com
					,
					vs.UnitTest1.token
					,
					"wyt.app_.fx"

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
					"wyt2"
					,

					""
					//,"wangyoutian@msn.com"	//@msn.com"   //@msn.com
					,
					vs.UnitTest1.token
					,
					"_testTempDeletable" + nilnul.guid.X.ToTxtNoHyphen( Guid.NewGuid())

					,
					"2.0-preview"
				)
			);
		}
	}
}
