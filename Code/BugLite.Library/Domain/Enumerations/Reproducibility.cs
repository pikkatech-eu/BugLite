/***********************************************************************************
* File:         Reproducibility.cs                                                 *
* Contents:     Enum Reproducibility                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 22:27                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Enumerations
{
	/// <summary>
	/// Reproducibility of an issue.
	/// </summary>
	public enum Reproducibility
	{
		/// <summary>
		/// No information for reproducibility.
		/// </summary>
		Unknown,

		/// <summary>
		/// The issue occurs time and again, but rather seldom.
		/// </summary>
        Seldom,

		/// <summary>
		/// The issue occurs randomly time and again.
		/// </summary>
        Random,

		/// <summary>
		/// The issue occurs always.
		/// </summary>
        Always
	}
}
