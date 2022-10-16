using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.fs._git_._TEST_.svr.client.repo.names_.dict.lex_.xml.ofDwelt
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var repos= repo.names.UnitTest1.Dict();
			//If a serialized class contains references to objects of other classes that are marked SerializableAttribute, those objects will also be serialized.When you use basic serialization, the versioning of objects may create problems.

			var githubPersonal = repos.First().Value as fs.git.svr_.github.client_.vaulted.Repo4pub;

			//var doc=githubPersonal._connection.url.nodewise.resource0nul.render.route.division.doc


			var xml =  nilnul.obj.lex_._XmlX.Serialize4xml(repos.ToList()
				
			);


			Debugger.Break();

			var parsed =nilnul.obj.lex_._XmlX.Deserialize5xml<nilnul.fs.git.svr.client_.vaulted.repo.names_.Dict>(
				 xml
			);


			Debugger.Break();





		}
	}
}
