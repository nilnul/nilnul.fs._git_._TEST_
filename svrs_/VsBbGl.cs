using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.data._test.git.svrs_
{
	public class VsBbGl
	{
		static private nilnul.fs.git.svr_.VisualStudio _vs=nilnul.data._test.git.srv_.Vs.vs;

		static public nilnul.fs.git.svr_.VisualStudio vs
		{
			get { return _vs=nilnul.data._test.git.srv_.Vs.vs; }
			set { _vs=nilnul.data._test.git.srv_.Vs.vs = value; }
		}

		static private nilnul.fs.git.svr_.BitBucket _bitBucket= nilnul.data._test.git.svr_.BitBucket.Svr;

		static public nilnul.fs.git.svr_.BitBucket bitBucket
		{
			get { return _bitBucket= nilnul.data._test.git.svr_.BitBucket.Svr; }
			set { _bitBucket= value; }
		}

		static private nilnul.fs.git.svr_.Gitlab _gitlab=nilnul.data._test.git.srv_.GitLab.Svr;

		static public nilnul.fs.git.svr_.Gitlab gitlab
		{
			get { return _gitlab; }
			set { _gitlab = value; }
		}

		static public IEnumerable<string> add(string prj) {
			return new nilnul.fs.git.svrs_.vsBbGl.repos.Add(_vs,_bitBucket,_gitlab).exe(prj);
		}





	}
}
