using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.fs.address_.spear;
using nilnul.obj;
using System;
using System.IO;
using System.Linq;

namespace nilnul.fs._git_._TEST_.module._work_.documents.each_.large.split.checkTotal
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var module = data.UnitTest1.Address();
			var addresses = nilnul.fs.git.module._work_._DocumentsX.FileInfoS_ofAddress(
				module
			);

			var addressesInTxt = addresses.Select(a=>a.FullName).ToArray();

			var nonlinkFileEs = addressesInTxt.Where(
				p => nilnul.fs.address_.spear.be_.File.Singleton.Be1(p) /// exclude linked folder; in git, linked folder is returned
				&&
				nilnul.fs.file.be_.Nonlink.Singleton.be(p) // if its linked file: the size is disregarded, and we wouldnot split it.
			);

			var sizes=nonlinkFileEs.Where(
				p => nilnul.fs.address_.spear.be_.File.Singleton.Be1(p) /// exclude linked folder; in git, linked folder is returned
				&&
				nilnul.fs.file.be_.Nonlink.Singleton.be(p) // if its linked file: the size is disregarded, and we wouldnot split it.
			).Select(
				 t => (
					t
					,
					new FileInfo(
						t
					).Length
				)
			).ToArray();

			var sumOfSizesInOctets = sizes.Select(t => t.Length).Sum();

			var sumOfSizesInMb = sumOfSizesInOctets / 1048576 + 1;

			if (
				sumOfSizesInMb >=
				fs.git.svrs_._aagg.LimitInMbyteX.Repo
				//fs.git.module.work_.xpn_.size_.TooLargeException.SafeSizeInMoctets
			)
			{
				throw new fs.git.module.work_.xpn_.size_.TooLargeException(
					$"size({sumOfSizesInMb}Moctets) of all the documents of {module} is greater than {fs.git.module.work_.xpn_.size_.TooLargeException.SafeSizeInMoctets}Mb set by {typeof(fs.git.svrs_._aagg.LimitInMbyteX).FullName}.{nameof(fs.git.svrs_._aagg.LimitInMbyteX.Repo)}"
				);
			}

			sizes.Where(f=>f.Item2>nilnul.fs.git.module._work_.documents_.upsert._Split4largeX.InOctets)
			//nonlinkFileEs.Where()
			.Each(
				a=>
					nilnul.fs.file.split_._ThinToeX._Folder0nul_Split1drop_assumeFile_assumePositive(
						a.Item1,
					nilnul.fs.git.module._work_.documents_.upsert._Split4largeX.InOctets //.InOctets
				)
			);

		}
	}
}
