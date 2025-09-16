/***********************************************************************************
* File:         Priority.cs                                                        *
* Contents:     Enum Priority                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 22:25                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Enumerations
{
	/// <summary>
	/// Priority of an issue.
	/// </summary>
	public enum Priority
	{
		/// <summary>
		/// No definite priority defined.
		/// </summary>
        None	= 0,

		/// <summary>
		/// Issue of low priority.
		/// </summary>
        Low		= 1,

		/// <summary>
		/// Issue of normal priority (default).
		/// </summary>
        Normal	= 2,

		/// <summary>
		/// Issue of high priority.
		/// </summary>
        High	= 3
	}
}
