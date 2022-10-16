using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace nilnul.fs._git_._TEST_.srv_.azure.client_.org.repos.vw_.httpClient
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// https://docs.microsoft.com/en-us/azure/devops/integrate/rest-api-overview?view=azure-devops
		/// </summary>
		/// <param name="org"></param>
		/// <returns></returns>
		public static async Task<string> GetProjects(string org)
		{
			try
			{
				var clientAzure = nilnul.fs.git.svr_.azure.Client.CreateFroVault(org);

				var prjsClient = new nilnul.fs.git.svr_.azure.client.division_.Prjs(
					clientAzure
				);

				var personalaccesstoken = clientAzure.token;// "PAT_FROM_WEBSITE";

				using (HttpClient client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(
						new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
						Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", "", personalaccesstoken))));

					using (HttpResponseMessage response = await client.GetAsync(
						prjsClient.address()
								//"https://dev.azure.com/{organization}/_apis/projects"

								))
					{
						response.EnsureSuccessStatusCode();
						string responseBody = await response.Content.ReadAsStringAsync();
						return responseBody;
						Console.WriteLine(responseBody);
					}
				}
			}
			catch (Exception ex)
			{
				throw;
				Console.WriteLine(ex.ToString());
			}
		}

		[TestMethod]
		public void TestMethod1()
		{
			var r = GetProjects(
				nilnul.fs.git.svr_.azure._client_._OrgX.FroEnv()
				//""
			).Result;

			Debug.WriteLine(r);


		}
	}
}
