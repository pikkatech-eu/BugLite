/***********************************************************************************
* File:         IssueStatus.cs                                                     *
* Contents:     Enum IssueStatus                                                   *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 22:28                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Enumerations
{
	/// <summary>
	/// Temporal stage of an issue's evolution.
	/// </summary>
	public enum IssueStatus
	{
		/// <summary>
		/// The issue is new.
		/// </summary>
		New,

		/// <summary>
		/// The issue has been assigned to a developer.
		/// </summary>
        Assigned,

		/// <summary>
		/// The issue has been resolved.
		/// </summary>
        Resolved,

		/// <summary>
		/// The issue is closed (resolved or not).
		/// </summary>
        Closed
	}
}
