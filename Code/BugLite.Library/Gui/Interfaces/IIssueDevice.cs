/***********************************************************************************
* File:         IIssueDevice.cs                                                    *
* Contents:     Interface IIssueDevice                                             *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 10:49                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;

namespace BugLite.Library.Gui.Interfaces
{
	public interface IIssueDevice
	{
		Issue Issue{get;set;}
	}
}
