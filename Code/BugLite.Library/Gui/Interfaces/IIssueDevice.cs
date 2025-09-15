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
	/// <summary>
	/// Defines a GUI device (control or dialog) to handle instances of Issue.
	/// </summary>
	public interface IIssueDevice
	{
		/// <summary>
		/// Gets an instance of Issue from GUI and sets it to GUI.
		/// </summary>
		Issue Issue{get;set;}
	}
}
