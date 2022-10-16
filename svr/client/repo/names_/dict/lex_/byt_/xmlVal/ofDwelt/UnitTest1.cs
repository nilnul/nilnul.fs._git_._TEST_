using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.fs._git_._TEST_.svr.client.repo.names_.dict.lex_.bytes_.xmlVal.ofDwelt
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var repos = repo.names.UnitTest1.Dict();
			//If a serialized class contains references to objects of other classes that are marked SerializableAttribute, those objects will also be serialized.When you use basic serialization, the versioning of objects may create problems.

			var lexer = new BinaryFormatter();

			var stream = new MemoryStream();
			
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

			var xml = Convert.ToBase64String(bytes);



			Debugger.Break();

//. It is important to note that constructors are not called when an object is deserialized. T
			var parsed = (nilnul.fs.git.svr.client_.vaulted.repo.names_.Dict) lexer.Deserialize(
				 new MemoryStream(
					 Convert.FromBase64String(xml)
				)
			);


			Debugger.Break();





		}
	}
}
