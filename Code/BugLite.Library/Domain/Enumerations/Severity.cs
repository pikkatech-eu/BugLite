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
		Feature	= 2,

		/// <summary>
		/// Bug of minor severity,
		/// </summary>
		Minor	= 1,

		/// <summary>
		/// Bug of major severity,
		/// </summary>
		Major	= 0
	}
}
