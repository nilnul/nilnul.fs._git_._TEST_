using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.fs._git_._TEST_.svr_.github.client.repo.vw
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var acc = data.latest.dnt.UnitTest1.GetDnt().caption.ToString(); ///create the account where it's not pushed to remote for privacy reasons;

			var svrRepoName = "nilnul.collection._axiomatic_._LIB_";

			var client = new nilnul.fs.git.svr_.github.client_.Vaulted(
				"git"
				,
				acc
			); /// here you need to store the password in Windows Credential Manager first. Note the resource|url shall be composed accordingly to the code there; <see cref="nilnul.fs.git.svr_.github.client_.Vaulted.vaultKey"/>

			var url = nilnul.fs.git.svr_.github.client.repo._VwX.Vw(
				client.githubClient(), acc, svrRepoName
			);


		}
	}
}
