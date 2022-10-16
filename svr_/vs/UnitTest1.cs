using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.Services.Client;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Services.WebApi;

namespace wyt.data._test.git.srv_.vs
{
	[TestClass]
	public class UnitTest1
	{
		public const string account = "wyt2";

		public const string token="ht55f7dw2xnfhb6bxsltmfgmpu7d4gdtatm2entdepxhy3ns2mga";

		[TestMethod]

		public void createNewGit()
		{
			_CreateepoGitAync().Wait();


		}
		[TestMethod]

		public void vsGetPrjs()
		{
			_GetTeamPrjsAsync().Wait();


		}

		public async Task _GetTeamPrjsAsync()
		{
			var token = "ht55f7dw2xnfhb6bxsltmfgmpu7d4gdtatm2entdepxhy3ns2mga";
			try
			{
				var username = string.Empty;    // "wyt2";
				var password = token;   // "password";
				var account = "wyt2";

				var gitNewUrl = $"https://{account}.visualstudio.com/DefaultCollection/_apis/projects?api-version=1.0";

				using (HttpClient client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(
						new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
						Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password))));

					using (HttpResponseMessage response = client.GetAsync(
								gitNewUrl).Result)
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

		public async Task _GetAllRepoGitAync()
		{
			var token = "ht55f7dw2xnfhb6bxsltmfgmpu7d4gdtatm2entdepxhy3ns2mga";
			try
			{
				var username = string.Empty;    // "wyt2";
				var password = token;   // "password";
				var account = "wyt2";

				var gitNewUrl = $"https://{account}.visualstudio.com/DefaultCollection/_apis/git/repositories?api-version=1.0";

				using (HttpClient client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(
						new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
						Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password))));

					using (HttpResponseMessage response = client.GetAsync(
								gitNewUrl).Result)
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

		public async Task _CreateepoGitAync()
		{
			var token = "ht55f7dw2xnfhb6bxsltmfgmpu7d4gdtatm2entdepxhy3ns2mga";
			try
			{
				var username = string.Empty;    // "wyt2";
				var password = token;   // "password";
				var account = "wyt2";

				var gitNewUrl = $"https://{account}.visualstudio.com/DefaultCollection/_apis/git/repositories?api-version=1.0";

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
						name = repoName
							,
						project =						new { id = Guid.NewGuid() }
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
								gitNewUrl,postObject1).Result)
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


		[TestMethod]
		public void ___________UseVsClient()
		{
			var myId = "wyt2";
			var url = $"https://{myId}.visualstudio.com/DefaultCollection/_apis/git/repositories?api-version=1.0";

			VssConnection connection = new VssConnection(new Uri(url), new VssAadCredential(string.Empty, ""));




		}
		[TestMethod]
		public void _____________TestMethod1()
		{

			HttpClient hc = new HttpClient();
			var myId = "wyt2";
			var url = $"https://{myId}.visualstudio.com/DefaultCollection/_apis/git/repositories?api-version=1.0";
			var request = WebRequest.CreateHttp(
				url
				);
			request.ContentType = "application/json";
			request.Method = System.Net.WebRequestMethods.Http.Post; // HttpMethod.Post.Method;

			var myPatToken = "";

			request.Headers.Add(

				"Authorization", "Basic " + ":" + myPatToken

				);

			var repoName = "_test_temp_webApi";

			string postData = $@"{{
			  ""name"": ""{repoName}"",
			  ""project"": {{
							""id"": ""{ Guid.NewGuid()}""
						}}
					}}
			";
			byte[] byteArray = Encoding.UTF8.GetBytes(postData);
			// Set the ContentType property of the WebRequest.
			request.ContentType = "application/json";

			request.ContentLength = byteArray.Length;
			// Get the request stream.
			System.IO.Stream dataStream = request.GetRequestStream();
			// Write the data to the request stream.
			dataStream.Write(byteArray, 0, byteArray.Length);
			// Close the Stream object.
			dataStream.Close();
			// Get the response.
			WebResponse response = request.GetResponse();

			Debug.WriteLine(((HttpWebResponse)response).StatusDescription);
			// Get the stream containing content returned by the server.
			dataStream = response.GetResponseStream();
			// Open the stream using a StreamReader for easy access.
			StreamReader reader = new StreamReader(dataStream);
			// Read the content.
			string responseFromServer = reader.ReadToEnd();
			// Display the content.
			Debug.WriteLine(responseFromServer);
			// Clean up the streams.
			reader.Close();
			dataStream.Close();
			response.Close();


			//Debug.WriteLine();







		}
	}
}
