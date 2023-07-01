using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace nilnul.fs._git_._TEST_.svr_.gitlab.usr.grps.map_.namesp.vw
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var client = new nilnul.fs.git.svr_.gitlab.client_.AccInVault("nilnul");


			var token = client.getToken();

			var r = nilnul.fs.git.svr_.gitlab.usrs_.schemas._VwNamespacesX.ToResponse(
				token
			);

			var obj=JsonConvert.DeserializeObject(r);

		

		}
	}
}
