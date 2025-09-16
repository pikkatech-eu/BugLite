/***********************************************************************************
* File:         IssueCollectionControl.cs                                          *
* Contents:     Class IssueCollectionControl                                       *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 12:51                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;
using BugLite.Library.Gui.Dialogs;
using BugLite.Library.Gui.Interfaces;
using BugLite.Library.Management;

namespace BugLite.Library.Gui.Controls
{
	/// <summary>
	/// Defines a GUI device (control or dialog) to handle instances of collections of type Issue.
	/// </summary>
	public partial class IssueCollectionControl : UserControl, IIssueCollectionDevice
	{
		#region Construction
		/// <summary>
		/// Default constructor.
		/// </summary>
		public IssueCollectionControl()
		{
			InitializeComponent();
		}
		#endregion

		#region IIssueCollectionDevice
		/// <summary>
		/// Displays a collections of Issues.
		/// </summary>
		/// <param name="issues">Collection of Issues to display.</param>
		public void Display(IEnumerable<Issue> issues)
		{
			this._lvIssues.Items.Clear();

			foreach (Issue issue in issues)
			{
				string[] itemStrings =
										{
											issue.IssueId.ToString(),
											issue.SubmittedOn.ToString("yyyy-MM-dd HH:mm"),
											issue.Status.ToString(),
											issue.Severity.ToString(),
											issue.Priority.ToString(),
											issue.Title,
											issue.Details
										};

				ListViewItem lvi = new ListViewItem(itemStrings);
				lvi.Tag = issue;

				switch (issue.Status)
				{
					case Domain.Enumerations.IssueStatus.Open:
						lvi.ForeColor = Color.Red;
						break;

					case Domain.Enumerations.IssueStatus.InProgress:
						lvi.ForeColor = Color.Blue;
						break;

					case Domain.Enumerations.IssueStatus.Resolved:
						lvi.ForeColor = Color.Green;
						break;

					case Domain.Enumerations.IssueStatus.Closed:
						lvi.ForeColor = Color.Gray;
						break;

					default:
						break;
				}

				this._lvIssues.Items.Add(lvi);
			}

			this._lvIssues.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this._lvIssues.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		/// <summary>
		/// Clears the displayed collection of Issue.
		/// </summary>
		public void Clear()
		{
			this._lvIssues.Items.Clear();
		}
		#endregion

		#region Private Auxiliary
		/// <summary>
		/// Handles context menu event "New issue".
		/// Creates an Issue dialog, causes JsonBugLiteManager to add the Issue from the dialog, and displays all issues anew.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void OnIssueNew(object sender, EventArgs e)
		{
			try
			{
				JsonBugLiteManager.Instance.AddIssue();
				this.Display(JsonBugLiteManager.Instance.CurrentProject.Issues.Values);
			}
			catch (NullReferenceException nex)
			{
				MessageBox.Show(nex.Message, "Create or open project", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		/// <summary>
		/// Handles context menu event "Edit issue".
		/// Creates an Issue dialog, sets the value of Issue in it with the issue selected in the ListView,
		/// causes JsonBugLiteManager to edit the Issue from the dialog, and displays all issues anew.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void OnIssueEdit(object sender, EventArgs e)
		{
			if (this._lvIssues.SelectedItems.Count == 1)
			{
				Issue issue = this._lvIssues.SelectedItems[0].Tag as Issue;

				int issueID = issue.IssueId;

				IssueDialog dialog = new IssueDialog();
				dialog.Issue = issue;

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					issue = dialog.Issue;
					issue.IssueId = issueID;

					JsonBugLiteManager.Instance.ReplaceIssue(issue);
					this.Display(JsonBugLiteManager.Instance.CurrentProject.Issues.Values);
				}
			}
		}

		/// <summary>
		/// Handles context menu event "Delete issue".
		/// Asks the user if she really wants the selected issue to be deleted; if OK, 
		/// causes JsonBugLiteManager to delete the Issue, and displays all issues anew.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void OnIssueDelete(object sender, EventArgs e)
		{
			if (this._lvIssues.SelectedItems.Count == 1)
			{
				Issue issue = this._lvIssues.SelectedItems[0].Tag as Issue;

				int issueID = issue.IssueId;

				if (MessageBox.Show($"Delete issue {issueID}?", "Geolocation about to be deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					JsonBugLiteManager.Instance.DeleteIssue(issueID);
					this.Display(JsonBugLiteManager.Instance.CurrentProject.Issues.Values);
				}
			}
		}

		/// <summary>
		/// Handles GUI event "Doubleclik on ListView".
		/// Added for convenience. Does exactly the same thing as OnIssueEdit().
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void OnListViewDoubleclicked(object sender, EventArgs e)
		{
			this.OnIssueEdit(sender, e);
		}
		#endregion
	}
}
