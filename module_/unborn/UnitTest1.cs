using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.module_.unborn
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var t = CreateTmpAsAddress();

			var upserts = nilnul.fs.git.module._work_.documents_._UpsertX.Documents(
				t
			);
			upserts.ForEach(
				d=>Debug.WriteLine(d)
			);
		}

		static public string CreateTmpAsAddress(string key="unborn") {
			;
			return CreateTmpAsFolder(key).ToString();


		}

		static public Folder CreateTmpAsFolder(string key="unborn") {

			var t = nilnul.fs.folder_.tmp.denote_.ver_.next_.subIfNeed._CreateFolderX.Folder(key);
			nilnul.fs.git._module._IniX1.Ini(t);
			return t;
		}



	}
}
