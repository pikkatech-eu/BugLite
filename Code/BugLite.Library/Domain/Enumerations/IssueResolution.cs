/***********************************************************************************
* File:         IssueResolution.cs                                                 *
* Contents:     Enum IssueResolution                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 22:29                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Enumerations
{
	/// <summary>
	/// Describes the result of an issue's evolution.
	/// </summary>
	public enum IssueResolution
	{
		/// <summary>
		/// Issue has been open.
		/// </summary>
        Open,

		/// <summary>
		/// Issue is fixed.
		/// </summary>
        Fixed,

		/// <summary>
		/// The developer could not reproduce the issue.
		/// </summary>
        Unreproducible,

		/// <summary>
		/// The developer cannot fix the issue.
		/// </summary>
        Unfixable,

		/// <summary>
		/// Developer: no changes are needed.
		/// </summary>
        NoChangeRequired,

		/// <summary>
		/// Developer: will not make changes, though the may be needed.
		/// </summary>
        WontFix
	}
}
