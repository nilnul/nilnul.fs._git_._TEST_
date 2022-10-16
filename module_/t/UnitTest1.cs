using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.module_.t
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var t = CreateTmp();

			var upserts = nilnul.fs.git.module._work_.documents_._UpsertX.Documents(
				t
			);
			upserts.ForEach(
				d=>Debug.WriteLine(d)
			);
		}

		static public string CreateTmp() {
			var t = nilnul.fs.folder_.tmp.dir._CreateX.Address("gitModule");
			nilnul.fs.git._module._IniX1.Ini(t);
			return t;
		}
	}
}
