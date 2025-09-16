/***********************************************************************************
* File:         IssuePriorityComparer.cs                                           *
* Contents:     Class IssuePriorityComparer                                        *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-16 13:05                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Comparers
{
	public class IssuePriorityComparer : IComparer<Issue>
	{
		public int Compare(Issue? x, Issue? y)
		{
			if (x.Priority < y.Priority)
			{
				return -1;
			}
			else if (x.Priority > y.Priority)
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
