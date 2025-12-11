/***********************************************************************************
* File:         IssueStatus.cs                                                     *
* Contents:     Enum IssueStatus                                                   *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 22:28                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json.Serialization;

namespace BugLite.Library.Domain.Enumerations
{
	/// <summary>
	/// Stage of an issue's evolution.
	/// Lean Core version.
	/// </summary>
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum IssueStatus
	{
		/// <summary>
		/// The issue is new.
		/// </summary>
		Open			= 0,

		/// <summary>
		/// The issue has been assigned to a developer.
		/// </summary>
        InProgress		= 1,

		/// <summary>
		/// The ussue has been resolved.
		/// </summary>
		Resolved		= 2,

		/// <summary>
		/// The issue is closed (resolved or not).
		/// </summary>
        Closed			= 3
	}
}
