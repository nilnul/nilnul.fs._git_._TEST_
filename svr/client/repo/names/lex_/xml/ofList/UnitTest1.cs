using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.fs._git_._TEST_.svr.client.repo.names.lex_.xml.ofList
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var repos=  new nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs();

			XmlSerializer lexer = new XmlSerializer(
				typeof(
					List<(nilnul.fs.git.svr.client.RepoI svc
						, nilnul.txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.Started nom
					)>
				)
			);
			
			var xml = "";

			using (var sww = new StringWriter())
			{
				using (XmlWriter writer = XmlWriter.Create(sww))
				{
					lexer.Serialize(writer, repos.ToList());
					xml = sww.ToString(); // Your XML
				}
			}

			Debugger.Break();

			var parsed = (
				List<(nilnul.fs.git.svr.client.RepoI svc
						, nilnul.txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.Started nom
					)>
			) lexer.Deserialize(new StringReader(xml));


			var ctored =  new nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs(parsed);

			Debugger.Break();


		}
	}
}
