using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.fs._git_._TEST_.svr.client.names.lex_.xml
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var repos=  new nilnul.fs.git.svr.client_.accVaulted.Nameds();

			XmlSerializer lexer = new XmlSerializer(
				typeof(nilnul.fs.git.svr.client_.accVaulted.Nameds)
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

			var parsed = (nilnul.fs.git.svr.client_.accVaulted.Nameds) lexer.Deserialize(new StringReader(xml));

			Debugger.Break();




		}
	}
}
