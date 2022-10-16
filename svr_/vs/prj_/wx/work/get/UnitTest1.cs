using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.data._test.git.srv_.vs.prj_.wx.work.get
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Vx_Work__get()
		{
			var prj ="wx";

			var r= nilnul.dev.git.svr_.vs.prj.work.Get.ExeAsync( 
				w.data._test.git.srv_.vs.UnitTest1.account
				,
				prj
				,
			nilnul.data._test.git.srv_.vs.UnitTest1.token
			
				
				).Result;

			Debug.WriteLine(r);

		}
	}
}
