/***********************************************************************************
* File:         JsonBugLiteManager.cs                                              *
* Contents:     Class JsonBugLiteManager                                           *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 12:17                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugLite.Library.Domain;
using BugLite.Library.Gui.Dialogs;

namespace BugLite.Library.Management
{
	public class JsonBugLiteManager : IBugLiteManager
	{
		private Project _defaultProject = new Project();

		#region Singletonium
		private static readonly Lazy<JsonBugLiteManager> _instance = new Lazy<JsonBugLiteManager>(() => new JsonBugLiteManager());
		public static JsonBugLiteManager Instance => _instance.Value;
		private JsonBugLiteManager() 
		{
			this.Projects.Add(this._defaultProject);
			this.CurrentProject	= this._defaultProject;
		}
		#endregion

		public List<Project> Projects	{get;set;} = new List<Project>();


		public Project CurrentProject
		{
			get
			{
				return this._defaultProject;
			}

			set
			{
				// TODO: In V2 (Multi-Project)
			}
		}

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
			}
		}

		public void EditIssue()
		{
			throw new NotImplementedException();
		}

		public void DeleteIssue()
		{
			throw new NotImplementedException();
		}
	}
}
