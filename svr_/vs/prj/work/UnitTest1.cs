using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace wyt.data._test.git.srv_.vs.prj.work
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void VsAddWork()
		{
			var prj ="wyt.app_.fx";

			var work = "local path";

			var r= nilnul.dev.git.svr_.vs.prj.work.create.ByWebClient_basicUser.Create_withTitleAndDescription_v1_0_( 
				wyt.data._test.git.srv_.vs.UnitTest1.account
				,
				""
				,
			wyt.data._test.git.srv_.vs.UnitTest1.token
			,
			prj
			,"model"," for .target, .weapon, ..."
				
				);

			Debug.WriteLine(r);

		}
	}
}
