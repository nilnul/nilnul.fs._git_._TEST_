using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.fs._git_._TEST_.nilnul0.fs.folder_.giT_.work_.nontop.dir_.link_.sym.category
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{


			var base0container = nilnul.fs.folder_.tmp.denote_.ver_.next._CreateFolderX.Folder_ofVered(
				"gitSymlink"
			);

			var containerVered = new nilnul.fs.folder.dnt_.Vereds(
				base0container
			);

			var child4top = new nilnul.fs.folder.dnt_.Vereds(
				base0container
			).createNextDir(
				"actualModule"
			);

			nilnul.fs.folder.git_.Init.Vod(child4top);

			#region dir_sym_newTop

			var child4SymModuleSuper = containerVered.createNextDir("symModuleSuper");

			nilnul.fs.folder.git_.Init.Vod(child4SymModuleSuper);

			var symModule = new nilnul.fs.folder.dnt_.Vereds(
				new nilnul.fs.Folder(
					child4SymModuleSuper
				)
			).getNextDst(
				"symModule"
			);

			nilnul.fs.folder.dir_.link_.sym.create_._TargetShortcutX.Create_ofFolder_dirOfDst_ofTgt(
				child4SymModuleSuper
				,
				symModule
				,
				child4top
			);
			#endregion

			#region dir_workNontop / symAsModule

			var symSuperPlainChild = new nilnul.fs.folder.dnt_.Vereds(
				child4SymModuleSuper
			).createNextDir(
				"work_nontop"
			);
			var dir_worknontop__symAsModule = new nilnul.fs.folder.dnt_.Vereds(
				new nilnul.fs.Folder(
					child4SymModuleSuper
				)
			).getNextDst(
				"directoryDir_symModule"
			);


			nilnul.fs.folder.dir_.link_.sym.create_._TargetShortcutX.Create_ofFolder_dirOfDst_ofTgt(
				symSuperPlainChild
				,
				dir_worknontop__symAsModule
				,
				child4top
			);


			#endregion

			var workNontop = @"D:\170203\data\t.hbue.course_\site_\y21s(Git\exam\fed\score\regularized\_archived_";

			workNontop =symSuperPlainChild.FullName;

			nilnul.fs.folder._ExploreX.Explore(
				base0container
			);

			var dirs = nilnul.fs.git.module._work_.directory._DirsX.Addresses_ofAddress(
				workNontop
			).ToArray();

			dirs.Each(
				d =>
				{
					var category = nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(d);
					Debug.WriteLine($"{d} is {category}");

					switch (category)
					{
						case folder.categorize_.git_._plainWorkRepo.Ret.Plain:
							break;
						case folder.categorize_.git_._plainWorkRepo.Ret.Work:
							if (nilnul.fs.folder_.git_.work.be_._TopX.__Be_ofAddress(d))
							{
								Debug.WriteLine($" ---top");
							}
							else
							{
								///link, if work_top, is shown work_.nontop.
								Debug.WriteLine($"---nontop");
							}
							break;
						case folder.categorize_.git_._plainWorkRepo.Ret.Repo:
							break;
						default:
							break;
					}
				}
				);
		}
	}
}
