using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.fs.git._test.folder.be_.root
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void folder_be_Root()
		{
			Debug.WriteLine(
					nilnul.fs.git.folder.be_.Root.Singleton.be(
						@"C:\160803\data\nilnul.human"
					)
			);
		}
	}
}
