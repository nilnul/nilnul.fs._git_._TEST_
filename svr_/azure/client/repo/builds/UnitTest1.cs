using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace nilnul.fs._git_._TEST_.srv_.azure.client.repo.builds
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// https://docs.microsoft.com/en-us/azure/devops/organizations/accounts/use-personal-access-tokens-to-authenticate?bc=%2Fazure%2Fdevops%2Fmarketplace-extensibility%2Fbreadcrumb%2Ftoc.json&toc=%2Fazure%2Fdevops%2Fmarketplace-extensibility%2Ftoc.json&view=azure-devops&tabs=Windows
		/// </summary>
		/// <param name="org"></param>
		/// <param name="prj"></param>
		/// <returns></returns>
		public static async Task<string> GetBuilds(string org,string prj)
		{
			try
			{
				var keyName = nilnul.fs.git.svr_.azure._client._OrgX.Rsc(org);

				var personalaccesstokenAsCred = nilnul.win.app_._CredManX.Get(keyName);
				var personalaccesstoken = personalaccesstokenAsCred.Password;// "PATFROMWEB";

				using (HttpClient client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(
					   new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
						Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", "", personalaccesstoken))));

					using (HttpResponseMessage response = client.GetAsync(
								 $"https://dev.azure.com/{org}/{prj}/_apis/build/builds?>api-version=5.0").Result)
					{
						response.EnsureSuccessStatusCode();
						string responseBody = await response.Content.ReadAsStringAsync();
						return responseBody;
						//Console.WriteLine(responseBody);
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

			var msg = GetBuilds("t", "gitTest3").Result;
			Debug.WriteLine(msg);

		}
	}
}
