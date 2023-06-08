using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.fs._git_._TEST_.svr_.github.client_._vaulted.vault.alter_.pass
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var usr = "ng";

			var client = new nilnul.fs.git.svr_.github.client_.Vaulted(
				"git"
				,
				
				usr
				//,"git:https://ann@github.com"
			);
			var save = true;

			var saved = nilnul.win.app_._CredManX.Prompt_keepName(
			client.vaultKey()
			,
			ref save
			//,
			//usr
			//,
			//@""
		);

			//var url = nilnul.fs.git.svr_.github.client.repo.create_._PersonalX.Ensure(
			//	client, svrRepoName
			//);


		}
	}
}
