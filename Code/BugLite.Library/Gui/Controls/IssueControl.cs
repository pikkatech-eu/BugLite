/***********************************************************************************
* File:         IssueControl.cs                                                    *
* Contents:     Class IssueControl                                                 *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 11:59                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using BugLite.Library.Domain;
using BugLite.Library.Domain.Enumerations;
using BugLite.Library.Gui.Interfaces;

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

			this._cxStatus.DataSource = Enum.GetValues(typeof(IssueStatus));
			this._cxStatus.SelectedItem = IssueStatus.Open;

			this._cxSeverity.DataSource = Enum.GetValues(typeof(Severity));
			this._cxSeverity.SelectedItem = Severity.Major;

			this._cxPriority.DataSource = Enum.GetValues(typeof(Priority));
			this._cxPriority.SelectedItem = Priority.Normal;
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
				Issue issue = new Issue();

				issue.IssueId = Int32.Parse(this._lblIssue.Text);

				issue.LastUpdated = DateTime.Now;
				issue.Status = (IssueStatus)this._cxStatus.SelectedItem;
				issue.Severity = (Severity)this._cxSeverity.SelectedItem;
				issue.Priority = (Priority)this._cxPriority.SelectedItem;
				issue.Title = this._txTitle.Text;
				issue.Details = this._txDescription.Text;

				issue.StepsToReproduce		= this._txStepsToReproduce.Text;
				issue.AdditionalInformation	= this._txAdditionalInformation.Text;

				foreach (ListViewItem lvi in this._lvNotes.Items)
				{
					Note note = lvi.Tag as Note;
					issue.Notes.Add(note);
				}

				return issue;
			}

			set
			{
				this._lblIssue.Text = value.IssueId.ToString();

				this._cxStatus.SelectedItem = value.Status;
				this._cxSeverity.SelectedItem = value.Severity;
				this._cxPriority.SelectedItem = value.Priority;
				this._txTitle.Text = value.Title;
				this._txDescription.Text = value.Details;

				this._txStepsToReproduce.Text	= value.StepsToReproduce; 
				this._txAdditionalInformation.Text	= value.AdditionalInformation;

				this.DisplayNotes(value);
			}
		}
		#endregion

		private void OnNoteAdd(object sender, EventArgs e)
		{
			Note note = new Note();
			note.Text = "aaaa";

			ListViewItem lvi	= new ListViewItem(new string[]{note.Created.ToString("yyyy-MM-dd HH:mm")});
			lvi.Tag				= note;

			this._lvNotes.Items.Add(lvi);
		}

		private void OnNoteEdit(object sender, EventArgs e)
		{

		}

		private void OnNoteDelete(object sender, EventArgs e)
		{

		}

		private void DisplayNotes(Issue issue)
		{
			this._lvNotes.Items.Clear();

			foreach (Note note in issue.Notes)
			{
				ListViewItem lvi	= new ListViewItem(new string[]{note.Created.ToString("yyyy-MM-dd HH:mm")});
				lvi.Tag				= note;

				this._lvNotes.Items.Add(lvi);
			}

			this._lvNotes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}
	}
}
