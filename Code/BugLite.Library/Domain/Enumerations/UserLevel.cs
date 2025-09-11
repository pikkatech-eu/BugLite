/***********************************************************************************
* File:         UserLevel.cs                                                       *
* Contents:     Enum UserLevel                                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 22:30                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Enumerations
{
	/// <summary>
	/// User's access rights.
	/// </summary>
	public enum UserLevel
	{
		/// <summary>
		/// Can only view tables, no dialog opening or editing.
		/// </summary>
        Viewer,

		/// <summary>
		/// Can report issues.
		/// </summary>
        Reporter,

		/// <summary>
		/// Can report, edit, and delete issues.
		/// </summary>
        Developer,

		/// <summary>
		/// Can report, edit, and delete issues, and manage users.
		/// </summary>
        Administrator
	}
}
