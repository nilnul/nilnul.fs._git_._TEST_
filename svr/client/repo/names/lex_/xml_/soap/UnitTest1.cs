using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.fs._git_._TEST_.svr.client.repo.names.lex_.xml_.soap
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
	[ExpectedException(typeof(System.Runtime.Serialization.SerializationException))]

		public void TestMethod1()
		{
			var repos=  new nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs();
			//If a serialized class contains references to objects of other classes that are marked SerializableAttribute, those objects will also be serialized.When you use basic serialization, the versioning of objects may create problems.

			var lexer = new SoapFormatter();

			var stream = new MemoryStream();
			
			try
			{
				

					lexer.Serialize(stream,repos);

				

			}
			catch (SerializationException e)
			{
				Trace.TraceError(e.Message);

				/*
				 System.Runtime.Serialization.SerializationException
  HResult=0x8013150C
  Message=Soap 序列化程序不支持序列化一般类型: nilnul.Objs3`1[nilnul.fs.git.svr.client.RepoI]。
  Source=System.Runtime.Serialization.Formatters.Soap
  StackTrace:
   at System.Runtime.Serialization.Formatters.Soap.ObjectWriter.Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo)
   at System.Runtime.Serialization.Formatters.Soap.ObjectWriter.Serialize(Object graph, Header[] inHeaders, SoapWriter serWriter)
   at System.Runtime.Serialization.Formatters.Soap.SoapFormatter.Serialize(Stream serializationStream, Object graph, Header[] headers)
   at System.Runtime.Serialization.Formatters.Soap.SoapFormatter.Serialize(Stream serializationStream, Object graph)
   at nilnul.fs._git_._TEST_.svr.client.repo.names.lex_.xml_.soap.UnitTest1.TestMethod1() in D:\170203\data\nilnul.fs._git_\_TEST_(Git\svr\client\repo\names\lex_\xml_\soap\UnitTest1.cs:line 38

  This exception was originally thrown at this call stack:
    [External Code]
    nilnul.fs._git_._TEST_.svr.client.repo.names.lex_.xml_.soap.UnitTest1.TestMethod1() in UnitTest1.cs
				 */
				throw;
			}

			var bytes = stream.ToArray();

			var xml = Convert.ToBase64String(bytes);



			Debugger.Break();

//. It is important to note that constructors are not called when an object is deserialized. T
			var parsed = (nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs) lexer.Deserialize(
				 new MemoryStream(
					 Convert.FromBase64String(xml)
				)
			);


			Debugger.Break();





		}
	}
}
