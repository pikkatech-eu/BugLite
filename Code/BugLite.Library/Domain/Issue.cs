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
		public int			IssueId	{get;set;}	= 0;

		/// <summary>
		/// Short description
		/// </summary>
		public string		Title	{get;set;}	= "";

		/// <summary>
		/// Notes (single text field can double as description + notes at first).
		/// </summary>
		public string		Details	{get;set;}	= "";

		/// <summary>
		/// Date/Time of first submittance.
		/// </summary>
		public DateTime		SubmittedOn	{get;set;} = DateTime.Now;

		/// <summary>
		/// Date/Time of last submittance.
		/// </summary>
        public DateTime		LastUpdated	{get;set;} = DateTime.Now;

		/// <summary>
		/// The status of the issue.
		/// </summary>
		public IssueStatus	Status	{get;set;}	= IssueStatus.Open;

		public Severity		Severity	{get;set;}	= Severity.Major;

		public Priority		Priority	{get;set;}	= Priority.Normal;



		/// <summary>
		/// Optional description how to reproduce the issue. 
		/// </summary>
		public string		StepsToReproduce	{get;set;}	= "";

		/// <summary>
		/// Optional additional information. 
		/// </summary>
		public string		AdditionalInformation		{get;set;}	= "";

		/// <summary>
		/// Optional notes.
		/// </summary>
		public List<Note>	Notes						{get;set;}	= new List<Note>();
		#endregion	
	}
}