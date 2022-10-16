using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.IO;
//using Microsoft.VisualStudio.Services.Client;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace nilnul.data._test.git.srv_.vs.repos.get
{
	[TestClass]
	public class UnitTest1
	{
		public const string account = "t2";

		public const string token="ha";

		
		[TestMethod]

		public async Task Vs_GetReposAsync()
		{
			//var token = "ht55f7dw2xnfhb6bxsltmfgmpu7d4gdtatm2entdepxhy3ns2mga";
			try
			{
				//var username = string.Empty;    // "";
				//var password = token;   // "password";
				//var account = "t2";
				var x=await nilnul.dev.git.svr_.vs.repos.Get.GetReposAsync(account,token);

				Debug.WriteLine(x);
				
				
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

		
	}
}
