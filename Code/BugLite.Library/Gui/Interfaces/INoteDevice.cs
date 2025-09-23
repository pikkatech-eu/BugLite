/***********************************************************************************
* File:         INoteDevice.cs                                                     *
* Contents:     Interface INoteDevice                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-23 21:06                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;

namespace BugLite.Library.Gui.Interfaces
{
	public interface INoteDevice
	{
		Note Note	{get;set;}
	}
}
