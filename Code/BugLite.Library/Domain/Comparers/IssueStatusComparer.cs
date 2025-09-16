/***********************************************************************************
* File:         IssueStatusComparer.cs                                             *
* Contents:     Class IssueStatusComparer                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-16 13:02                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Comparers
{
	public class IssueStatusComparer : IComparer<Issue>
	{
		public int Compare(Issue? x, Issue? y)
		{
			if (x.Status < y.Status)
			{
				return -1;
			}
			else if (x.Status > y.Status)
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
