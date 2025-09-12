/***********************************************************************************
* File:         IBugLiteManager.cs                                                 *
* Contents:     Interface IBugLiteManager                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 11:44                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;

namespace BugLite.Library.Management
{
	public interface IBugLiteManager
	{
		#region Properties
		/// <summary>
		/// LeanCore: auto initialized with one default project.
		/// </summary>
		List<Project>	Projects	{get;set;}

		/// <summary>
		/// Project currently in work.
		/// LeanCore: the auto initialized default project.
		/// </summary>
		Project	CurrentProject		{get;set;}
		#endregion

		#region Project Management
		/// <summary>
		/// Adds a new project.
		/// LeanCore: disabled.
		/// </summary>
		void AddProject();

		/// <summary>
		/// Edits a selected project.
		/// LeanCore: disabled.
		/// </summary>
		void EditProject();

		/// <summary>
		/// Delete a selected project.
		/// LeanCore: disabled.
		/// </summary>
		void DeleteProject();

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
		void EditIssue();

		/// <summary>
		/// Delete a selected issue.
		/// </summary>
		void DeleteIssue();
		#endregion
	}
}
