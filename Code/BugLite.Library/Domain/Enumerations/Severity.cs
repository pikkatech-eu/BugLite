/***********************************************************************************
* File:         Severity.cs                                                        *
* Contents:     Enum Severity                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 22:25                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json.Serialization;

namespace BugLite.Library.Domain.Enumerations
{
	/// <summary>
	/// Severity of an issue.
	/// </summary>
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum Severity
	{
		/// <summary>
		/// A new feature required, no bug.
		/// </summary>
		Feature		= 4,

		/// <summary>
		/// Bug of minor severity,
		/// </summary>
		Minor		= 3,

		/// <summary>
		/// Bug of major severity,
		/// </summary>
		Major		= 2,

		/// <summary>
		/// Of critical importance
		/// </summary>
		Critical	= 1,

		/// <summary>
		/// Causes program crash
		/// </summary>
		Crash		= 0
	}
}
