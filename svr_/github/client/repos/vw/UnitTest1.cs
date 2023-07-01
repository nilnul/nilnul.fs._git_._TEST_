using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace nilnul.fs._git_._TEST_.svr_.github.client.repos.vw
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public async Task TestMethod1()
		{
			var acc = data.latest.dnt.UnitTest1.GetDnt().caption.ToString(); ///create the account where it's not pushed to remote for privacy reasons;


			var client = new nilnul.fs.git.svr_.github.client_.Vaulted(
				"git"
				,
				acc
			); /// here you need to store the password in Windows Credential Manager first. Note the resource|url shall be composed accordingly to the code there; <see cref="nilnul.fs.git.svr_.github.client_.Vaulted.vaultKey"/>


			var repos= await client.githubClient().Repository.GetAllForCurrent();

			var r=repos.OrderByDescending(
				r=>r.CreatedAt
			).Take(50).ToArray();

			r.Each(
				x=> Debug.WriteLine(
					$"{x.Name}:{x.CreatedAt}"

				)
			);


		}
	}
}
