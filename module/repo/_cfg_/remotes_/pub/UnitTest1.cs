using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul.fs._git_._TEST_.module.repo._cfg_.remotes_.pub
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var moduleAddress = @"D:\170203\data\_nilnul_\_LIB_(Git";

			var repoSvcS = new nilnul.fs.git.svr.client.RepoI[] {
				new nilnul.fs.git.svr_.github.client_.vaulted_.orged.Repo4pub(
					new git.svr_.github.client_.vaulted_.ForOrg(
						"header"
						,
						"wangyoutian"
						,
						"nilnul"
					)
				)
				,
				new nilnul.fs.git.svr_.azure.client_.vaulted.Repo4pub(
					new git.svr_.azure.client_.Vaulted(
						"nilnul"
					)
				)

			};

			var schema = fs.git.module.repo.branch_._pub.Settings1.Schema;

			var schemaTyped = schema.Cast<string>().Select(
				s => nilnul.txt_.vered_._id.Nom.CreateByAppending_ofId(s)
			).ToArray();

			var clientsPub = new git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs(
					new git.svr.client.repo.sortie_.ByHost(repoSvcS)
					,
					new[] { "github", "azure" }.Select(
						n =>
						(new[] { n }).Concat(new[] { "nilnul" })
					)
				//new txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.started.sortie_.Caseless(
				//	schemaTyped
				//)
			);


			var remotesEnsure = new nilnul.fs.git.module.repo._cfg_.remotes_.Pub(
				clientsPub
			);

			remotesEnsure.ensureRemotes(
				moduleAddress
				,
				"_nilnul_._LIB_"
			);
		}
	}
}
