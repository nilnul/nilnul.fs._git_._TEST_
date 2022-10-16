using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.svr_.gitlab.repo._name.txt.norm
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			//_norm.UnitTest1.___UnitTest1();
			_norm.UnitTest1.Plain2encoded.eeByRef.ee.Each(
				kv => Comp(kv.Key,kv.Value)
			);
			return;

		



		}

		static public void Comp(string input , string output) {
			Debug.Assert(
				fs.git.svr_.gitlab.repo._NameX.Encode(input)
				==
				output
			);
		}
	}
}
