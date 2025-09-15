/***********************************************************************************
* File:         IssueControl.cs                                                    *
* Contents:     Class IssueControl                                                 *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 11:59                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;
using BugLite.Library.Domain.Enumerations;
using BugLite.Library.Gui.Interfaces;
using System.ComponentModel;

namespace BugLite.Library.Gui.Controls
{
	/// <summary>
	/// Implements a GUI control to handle instances of Issue.
	/// </summary>
	public partial class IssueControl : UserControl, IIssueDevice
	{
		#region Construction
		/// <summary>
		/// Default constructor.
		/// Initializes the IssueStatus combobox.
		/// </summary>
		public IssueControl()
		{
			InitializeComponent();

			this._cxStatus.DataSource	= Enum.GetValues(typeof(IssueStatus));
			this._cxStatus.SelectedItem	= IssueStatus.Open;
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
				Issue issue		= new Issue();
				issue.IssueId	= Int32.Parse(this._lblIssue.Text);

				issue.LastUpdated	= DateTime.Now;
				issue.Status		= (IssueStatus)this._cxStatus.SelectedItem;
				issue.Title			= this._txTitle.Text;	
				issue.Details		= this._txDescription.Text;

				return issue;
			}

			set
			{
				this._lblIssue.Text			= value.IssueId.ToString();

				this._lblProject.Text		= "*"; 
				this._cxStatus.SelectedItem	= value.Status;
				this._txTitle.Text			= value.Title;
				this._txDescription.Text	= value.Details;
			}
		}
		#endregion
	}
}
