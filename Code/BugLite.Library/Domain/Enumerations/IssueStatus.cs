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
	/// Stage of an issue's evolution.
	/// Lean Core version.
	/// </summary>
	public enum IssueStatus
	{
		/// <summary>
		/// The issue is new.
		/// </summary>
		Open,

		/// <summary>
		/// The issue has been assigned to a developer.
		/// </summary>
        InProgress,

		/// <summary>
		/// The ussue has been resolved.
		/// </summary>
		Resolved,

		/// <summary>
		/// The issue is closed (resolved or not).
		/// </summary>
        Closed
	}
}
