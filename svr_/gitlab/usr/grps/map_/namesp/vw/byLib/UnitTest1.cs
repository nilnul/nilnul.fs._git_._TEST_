using GitLabApiClient;
using Microsoft.TeamFoundation.Client.Reporting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.fs._git_._TEST_.svr_.gitlab.usr.grps.map_.namesp.vw.byLib
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public  void TestMethod1()
		{
			var grp = "nilnul";
			var client = new nilnul.fs.git.svr_.gitlab.client_.AccInVault(grp);

			var token = client.getToken();

			var lib = new GitLabClient(

				nilnul.fs.git.svr_.gitlab._ApiX.SPEAR
				,
				token
			);

			var searched= lib.Groups.SearchAsync(grp).Result;

			var id=searched.Where(x=>x.Name==grp).Single().Id;
			Debug.WriteLine(id);
			



		}
	}
}
