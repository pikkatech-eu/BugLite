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
	/// <summary>
	/// Defines properties and featureas of a BugLite manager.
	/// </summary>
	public interface IBugLiteManager
	{
		#region Properties
		/// <summary>
		/// Project currently in work.
		/// </summary>
		Project	CurrentProject		{get;set;}

		/// <summary>
		/// The path to the project currently in work.
		/// </summary>
		string ProjectPath	{get;set;}

		/// <summary>
		/// Instance of IIssueCollectionDevice responsible for display of issues and interaction with the manager.
		/// </summary>
		IIssueCollectionDevice	IssueCollectionDevice	{get;set;}
		#endregion

		#region Project Management
		/// <summary>
		/// Creates a new project.
		/// </summary>
		void NewProject();

		/// <summary>
		/// Edits a selected project.
		/// </summary>
		void EditProject();

		/// <summary>
		/// Closes the current project.
		/// </summary>
		void CloseProject();

		/// <summary>
		/// Loads a project.
		/// </summary>
		/// <param name="fileName">The name of the file to load from.</param>
		void LoadProject(string fileName);

		/// <summary>
		/// Saves the current project.
		/// </summary>
		/// <param name="fileName">The name of the file to save to.</param>
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
