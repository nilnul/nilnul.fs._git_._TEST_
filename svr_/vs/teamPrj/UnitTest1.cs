using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Diagnostics;

namespace nilnul.data._test.git.srv_.vs.teamPrj
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void createTeam()
		{
			_createTeam().Wait();

		}


		public async Task _createTeam()
		{
			var token = "ha";
			try
			{
				var username = string.Empty;    // "2";
				var password = token;   // "password";
				var account = "2";

				var apiVer20 = "2.0-preview";

				var apiVer10 = "1.0";

				var gitNewUrl = $"https://{account}.visualstudio.com/DefaultCollection/_apis/projects?api-version={apiVer10}";

				using (HttpClient client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(
						new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
						Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password))));


					var repoName = "_test_WebApi" + Guid.NewGuid().ToString().Replace("-", "");

					var postData = $@"{{
			  ""name"": ""{repoName}"",
			  ""project"": {{
							""id"": ""{ Guid.NewGuid()}""
						}}
					}}
			";


					var postObject = new
					{
						name = repoName
							,
						project =
						new { id = Guid.NewGuid() }
					};

					var postObject1 = new

					{
						name = "FabrikamTravel",
						description = "Frabrikam travel app for Windows Phone",
						capabilities = new
						{
							versioncontrol = new
							{
								sourceControlType = "Git"

							},
							processTemplate = new
							{
								templateTypeId = "6b724908-ef14-45cf-84f8-768b5384da45"

							}
						}

					};

					//byte[] byteArray = Encoding.UTF8.GetBytes(postData);

					//client.ContentLength = byteArray.Length;
					//// Get the request stream.
					//System.IO.Stream dataStream = request.GetRequestStream();
					//// Write the data to the request stream.
					//dataStream.Write(byteArray, 0, byteArray.Length);
					// Close the Stream object.
					//dataStream.Close();

					using (HttpResponseMessage response = client.PostAsJsonAsync(
								gitNewUrl, postObject1).Result)
					{
						response.EnsureSuccessStatusCode();
						string responseBody = await response.Content.ReadAsStringAsync();

						Debug.WriteLine(responseBody);
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

	}
}
