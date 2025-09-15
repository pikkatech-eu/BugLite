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
	/// <summary>
	/// Defines a GUI device (control or dialog) to handle instances of Project.
	/// </summary>
	public interface IProjectDevice
	{
		/// <summary>
		/// Gets an instance of Project from GUI and sets it to GUI.
		/// </summary>
		Project Project	{get;set;}
	}
}
