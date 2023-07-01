using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.srv_.gitlab.grp.prj.create
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void gitLabCreatePrj()
		{
			var token = nilnul.win.app_._CredManX.Ensure(
				"git:https://k@gitlab.com"
			);

			Debug.WriteLine(
				nilnul.fs.git.svr_.gitlab.grp.prj._CreationX._ByWebReq_nameAssumeNormalized(
				 "55655723"   //"nilnul"
					,
					"t1"
					,
					token.Password


				)
			);

		}

	}
}
