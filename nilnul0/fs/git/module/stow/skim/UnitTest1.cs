using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.nilnul0.fs.git.module.stow.skim
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var modules = module_.various.UnitTest1.Addresses();

			modules.Each(
				m =>
				{
					nilnul.fs.folder.explore_._ByExeSelfX.OfAddress(m);
					try
					{
						var shelf = nilnul.fs.git.module.stow._SkimX._Stow9skim_addressAssumeModule_1stowNub_2skimNub(
							m
						);
						
						Debug.WriteLine(shelf);

						var shelf1 = nilnul.fs.git.module.stow._SkimX._Stow9skim_addressAssumeModule_1stowNub_2skimNub(
							m
						);

						Debug.WriteLine(shelf1);



					}
					catch (Exception e)
					{
						Debug.WriteLine(e);
					}

				}
			);
		}
	}
}
