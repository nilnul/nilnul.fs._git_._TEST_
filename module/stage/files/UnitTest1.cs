using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.fs.git._test.module.stage.files
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void module_stage_files()
		{
			Debug.WriteLine(
				nilnul.fs.git.module.stage._FilesX.Show(Cfg.current)
			);
		}
	}
}
