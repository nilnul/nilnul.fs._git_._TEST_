﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.module.shelf.create_.onDetached
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var detached = module_.detached.UnitTest1.CreateTmp();
			nilnul.fs.folder.explore_._ByExeSelfX.OfAddress(detached);

			var b = fs.git.module.stow._CreateX._Branch_addressAssumeModule_assumeNub(detached, "shelf");
			Debug.WriteLine(b);


		}
	}
}
