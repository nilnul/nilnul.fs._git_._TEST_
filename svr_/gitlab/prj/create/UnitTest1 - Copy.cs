using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Net;

namespace nilnul.data._test.git.srv_.gitlab.projects.add
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
					nilnul.fs.git.svr_.gitlab.client.prj._CreationX._ByWebReq_nameAssumeUnnormed(
						token.Password
						,

						"w"
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
