/***********************************************************************************
* File:         IIssueCollectionDevice.cs                                          *
* Contents:     Interface IIssueCollectionDevice                                   *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 11:37                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;

namespace BugLite.Library.Gui.Interfaces
{
	/// <summary>
	/// Defines a GUI device (control or dialog) to handle collections of Issues.
	/// </summary>
	public interface IIssueCollectionDevice
	{
		/// <summary>
		/// Displays a collections of Issues.
		/// </summary>
		/// <param name="issues">Collection of Issues to display.</param>
		void Display(IEnumerable<Issue> issues);

		/// <summary>
		/// Clears the displayed collection of Issue.
		/// </summary>
		void Clear();
	}
}
