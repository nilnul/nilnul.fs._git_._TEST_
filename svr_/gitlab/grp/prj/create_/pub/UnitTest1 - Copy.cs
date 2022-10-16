using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Net;

namespace nilnul.fs._git_._TEST_.srv_.gitlab.grp.prj.create_.pub
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]

		public void gitLabCreatePrj()
		{
			var token = nilnul.win.app_._CredManX.Ensure(
				"git:https://k@gitlab.com"
			);

			try
			{
				Debug.WriteLine(
					nilnul.fs.git.svr_.gitlab.grp.prj.create_._PublicX._ByWebReq_nameAssumeUnnormed(
					 "55655723"   //"nilnul"
						,
						//"nilnul.blob_._excel_._LIB_"
						"_nilnul_._LINQ_"
						,
						token.Password
					)
				);
				//throw new UnexpectedReachException();

			}
			catch (WebException e) //System.Net.WebException: 远程服务器返回错误: (400) 错误的请求。
			{

				throw;
			}

		}

	}
}
