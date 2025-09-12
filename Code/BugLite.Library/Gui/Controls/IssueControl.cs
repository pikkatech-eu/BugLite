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
	public partial class IssueControl : UserControl, IIssueDevice
	{
		public IssueControl()
		{
			InitializeComponent();

			this._cxStatus.DataSource	= Enum.GetValues(typeof(IssueStatus));
			this._cxStatus.SelectedItem	= IssueStatus.Open;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Issue Issue
		{
			get
			{
				Issue issue		= new Issue();
				issue.IssueId	= Int32.Parse(this._lblIssue.Text);

				// TODO (Multi-project support): replace with the ID of the current project
				issue.ProjectId	= 0;	

				issue.LastUpdated	= DateTime.Now;
				issue.Status		= (IssueStatus)this._cxStatus.SelectedItem;
				issue.Title			= this._txTitle.Text;	
				issue.Details		= this._txDescription.Text;

				return issue;
			}

			set
			{
				this._lblIssue.Text			= value.IssueId.ToString();

				// TODO (Multi-project support): replace with the title of the current project
				this._lblProject.Text		= "Default"; 
				this._cxStatus.SelectedItem	= value.Status;
				this._txTitle.Text			= value.Title;
				this._txDescription.Text	= value.Details;
			}
		}
	}
}
