using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace wyt.data._test.git.srv_.vs.work.get
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Vs_Work__get()
		{
 
			var r= nilnul.dev.git.svr_.vs.work.Get.ExeAsync( 
				wyt.data._test.git.srv_.vs.UnitTest1.account
				,
				
			wyt.data._test.git.srv_.vs.UnitTest1.token
			
				
				).Result;

			Debug.WriteLine(r);

		}
	}
}
