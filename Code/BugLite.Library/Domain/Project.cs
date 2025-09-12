/***********************************************************************************
* File:         Project.cs                                                         *
* Contents:     Class Project                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 10:01                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain
{
	/// <summary>
	/// Describes an issue project.
	/// LeanCore version.
	/// </summary>
	public class Project
	{
		#region Properties
		/// <summary>
		/// The ID of the project.
		/// </summary>
		public int ProjectId	{get;set;}	= 0;

		/// <summary>
		/// The name of the project.
		/// </summary>
		public string Name	{get;set;}	= "Default";

		/// <summary>
		/// A longer description.
		/// </summary>
		public string Description	{get;set;}	= "";

		/// <summary>
		/// Date/Time of project creation.
		/// </summary>
		public DateTime SubmittedOn	{get;set;} = DateTime.Now;

		public Dictionary<int, Issue> Issues	{get;set;} = new Dictionary<int, Issue>();
		#endregion
	}
}
