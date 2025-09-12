/***********************************************************************************
* File:         Issue.cs                                                           *
* Contents:     Class Issue                                                        *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 09:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain.Enumerations;

namespace BugLite.Library.Domain
{
	/// <summary>
	/// Describes a single issue.
	/// LeanCore version.
	/// </summary>
	public class Issue
	{
		#region Properties
		/// <summary>
		/// The ID of the issue.
		/// </summary>
		public int IssueId	{get;set;}	= 0;

		/// <summary>
		/// The ID of the project.
		/// </summary>
		public int ProjectId	{get;set;}	= 0;

		/// <summary>
		/// Short description
		/// </summary>
		public string Title	{get;set;}	= "";

		/// <summary>
		/// Notes (single text field can double as description + notes at first).
		/// </summary>
		public string Details	{get;set;}	= "";

		/// <summary>
		/// Date/Time of first submittance.
		/// </summary>
		public DateTime SubmittedOn	{get;set;} = DateTime.Now;

		public IssueStatus	Status	{get;set;}	= IssueStatus.Open;

		/// <summary>
		/// Date/Time of last submittance.
		/// </summary>
        public DateTime LastUpdated	{get;set;} = DateTime.Now;
		#endregion	
	}
}