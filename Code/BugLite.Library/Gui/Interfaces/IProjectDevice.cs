/***********************************************************************************
* File:         IProjectDevice.cs                                                  *
* Contents:     Interface IProjectDevice                                           *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 11:38                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;

namespace BugLite.Library.Gui.Interfaces
{
	public interface IProjectDevice
	{
		Project Project	{get;set;}
	}
}
