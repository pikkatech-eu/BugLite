/***********************************************************************************
* File:         IssueDateTimeComparer.cs                                           *
* Contents:     Class IssueDateTimeComparer                                        *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-16 12:52                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Comparers
{
	/// <summary>
	/// Compares instances of Issue by DateTime.
	/// </summary>
	public class IssueDateTimeComparer : IComparer<Issue>
	{
		public int Compare(Issue? x, Issue? y)
		{
			if (x.SubmittedOn < y.SubmittedOn)
			{
				return -1;
			}
			else if (x.SubmittedOn > y.SubmittedOn)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}
}
