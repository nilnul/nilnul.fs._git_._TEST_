using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;

namespace nilnul.fs._git_._TEST_.svr_.azure.client.teamwork.repo.snps
{
	[TestClass]
	public class UnitTest1
	{
		public List<Commit> GetCommits(IList<WorkItem> list)
		{
			(GitRepository repository, VssConnection connection) = GetRepository();
			List<GitCommitRef> gitCommitRefs = connection.GetClient<GitHttpClient>().GetCommitsAsync(repository.Id, new GitQueryCommitsCriteria { ItemVersion = new GitVersionDescriptor { Version = ConfigurationFile.DevBranch } }).Result;
			List<GitCommitRef> filtered = gitCommitRefs.Where(commit => list.Any(item => commit.Comment.Contains("#" + item.Id.ToString()))).ToList();
			filtered.ForEach(item => filteredCommits.Add(new Commit { CommitId = item.CommitId.Substring(0, 7), CommitComment = item.Comment, Author = item.Author.Name }));
			filtered.Reverse();
			CreateLocalReleaseBranch(repository, connection, filtered);
			return filteredCommits;
		}

		public void CreateLocalReleaseBranch(GitRepository repository, VssConnection connection, List<GitCommitRef> commits)
		{
			GitHttpClient gitClient = connection.GetClient<GitHttpClient>();
			GitAsyncRefOperationParameters cherryPickToCreate = new GitAsyncRefOperationParameters { GeneratedRefName = "refs/heads/feature/mostafa-utility-test", OntoRefName = "refs/heads/master", Repository = repository, Source = new GitAsyncRefOperationSource { CommitList = commits.ToArray() } };
			var result = gitClient.CreateCherryPickAsync(cherryPickToCreate, projectName, repoName).GetAwaiter().GetResult();
		}

		[TestMethod]
		public void TestMethod1()
		{
		}
	}
}
