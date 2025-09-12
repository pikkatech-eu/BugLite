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
	public partial class IssueCollectionControl : UserControl, IIssueCollectionDevice
	{
		public IssueCollectionControl()
		{
			InitializeComponent();

			JsonBugLiteManager.Instance.LoadProject(Settings.ProjectRepository);
			this.Display(JsonBugLiteManager.Instance.CurrentProject.Issues.Values);
		}

		public void Display(IEnumerable<Issue> issues)
		{
			this._lvIssues.Items.Clear();

			foreach (Issue issue in issues)
			{
				string[] itemStrings =
										{
											issue.IssueId.ToString(),
											issue.ProjectId.ToString(),
											issue.Status.ToString(),
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

					case Domain.Enumerations.IssueStatus.Closed:
						lvi.ForeColor = Color.Green;
						break;
					default:
						break;
				}

				this._lvIssues.Items.Add(lvi);
			}

			this._lvIssues.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this._lvIssues.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private void OnIssueNew(object sender, EventArgs e)
		{
			JsonBugLiteManager.Instance.AddIssue();
			this.Display(JsonBugLiteManager.Instance.CurrentProject.Issues.Values);
		}

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

		private void OnListViewDoubleclicked(object sender, EventArgs e)
		{
			this.OnIssueEdit(sender, e);
		}
	}
}
