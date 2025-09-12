/***********************************************************************************
* File:         JsonBugLiteManager.cs                                              *
* Contents:     Class JsonBugLiteManager                                           *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 12:17                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;
using BugLite.Library.Gui.Dialogs;

namespace BugLite.Library.Management
{
	public class JsonBugLiteManager : IBugLiteManager
	{
		#region Singletonium
		private static readonly Lazy<JsonBugLiteManager> _instance = new Lazy<JsonBugLiteManager>(() => new JsonBugLiteManager());
		public static JsonBugLiteManager Instance => _instance.Value;
		private JsonBugLiteManager() 
		{

		}
		#endregion

		public string ProjectPath	{get;set;} = "";

		public Project CurrentProject	{get;set;} = null;


		/// <summary>
		/// TODO: In V2 (Multi-Project)
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		public void AddProject()
		{
			// throw new NotImplementedException();
		}

		/// <summary>
		/// TODO: In V2 (Multi-Project)
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		public void EditProject()
		{
			// throw new NotImplementedException();
		}

		/// <summary>
		/// TODO: In V2 (Multi-Project)
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		public void DeleteProject()
		{
			// throw new NotImplementedException();
		}

		public void LoadProject(string fileName)
		{
			try
			{
				using (StreamReader reader = new StreamReader(fileName))
				{
					string json = reader.ReadToEnd();
					this.CurrentProject	= Project.FromJson(json);;
				}
			}
			catch (Exception)
			{
			}
		}

		public void SaveProject(string fileName)
		{
			using (StreamWriter writer = new StreamWriter(fileName))
			{
				string json = this.CurrentProject.ToJson();

				writer.Write(json);
			}
		}

		/// <summary>
		/// Adds a new issue to the current project
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		public void AddIssue()
		{
			if (this.CurrentProject == null)
			{
				throw new NullReferenceException("Current Project not defined");
			}

			IssueDialog dialog	= new IssueDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Issue issue		= dialog.Issue;

				if (this.CurrentProject.Issues.Count == 0)
				{
					issue.IssueId	= 1;
				}
				else
				{
					issue.IssueId	= this.CurrentProject.Issues.Max(kvp => kvp.Key) + 1;
				}

				this.CurrentProject.Issues.Add(issue.IssueId, issue);
				this.SaveProject(this.ProjectPath);
			}
		}

		public void ReplaceIssue(Issue issue)
		{
			if (this.CurrentProject.Issues.ContainsKey(issue.IssueId))
			{
				this.CurrentProject.Issues[issue.IssueId]	= issue;
				this.SaveProject(this.ProjectPath);
			}
		}

		public void DeleteIssue(int issueId)
		{
			if (this.CurrentProject.Issues.ContainsKey(issueId))
			{
				this.CurrentProject.Issues.Remove(issueId);
				this.SaveProject(this.ProjectPath);
			}
		}
	}
}
