using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.WebApi;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.srv_.azure.client.repo.get_.viaLib
{
	[TestClass]
	public class UnitTest1
	{
		public GitRepository get(string org, string repo)
		{
			
			var keyName = nilnul.fs.git.svr_.azure._client._OrgX.Rsc(org);
			var personalAccessToken = nilnul.win.app_._CredManX.Get(keyName);

			 String c_collectionUri = $"https://dev.azure.com/{org}";
			String c_projectName = repo;// "MyGreatProject";
			String c_repoName = repo;// "MyRepo";

			// Interactively ask the user for credentials, caching them so the user isn't constantly prompted
			VssCredentials creds = new VssBasicCredential("", personalAccessToken.Password);// VssClientCredentials();
			

			//creds.Storage = new VssClientCredentialStorage();

			// Connect to Azure DevOps Services
			VssConnection connection = new VssConnection(new Uri(c_collectionUri), creds);

			// Get a GitHttpClient to talk to the Git endpoints
			using (GitHttpClient gitClient = connection.GetClient<GitHttpClient>())
			{
				// Get data about a specific repository
				var repoResult = gitClient.GetRepositoryAsync(c_projectName, c_repoName).Result;
				return repoResult;
			}
			
		}
		[TestMethod]
		public void TestMethod1()
		{
			var org = "";

			var result = get(org, "gitTest3");

			Debug.WriteLine(
				result.Url
			);
		}
	}
}