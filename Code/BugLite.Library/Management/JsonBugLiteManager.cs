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
using BugLite.Library.Gui.Interfaces;

namespace BugLite.Library.Management
{
	/// <summary>
	/// Realization of BugLite manager based upon JSON serialization.
	/// </summary>
	public class JsonBugLiteManager : IBugLiteManager
	{
		#region Singletonium
		/// <summary>
		/// Static instance of JsonBugLiteManager to expose.
		/// </summary>
		private static readonly Lazy<JsonBugLiteManager> _instance = new Lazy<JsonBugLiteManager>(() => new JsonBugLiteManager());

		/// <summary>
		/// Gets the exposed instance of JsonBugLiteManager.
		/// </summary>
		public static JsonBugLiteManager Instance => _instance.Value;

		/// <summary>
		/// Private constructor.
		/// All initialization goes here.
		/// </summary>
		private JsonBugLiteManager() 
		{

		}
		#endregion

		#region Properties
		/// <summary>
		/// The path to the project currently in work.
		/// </summary>
		public string ProjectPath	{get;set;} = "";

		/// <summary>
		/// Project currently in work.
		/// </summary>
		public Project CurrentProject	{get;set;} = null;

		/// <summary>
		/// Instance of IIssueCollectionDevice responsible for display of issues and interaction with the manager.
		/// </summary>
		public IIssueCollectionDevice	IssueCollectionDevice	{get;set;}
		#endregion

		#region Project Management
		/// <summary>
		/// Creates a new project.
		/// </summary>
		public void NewProject()
		{
			ProjectDialog dialog = new ProjectDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.CurrentProject	= dialog.Project;

				this.SaveProject(this.ProjectPath);
			}
		}

		/// <summary>
		/// Edits a selected project.
		/// </summary>
		public void EditProject()
		{
			ProjectDialog dialog	= new ProjectDialog();
			dialog.Project			= this.CurrentProject;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.CurrentProject	= dialog.Project;

				this.SaveProject(this.ProjectPath);
			}
		}

		/// <summary>
		/// Closes the current project.
		/// </summary>
		public void CloseProject()
		{
			this.CurrentProject = null;
			this.ProjectPath = "";
		}

		/// <summary>
		/// Loads a project.
		/// </summary>
		/// <param name="fileName">The name of the file to load from.</param>
		public void LoadProject(string fileName)
		{
			try
			{
				using (StreamReader reader = new StreamReader(fileName))
				{
					this.ProjectPath = fileName;
					this.CurrentProject = Project.Load(this.ProjectPath);
				}
			}
			catch (Exception)
			{
			}
		}

		/// <summary>
		/// Saves the current project.
		/// </summary>
		/// <param name="fileName">The name of the file to save to.</param>
		public void SaveProject(string fileName)
		{
			this.CurrentProject.Save(fileName);
		}
		#endregion

		#region Issue Management
		/// <summary>
		/// Adds a new issue to the current project
		/// </summary>
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

		/// <summary>
		/// Edits a selected issue.
		/// </summary>
		public void ReplaceIssue(Issue issue)
		{
			if (this.CurrentProject.Issues.ContainsKey(issue.IssueId))
			{
				this.CurrentProject.Issues[issue.IssueId]	= issue;
				this.SaveProject(this.ProjectPath);
			}
		}

		/// <summary>
		/// Delete a selected issue.
		/// </summary>
		public void DeleteIssue(int issueId)
		{
			if (this.CurrentProject.Issues.ContainsKey(issueId))
			{
				this.CurrentProject.Issues.Remove(issueId);
				this.SaveProject(this.ProjectPath);
			}
		}
		#endregion
	}
}
