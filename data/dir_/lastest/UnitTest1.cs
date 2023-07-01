using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Linq;

namespace nilnul.fs._git_._TEST_.data.dir_.latest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
		}

		public static string Address()
		{
			var appPath = nilnul.app_.dotnet_.dev._PathX.PrjBaseAsAddress_ofCalling();

			var div = @"_data(!Git\";

			var shield = nilnul.fs.address_.shield_.baseDiv_.divInDivision_._BaseInAddressX.Create(
				appPath, div
			);

			var dirLatest =nilnul.obj.str.to_.scalar_._MaxOrDefaultX.Max(
				nilnul.fs.folder._DirsX.Captions(shield)
				,
				d=> nilnul.time_.datetime.lex_.num_.yrInTwo_.Collapsible.Singleton.parse(d)		
				,
				System.Collections.Generic.Comparer<DateTime>.Default
			);

			var shortcutContainer = nilnul.fs.address_.shield_.based_.Child.OfContainerAddress_DirDst(shield.ToString(), dirLatest);


			var link = nilnul.obj.str.to_.scalar_._MaxOrDefaultX.Max(
				nilnul.fs.folder.docs_.ext_._LnkX.Dnts(fs.address_.shield._RegressionsX.ToShield( shortcutContainer))
				,
				d=>		nilnul.fs.file.attr_.CreateTime.Get(

					new nilnul.fs.address_.spear_.based_.Child(
						shield
						,d
					).ToString()
					
				)
						,
				System.Collections.Generic.Comparer<DateTime>.Default
			);

			if (link is null)
			{
				throw new NullReferenceException();

			}

			var linkAsAddress =  new nilnul.fs.address_.spear_.based_.Child1(
				shortcutContainer
				,
				link
			);

			var tgt = nilnul.fs.file_.shortcut._VwX.Target(linkAsAddress);

			var path = tgt.ToString();// @"C:\Users\me\Desktop\Book1.xlsx";
			return path;

		}
	}
}
