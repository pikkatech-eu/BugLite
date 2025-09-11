/***********************************************************************************
* File:         Severity.cs                                                        *
* Contents:     Enum Severity                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 22:25                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Enumerations
{
	/// <summary>
	/// Severity of an issue.
	/// </summary>
	public enum Severity
	{
		/// <summary>
		/// A new feature required, no bug.
		/// </summary>
		Feature,

		/// <summary>
		/// A trivial bug (typo etc.)
		/// </summary>
		Trivial,

		/// <summary>
		/// Light changes needed.
		/// </summary>
		Tweak,

		/// <summary>
		/// Bug of minor severity,
		/// </summary>
		Minor,

		/// <summary>
		/// Bug of major severity,
		/// </summary>
		Major,

		/// <summary>
		/// Bug produces crashes.
		/// </summary>
		Crash
	}
}
