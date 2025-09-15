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
	public interface IIssueCollectionDevice
	{
		void Display(IEnumerable<Issue> issues);

		void Clear();
	}
}
