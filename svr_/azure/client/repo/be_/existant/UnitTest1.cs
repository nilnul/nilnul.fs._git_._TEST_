using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.WebApi;
using System.Diagnostics;
//using Microsoft.TeamFoundation.Core.WebApi;

namespace nilnul.fs._git_._TEST_.srv_.azure.client.repo.be_.existant
{
	[TestClass]
	public class UnitTest1
	{
		bool be(string org,string repo)
		{
			//var org = "t";
			var keyName = nilnul.fs.git.svr_.azure._client._OrgX.Rsc(org);
			var personalAccessToken = nilnul.win.app_._CredManX.Get(keyName);

			 String c_collectionUri = $"https://dev.azure.com/{org}";
			 String c_projectName = repo;
			 String c_repoName = c_projectName;// "MyRepo";

			// Interactively ask the user for credentials, caching them so the user isn't constantly prompted
			VssCredentials creds = new VssBasicCredential("", personalAccessToken.Password);// VssClientCredentials();
			

			//creds.Storage = new VssClientCredentialStorage();

			// Connect to Azure DevOps Services
			VssConnection connection = new VssConnection(new Uri(c_collectionUri), creds);

			// Get a GitHttpClient to talk to the Git endpoints
			using (GitHttpClient gitClient = connection.GetClient<GitHttpClient>())
			{
				try
				{
				// Get data about a specific repository
				var repoResult = gitClient.GetRepositoryAsync(c_projectName, c_repoName).Result;

				}
				catch (AggregateException e)
				{
					/*
					 System.AggregateException
  HResult=0x80131500
  Message=发生一个或多个错误。
  Source=mscorlib
  StackTrace:
   at System.Threading.Tasks.Task.ThrowIfExceptional(Boolean includeTaskCanceledExceptions)
   at System.Threading.Tasks.Task`1.GetResultCore(Boolean waitCompletionNotification)
   at System.Threading.Tasks.Task`1.get_Result()
   at nilnul.fs._git_._TEST_.srv_.azure.client.repo.get_.viaLib.UnitTest1.TestMethod1() in D:\170203\data\nilnul.fs._git_\_TEST_(Git\srv_\azure\client\repo\get_\viaLib\UnitTest1.cs:line 37

  This exception was originally thrown at this call stack:
    [External Code]

Inner Exception 1:
ProjectDoesNotExistWithNameException: TF200016: The following project does not exist: MyGreatProject. Verify that the name of the project is correct and that the project exists on the specified Azure DevOps Server.

					 */
					if (
						e.InnerException is
Microsoft.TeamFoundation.Core.WebApi.ProjectDoesNotExistWithNameException

) {
						return false; //this one is hit
					}

					if (
						e.InnerException is
Microsoft.TeamFoundation.Framework.Client.ProjectDoesNotExistWithNameException

) {
						return false;
					}

					throw;
				}


			}
			return true;
		}

		[TestMethod]
		public void TestMethod1()
		{
			Debug.WriteLine(
				be("t","gitTest3888")
			);

			Debug.WriteLine(
				be("t","gitTest3")
			);

		}

	}
}