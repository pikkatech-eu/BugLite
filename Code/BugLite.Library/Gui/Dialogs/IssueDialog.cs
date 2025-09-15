/***********************************************************************************
* File:         IssueDialog.cs                                                  *
* Contents:     Class IssueDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;
using BugLite.Library.Gui.Interfaces;
using System.ComponentModel;

namespace BugLite.Library.Gui.Dialogs
{
	/// <summary>
	/// Implements a GUI dialog to handle instances of Issue.
	/// </summary>
	public partial class IssueDialog : Form, IIssueDevice
	{
		#region Construction
		public IssueDialog()
		{
			InitializeComponent();
		} 
		#endregion

		#region IIssueDevice
		/// <summary>
		/// Gets an instance of Issue from GUI and sets it to GUI.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Issue Issue
		{
			get
			{
				return this._ctrlIssue.Issue;
			}

			set
			{
				this._ctrlIssue.Issue = value;
			}
		}
		#endregion
	}
}
