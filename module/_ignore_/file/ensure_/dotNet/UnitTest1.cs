using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs._git_._TEST_.module._ignore_.file.ensure_.dotNet
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			 const string address = @"E:\170203\daa\t._finance_";
		  nilnul.fs.FolderI folder1 =  nilnul.fs.Folder.FroAddress(address);
			  string dst = "_SQL_";

			nilnul.fs.FolderI folder11 = nilnul.fs.folder_._ParentDivisionX1.CreateFolder(
						folder1, dst
					);

			nilnul.fs.folder_.tmp._LogAndShowX.LogTimedAndShow(
				nilnul.fs.git.module._ignore.apply_._DotNetX.Ensure(folder11)
				,
				('a').ToString()
			);
		}
	}
}
