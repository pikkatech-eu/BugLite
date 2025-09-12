/***********************************************************************************
* File:         IBugLiteManager.cs                                                 *
* Contents:     Interface IBugLiteManager                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 11:44                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;
using BugLite.Library.Gui.Interfaces;

namespace BugLite.Library.Management
{
	public interface IBugLiteManager
	{
		#region Properties
		/// <summary>
		/// Project currently in work.
		/// LeanCore: the auto initialized default project.
		/// </summary>
		Project	CurrentProject		{get;set;}

		string ProjectPath	{get;set;}

		IIssueCollectionDevice	IssueCollectionDevice	{get;set;}
		#endregion

		#region Project Management
		/// <summary>
		/// Adds a new project.
		/// LeanCore: disabled.
		/// </summary>
		void NewProject();

		/// <summary>
		/// Edits a selected project.
		/// LeanCore: disabled.
		/// </summary>
		void EditProject();

		/// <summary>
		/// Delete a selected project.
		/// LeanCore: disabled.
		/// </summary>
		void CloseProject();

		void LoadProject(string fileName);
		void SaveProject(string fileName);
		#endregion

		#region Issue Management
		/// <summary>
		/// Adds a new issue to the current project.
		/// </summary>
		void AddIssue();

		/// <summary>
		/// Edits a selected issue.
		/// </summary>
		void ReplaceIssue(Issue issue);

		/// <summary>
		/// Delete a selected issue.
		/// </summary>
		void DeleteIssue(int issueId);
		#endregion
	}
}
