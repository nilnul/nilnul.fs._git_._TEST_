using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;




using Microsoft.TeamFoundation.Core.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.Operations;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.svr_.azure.client.teamwork.create_.viaLib.viaWrapper
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// after more than 30 seconds, success.
		/// </summary>
		[TestMethod]
		public void TestMethod1()
		{
			

			var prjName = $@"t{nilnul.time_.datetime._lex_.phrase_.yr_.decimalSubsecond_.seP_.Lower.Singleton.phraseUseLetter(
				DateTimeOffset.Now
			)}";

			prjName = "w0819";
			var prj=nilnul.fs.git.svr_.azure.client.teamwork.create_._ByMsLibX.Create(prjName);

			Debug.WriteLine(prj.Name);
			
			Debug.WriteLine(prj);

		}
	}
}


