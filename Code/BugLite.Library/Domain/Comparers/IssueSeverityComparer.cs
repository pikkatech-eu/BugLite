/***********************************************************************************
* File:         IssueSeverityComparer.cs                                           *
* Contents:     Class IssueSeverityComparer                                        *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-16 13:04                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain.Comparers
{
	public class IssueSeverityComparer : IComparer<Issue>
	{
		public int Compare(Issue? x, Issue? y)
		{
			if (x.Severity < y.Severity)
			{
				return -1;
			}
			else if (x.Severity > y.Severity)
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
