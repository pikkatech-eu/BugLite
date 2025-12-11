/***********************************************************************************
* File:         Priority.cs                                                        *
* Contents:     Enum Priority                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 22:25                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json.Serialization;

namespace BugLite.Library.Domain.Enumerations
{
	/// <summary>
	/// Priority of an issue.
	/// </summary>
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum Priority
	{
		/// <summary>
		/// No definite priority defined.
		/// </summary>
        None	= 3,

		/// <summary>
		/// Issue of low priority.
		/// </summary>
        Low		= 2,

		/// <summary>
		/// Issue of normal priority (default).
		/// </summary>
        Normal	= 1,

		/// <summary>
		/// Issue of high priority.
		/// </summary>
        High	= 0
	}
}
