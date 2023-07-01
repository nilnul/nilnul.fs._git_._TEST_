using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.svr_.gitlab.repo._name.txt.norm.decode
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			_norm.UnitTest1.Plain2encoded.eeByRef.ee.Each(
				kv=> Comp(kv.Key	,kv.Value)
			);
			return;
			Comp(
				"",""
			);
			Comp(
				"0","0"
			);
			Comp(
				"a","a"
			);
			Comp(
				"abc","abc"
			);
			Comp(
				"0abc","0abc"
			);

			Comp(
				"abc0","abc0"
			);

			Comp(
				"0abc0","0abc0"
			);

			Comp(
				"_a","0_a"
			);
			Comp(
				"0_a","00_a"
			);
			Comp(
				"00_a","000_a"
			);
			Comp(
				"000_a","0000_a"
			);

			Comp(
				"_00_a","0_000_a"
			);
			


			Comp(
				"_","0_0"
			);

			Comp(
				"0_","00_0"
			);


			Comp(
				"b_","b_0"
			);

			Comp(
				"_0","0_00"
			);
			Comp(
				"b_0","b_00"
			);

			Comp(
				"__","0_0_0"
			);

			Comp(
				"a__","a_0_0"
			);

			Comp(
				"__b","0_0_b"
			);

			Comp(
				"__0","0_0_00"
			);
			Comp(
				"__b0","0_0_b0"
			);
			Comp(
				"___","0_0_0_0"
			);

			Comp(
				"_0__","0_00_0_0"
			);



		}

		static void Comp(string decodedExpected , string encoded) {

			//norm.UnitTest1.Comp(decodedExpected,encoded);
			//return;

			string actualDecoded = fs.git.svr_.gitlab.repo._NameX.Decode(encoded);
			Assert.IsTrue(
				actualDecoded
				==
				decodedExpected
			);
		}
	}
}
