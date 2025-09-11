/***********************************************************************************
* File:         ProjectStatus.cs                                                   *
* Contents:     Enum ProjectStatus                                                 *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 22:30                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Enumerations
{
	/// <summary>
	/// Describes (optional) project status.
	/// </summary>
	public enum ProjectStatus
	{
		/// <summary>
		/// Default status: developed project
		/// </summary>
        Development,

		/// <summary>
		/// Project in release phase.
		/// </summary>
        Release,

		/// <summary>
		/// Project in quasi-stable, working phase.
		/// </summary>
        Stable
	}
}
