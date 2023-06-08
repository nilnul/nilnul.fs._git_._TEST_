using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.fs._git_._TEST_.svr_.github.client.repo.create_.personal.ensure
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var acc = "ng";

			var svrRepoName = "nilnul.collection._axiomatic_._LIB_";

			var _client = new nilnul.fs.git.svr.client_.accVaulted_.Github();

			var client = new nilnul.fs.git.svr_.github.client_.Vaulted(
				"git"
				,
				acc

				
			);

			var url = nilnul.fs.git.svr_.github.client.repo.create_._PersonalX.Ensure(
				client, svrRepoName
			);


		}
	}
}
