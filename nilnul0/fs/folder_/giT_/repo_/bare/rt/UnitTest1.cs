using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs.folder_.git_.repo_.bare.rt
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			///create a bare repo first
			///
			var f=nilnul.fs.git.repo_.bare.create_._TmpX.Folder_ofName("a");

			var size = nilnul.fs.git.repo_.bare._SizeX._Kb(f);

			Debug.WriteLine(size);
			nilnul.fs.folder.explore_._ByExeSelfX.Exe((nilnul.fs.FolderI)f);
		}
	}
}
