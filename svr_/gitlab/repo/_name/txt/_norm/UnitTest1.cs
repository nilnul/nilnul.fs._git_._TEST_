using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.svr_.gitlab.repo._name.txt._norm
{
	public class UnitTest1
	{
		static public nilnul._rel.mate_.Monogamy<string, string> __Plain2encoded;
		static public nilnul._rel.mate_.Monogamy<string, string> Plain2encoded {
			get {
				if (__Plain2encoded is null)
				{
					___UnitTest1();
				}
				return __Plain2encoded; 
			}
		}

		static  void  ___UnitTest1()
		{


			_FillDict();

			__Plain2encoded = new _rel.mate_.Monogamy<string, string>(_Plain2encoded);


		}

		static UnitTest1()
		{
			return;

			_FillDict();

			__Plain2encoded = new _rel.mate_.Monogamy<string, string>(_Plain2encoded);


		}

		static void _FillDict() {
			//return;
			Comp(
				"", ""
			);

			//return;
			Comp(
				"_", "0_0"
			);
			Comp(
				"_a", "0_a"
			);

			Comp(
				"0_", "00_0"
			);

			Comp(
				"0_a", "00_a"
			);

			Comp(
				"b_", "b_0"
			);

			Comp(
				"_0", "0_00"
			);
			Comp(
				"b_0", "b_00"
			);

			Comp(
				"__", "0_0_0"
			);

			Comp(
				"a__", "a_0_0"
			);

			Comp(
				"__b", "0_0_b"
			);

			Comp(
				"__0", "0_0_00"
			);
			Comp(
				"__b0", "0_0_b0"
			);
			Comp(
				"___", "0_0_0_0"
			);

			Comp(
				"_0__", "0_00_0_0"
			);

			Comp(
				"_000_00_0", "0_0000_000_00"
			);
			Comp(
				"a_0b00_00_0", "a_0b00_000_00"
			);

			Comp(
				"a_0b00_00_0b", "a_0b00_000_0b"
			);

			Comp(
				"0_0b00_00_0b", "00_0b00_000_0b"
			);

			Comp(
				"00_0b00_00_0b", "000_0b00_000_0b"
			);

			Comp(
				"_nilnul_", "0_nilnul_0"
			);
			Comp(
				"_nilnul_._LIB_", "0_nilnul_0.0_LIB_0"
			);
			Comp(
				"nilnul.blob_._excel_._LIB_", "nilnul.blob_0.0_excel_0.0_LIB_0"
			);



		}

		static public Dictionary<string,string>   _Plain2encoded=new Dictionary<string, string>() ;



		static public void Comp(string input , string output)
		{


			
			_Plain2encoded.Add(input, output);


			
		}
	}
}
