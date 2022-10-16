using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.fs._git_._TEST_.svr.client.repo.names_.dict.lex_.xml
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var repos=  new nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs();

			XmlSerializer lexer = new XmlSerializer(
				typeof(nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs)
			);
			
			var xml = "";

			using (var sww = new StringWriter())
			{
				using (XmlWriter writer = XmlWriter.Create(sww))
				{
					lexer.Serialize(writer, repos);
					xml = sww.ToString(); // Your XML
				}
			}

			Debugger.Break();

			var parsed = (nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs) lexer.Deserialize(new StringReader(xml));





		}
	}
}
