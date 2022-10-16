using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// https://www.nuget.org/packages/Microsoft.TeamFoundationServer.Client/
//using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
//using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;

// https://www.nuget.org/packages/Microsoft.VisualStudio.Services.InteractiveClient/
//using Microsoft.VisualStudio.Services.Client;

// https://www.nuget.org/packages/Microsoft.VisualStudio.Services.Client/
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.srv_.azure.client_.orgt.repos
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// https://docs.microsoft.com/en-us/azure/devops/integrate/get-started/rest/samples?view=azure-devops
		/// </summary>
		[TestMethod]
		public void TestMethod1()
		{
			var orgName = "";

			var url = nilnul.fs.git.svr_.azure._client._OrgX.Spear(orgName);

			var keyName = nilnul.fs.git.svr_.azure._client._OrgX.Rsc(orgName);// "git:https://dev.azure.com/t";

			var personalAccessToken=nilnul.win.app_._CredManX.Get(keyName);



			//encode your personal access token                   
			string credentials = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "", personalAccessToken.Password)));

			

			//use the httpclient
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri($"https://dev.azure.com/{orgName}/");  //url of your organization
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

				//connect to the REST endpoint            
				HttpResponseMessage response = client.GetAsync("_apis/projects?stateFilter=All&api-version=1.0").Result;

				//check to see if we have a successful response
				if (response.IsSuccessStatusCode)
				{
					//set the viewmodel from the content in the response
					var viewModel = response.Content.ReadAsStringAsync().Result;
					Debug.Write(viewModel);

					//var value = response.Content.ReadAsStringAsync().Result;
				}
			}

		}
	}
}
