using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svR_.gitlab.url.snug.polish
{
	public class UnitTest1
	{
		static public void M(string module, string remote)
		{
			

			//get the url.

			var urn = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(
				module, remote
			);


			var url = nilnul.web.url_.SchemedNodewise.Parse(urn);


			const string ending = ".git";

			var repoName = url.nodewise.resource0nul.render.route.division.denotes.Last().ToString();
			nilnul.bit.vow_.True1.Vow(
				repoName.EndsWith(".git")
			);

			repoName = repoName.Substring(0, repoName.Length - ending.Length);

			if (fs.git.svr_.gitlab.repo._name.txt.Be.Singleton.be(repoName))
			{
				return;
			}
				var newRepoName = fs.git.svr_.gitlab.repo._NameX.Encode(repoName);

			var newUrl = urn.Replace(repoName, newRepoName);

	

			fs.git.module.repo._cfg_.remote.url._AssignX.ByRemoteCmd(
				module
				,
				remote
				,
				newUrl
			);




		}
	}
}
