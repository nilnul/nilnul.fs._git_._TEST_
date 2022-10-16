using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.fs._git_._TEST_.client_.github.repo.create
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var repo2create = "_test_abc";
			var client = new nilnul.fs.git.client_.Github("header");
			try
			{
				var repo = client.createRepo(
					repo2create
				).Result;
				Debug.WriteLine(repo);


			}
			catch (System.AggregateException ex)
			{
				ex.Flatten().Handle(
					e =>
					{
						if (e is Octokit.RepositoryExistsException e2)
						{
							Debug.WriteLine($"{repo2create} already exists");
							return true;
						}
						else
						{
							return false;
						}
					}
				);
			}
		}
	}
}
