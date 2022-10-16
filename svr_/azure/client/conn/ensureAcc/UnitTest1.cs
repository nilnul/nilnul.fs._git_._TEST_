using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace nilnul.fs._git_._TEST_.srv_.azure.client.conn.ensureAcc
{
	[TestClass]
	public class UnitTest1
	{
		async Task InitAzureDevOps()
		{
			var client = nilnul.fs.git.svr_.azure.Client.CreateFroVault();
			Uri _uri = new Uri(client.spear());// new Uri("https://dev.azure.com/MyAccount/");

			var creds = new VssClientCredentials(
				new WindowsCredential(false)
				,
				new VssFederatedCredential(false)
				,
												 CredentialPromptType.PromptIfNeeded
												 );

			VssConnection vssConnection = new VssConnection(_uri, creds);
			await vssConnection.ConnectAsync();





		}

		[TestMethod]

		public void MethodName()
		{
			InitAzureDevOps().Wait();

		}
		public async void TestMethod1()
		{

			  InitAzureDevOps() ; 
		}
	}
}
