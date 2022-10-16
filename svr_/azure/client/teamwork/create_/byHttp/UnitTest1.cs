using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.svr_.azure.client.teamwork.create_.byHttp
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var prj = $"t{nilnul.time_.datetime._lex_.phrase_.yr_.decimalSubsecond_.seP_.Lower.Singleton.phrase()}";

			var client = nilnul.fs.git.svr_.azure.Client.CreateFroVault();

			var response=nilnul.fs.git.svr_.azure.client.teamwork.create_._PrjDefaultX.Ret(client, prj, nilnul.fs.git.svr_.azure._api.Version_.V2_0_preview);

			Debug.WriteLine(
				response
			);


		}
	}
}
