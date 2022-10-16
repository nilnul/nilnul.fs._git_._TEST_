using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.svr_.vs.client.teamwork.create_.byHttp
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// bad request
		/// </summary>
		[TestMethod]
		public void TestMethod1()
		{
			var prj = $"t{nilnul.time_.datetime._lex_.phrase_.yr_.decimalSubsecond_.seP_.Lower.Singleton.phrase()}";

			var client = nilnul.fs.git.svr_.vs.Client.CreateFroVault();

			var response= new nilnul.fs.git.svr_.vs.client.prjs.add_.ByWebClient_basicUser1(
				client
			) .result_prjNameNotNormalized(
				prj
				,
				nilnul.fs.git.svr_.azure._api.Version_
				//.V6
				.V2_0
				//.V2_0_preview
			);

			Debug.WriteLine(
				response
			);


		}
	}
}
