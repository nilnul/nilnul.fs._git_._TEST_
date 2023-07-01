using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Net;

namespace nilnul.fs._git_._TEST_.svr_.gitlab.usr_.grp.repo.create_.pub_.byWebReq_.tokenInHeader.unnormed
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var client = new nilnul.fs.git.svr_.gitlab.client_.AccInVault("nilnul");


			var token = client.getToken();

			try
			{
				Debug.WriteLine(
					nilnul.fs.git.svr_.gitlab.usr_.grp.repo.create_._PublicX._ByWebReq_1unnormed(
					 55655723   //"nilnul"
						,
						//"nilnul.blob_._excel_._LIB_"
						//"_nilnul_._LINQ_"

									@"nilnul._os_.cmd_._EXE4BAT_"

						,
						token
					)
				);
				//throw new UnexpectedReachException();

			}
			catch (WebException e) //System.Net.WebException: 远程服务器返回错误: (400) 错误的请求。
			{

				throw;
			}


			//nilnul.fs.git.svr_.gitlab.usr.repo.create_.byWebReq_._TokenInHeaderX._AsResponse_1unnormed(
			//	client.getToken()
			//	,
			//	@"nilnul._os_.cmd_._EXE4BAT_"
			//);



		}
	}
}
