using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.fs._git_._TEST_.module_.t
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
		}

		static public string CreateTmp() {
			var t = nilnul.fs.folder_.tmp.dir._CreateX.Address("gitModule");
			nilnul.fs.git._module._IniX1.Ini(t);
			return t;
		}
	}
}
