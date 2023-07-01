using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace data._test.git.srv_.gitlab.projects.add
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void gitLabCreatePrj()
		{
			Debug.WriteLine(
				nilnul.dev.git.svr_.gitlab.projects.Add.ByPrivateToken_useWebRequest(
					user.PrivateToken.MyToken
					,
		//			"t.app_." + Guid.NewGuid()
					"t.ap_.x"// + Guid.NewGuid()
				)
			);

		}

	}
}
