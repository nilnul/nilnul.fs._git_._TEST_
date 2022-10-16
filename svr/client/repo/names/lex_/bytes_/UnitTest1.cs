using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.fs._git_._TEST_.svr.client.repo.names.lex_.bits
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var repos=  new nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs();
			//If a serialized class contains references to objects of other classes that are marked SerializableAttribute, those objects will also be serialized.When you use basic serialization, the versioning of objects may create problems.

			var lexer = new BinaryFormatter();

			var stream = new MemoryStream();
			
			var xml = "";
			try
			{
				

					lexer.Serialize(stream,repos);

				

			}
			catch (SerializationException e)
			{
				Trace.TraceError(e.Message);
				throw;
			}

			var bytes = stream.ToArray();




			Debugger.Break();

			var parsed = (nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs) lexer.Deserialize(
				 new MemoryStream(bytes)
			);


			Debugger.Break();





		}
	}
}
