using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.fs._git_._TEST_.svr.client.repo.names.lex_.json.ofDwelt
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var repos= repo.names.UnitTest1.Nom1dweltEs();
			//If a serialized class contains references to objects of other classes that are marked SerializableAttribute, those objects will also be serialized.When you use basic serialization, the versioning of objects may create problems.

			
			var xml =   JsonConvert .SerializeObject(repos);
			




			Debugger.Break();

			var parsed = (nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs) JsonConvert.DeserializeObject<nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs>(
				 xml
			);


			Debugger.Break();





		}
	}
}
