using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace wyt.data._test.git.srv_.vs.precesses.get
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void VsGetProcesses()
		{
			Debug.WriteLine(
				nilnul.dev.git.svr_.vs.processes.Get.GetListOfProcesses(
					vs.UnitTest1.account
					,
					vs.UnitTest1.token	
				)
			);

		}
	}
}
