using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// https://www.nuget.org/packages/Microsoft.TeamFoundationServer.Client/
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;

// https://www.nuget.org/packages/Microsoft.VisualStudio.Services.InteractiveClient/
using Microsoft.VisualStudio.Services.Client;

// https://www.nuget.org/packages/Microsoft.VisualStudio.Services.Client/
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace nilnul.fs._git_._TEST_.srv_.azure.client.tracket
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			SampleREST();
		}

		/// <summary>
		/// This sample creates a new work item query for New Bugs, stores it under 'MyQueries', runs the query, and then sends the results to the console.
		/// </summary>
		public static void SampleREST()
		{
			var teamProjectName = "t220211145515s8931674";
			// Connection object could be created once per application and we use it to get httpclient objects. 
			// Httpclients have been reused between callers and threads.
			// Their lifetime has been managed by connection (we don't have to dispose them).
			// This is more robust then newing up httpclient objects directly.  

			// Be sure to send in the full collection uri, i.e. http://myserver:8080/tfs/defaultcollection
			// We are using default VssCredentials which uses NTLM against an Azure DevOps Server.  See additional provided
			// examples for creating credentials for other types of authentication.

			var client = nilnul.fs.git.svr_.azure.Client.CreateFroVault();
			VssConnection connection = client.vssConnection(); // new VssConnection(new Uri(collectionUri), new VssCredentials());

			// Create instance of WorkItemTrackingHttpClient using VssConnection
			WorkItemTrackingHttpClient witClient = connection.GetClient<WorkItemTrackingHttpClient>();

			// Get 2 levels of query hierarchy items
			List<QueryHierarchyItem> queryHierarchyItems = witClient.GetQueriesAsync(teamProjectName, depth: 2).Result;

			// Search for 'My Queries' folder
			QueryHierarchyItem myQueriesFolder = queryHierarchyItems.FirstOrDefault(qhi => qhi.Name.Equals("My Queries"));
			if (myQueriesFolder != null)
			{
				string queryName = "REST Sample";

				// See if our 'REST Sample' query already exists under 'My Queries' folder.
				QueryHierarchyItem newBugsQuery = null;
				if (myQueriesFolder.Children != null)
				{
					newBugsQuery = myQueriesFolder.Children.FirstOrDefault(qhi => qhi.Name.Equals(queryName));
				}
				if (newBugsQuery == null)
				{
					// if the 'REST Sample' query does not exist, create it.
					newBugsQuery = new QueryHierarchyItem()
					{
						Name = queryName,
						Wiql = "SELECT [System.Id],[System.WorkItemType],[System.Title],[System.AssignedTo],[System.State],[System.Tags] FROM WorkItems WHERE [System.TeamProject] = @project AND [System.WorkItemType] = 'Bug' AND [System.State] = 'New'",
						IsFolder = false
					};
					newBugsQuery = witClient.CreateQueryAsync(newBugsQuery, teamProjectName, myQueriesFolder.Name).Result;
				}

				// run the 'REST Sample' query
				WorkItemQueryResult result = witClient.QueryByIdAsync(newBugsQuery.Id).Result;

				if (result.WorkItems.Any())
				{
					int skip = 0;
					const int batchSize = 100;
					IEnumerable<WorkItemReference> workItemRefs;
					do
					{
						workItemRefs = result.WorkItems.Skip(skip).Take(batchSize);
						if (workItemRefs.Any())
						{
							// get details for each work item in the batch
							List<WorkItem> workItems = witClient.GetWorkItemsAsync(workItemRefs.Select(wir => wir.Id)).Result;
							foreach (WorkItem workItem in workItems)
							{
								// write work item to console
								Console.WriteLine("{0} {1}", workItem.Id, workItem.Fields["System.Title"]);
							}
						}
						skip += batchSize;
					}
					while (workItemRefs.Count() == batchSize);
				}
				else
				{
					Trace.WriteLine("No work items were returned from query.");
				}
			}
		}
	}
}