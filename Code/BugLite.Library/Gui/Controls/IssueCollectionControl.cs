/***********************************************************************************
* File:         IssueCollectionControl.cs                                          *
* Contents:     Class IssueCollectionControl                                       *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 12:51                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;
using BugLite.Library.Domain.Enumerations;
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
		private Func<Issue, Issue, int> CreationDateComparer = (i1, i2) => {return DateTime.Compare(i1.SubmittedOn, i2.SubmittedOn);};
		private Func<Issue, Issue, int> ModificationDateComparer = (i1, i2) => {return DateTime.Compare(i1.LastUpdated, i2.LastUpdated);};
		private Func<Issue, Issue, int> StatusComparer = (i1, i2) => {return i1.Status < i2.Status ? -1 : i1.Status > i2.Status ? +1 : 0;};
		private Func<Issue, Issue, int> SeverityComparer = (i1, i2) => {return i1.Severity < i2.Severity ? -1 : i1.Severity > i2.Severity ? +1 : 0;};
		private Func<Issue, Issue, int> PriorityComparer = (i1, i2) => {return i1.Priority < i2.Priority ? -1 : i1.Priority > i2.Priority ? +1 : 0;};
		private Func<Issue, Issue, int> IdComparer = (i1, i2) => {return i1.IssueId < i2.IssueId ? -1 : i1.IssueId > i2.IssueId ? +1 : 0;};

		#region Properties
		/// <summary>
		/// Gets the selected issue in the list view (null if none is selected or more than one).
		/// </summary>
		public Issue SelectedIssue
		{
			get
			{
				if (this._lvIssues.SelectedItems.Count == 1)
				{
					Issue issue = this._lvIssues.SelectedItems[0].Tag as Issue;
					return issue;
				}
				else
				{
					return null;
				}
			}
		}

		public Issue[] SelectedIssues
		{
			get
			{
				List<Issue> issues = new List<Issue>();

				foreach (ListViewItem item in this._lvIssues.SelectedItems)
				{
					issues.Add(item.Tag as Issue);
				}
				
				return issues.ToArray();
			}
		}
		#endregion

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

				lvi.UseItemStyleForSubItems = false;
				System.Windows.Forms.ListViewItem.ListViewSubItemCollection subItems = lvi.SubItems;

				lvi.Tag = issue;

				switch (issue.Status)
				{
					case Domain.Enumerations.IssueStatus.Open:
						subItems[2].BackColor = Color.Red;
						subItems[2].ForeColor = Color.White;
						break;

					case Domain.Enumerations.IssueStatus.InProgress:
						subItems[2].BackColor = Color.Blue;
						subItems[2].ForeColor = Color.White;
						break;

					case Domain.Enumerations.IssueStatus.Resolved:
						subItems[2].BackColor = Color.Green;
						subItems[2].ForeColor = Color.White;
						break;

					case Domain.Enumerations.IssueStatus.Closed:
						subItems[2].BackColor = Color.White;
						subItems[2].ForeColor = Color.Gray;
						break;

					default:
						break;
				}

				switch (issue.Severity)
				{
					case Domain.Enumerations.Severity.Feature:
						lvi.ImageKey			= "feature";
						subItems[3].BackColor	= Color.LightGreen;
						subItems[3].ForeColor	= Color.MidnightBlue;
						break;

					case Domain.Enumerations.Severity.Minor:
						lvi.ImageKey = "bug_minor";
						subItems[3].BackColor	= Color.Yellow;
						subItems[3].ForeColor	= Color.MidnightBlue;
						break;

					case Domain.Enumerations.Severity.Major:
						lvi.ImageKey = "bug_major";
						subItems[3].BackColor	= Color.Orange;
						subItems[3].ForeColor	= Color.MidnightBlue;
						break;

					case Domain.Enumerations.Severity.Crash:
						lvi.ImageKey = "bang";
						subItems[3].BackColor	= Color.Fuchsia;
						subItems[3].ForeColor	= Color.White;
						break;

					case Domain.Enumerations.Severity.Critical:
						lvi.ImageKey = "critical";
						subItems[3].BackColor	= Color.Red;
						subItems[3].ForeColor	= Color.White;
						break;

					default:
						break;
				}

				switch (issue.Priority)
				{
					case Domain.Enumerations.Priority.None:
						subItems[4].BackColor	= Color.White;
						break;

					case Domain.Enumerations.Priority.Low:
						subItems[4].BackColor	= Color.LightGreen;
						break;

					case Domain.Enumerations.Priority.Normal:
						subItems[4].BackColor	= Color.Yellow;
						break;

					case Domain.Enumerations.Priority.High:
						subItems[4].BackColor	= Color.Red;
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
				this.Sort(JsonBugLiteManager.Instance.Settings.IssueSorting);
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
				Issue issue			= this._lvIssues.SelectedItems[0].Tag as Issue;

				int issueID			= issue.IssueId;

				IssueDialog dialog	= new IssueDialog();
				dialog.Issue		= issue;

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					issue = dialog.Issue;
					issue.IssueId = issueID;

					JsonBugLiteManager.Instance.ReplaceIssue(issue);
					this.Sort(JsonBugLiteManager.Instance.Settings.IssueSorting);
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
					this.Sort(JsonBugLiteManager.Instance.Settings.IssueSorting);
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

		public void Sort(IssueSorting sorting)
		{
			List<Issue> issues = new List<Issue>();

			switch (sorting)
			{
				case IssueSorting.CreationDate:
					issues = JsonBugLiteManager.Instance.CurrentProject.Issues.Values.ToList();
					issues.Sort(this.CreationDateComparer.Invoke);
					break;

				case IssueSorting.ModificationDate:
					issues = JsonBugLiteManager.Instance.CurrentProject.Issues.Values.ToList();
					issues.Sort(this.ModificationDateComparer.Invoke);
					break;

				case IssueSorting.Status:
					issues = JsonBugLiteManager.Instance.CurrentProject.Issues.Values.ToList();
					issues.Sort(this.StatusComparer.Invoke);
					break;

				case IssueSorting.Severity:
					issues = JsonBugLiteManager.Instance.CurrentProject.Issues.Values.ToList();
					issues.Sort(this.SeverityComparer.Invoke);
					break;

				case IssueSorting.Priority:
					issues = JsonBugLiteManager.Instance.CurrentProject.Issues.Values.ToList();
					issues.Sort(this.PriorityComparer.Invoke);
					break;

				case IssueSorting.Id:
				case IssueSorting.None:
				default:
					issues = JsonBugLiteManager.Instance.CurrentProject.Issues.Values.ToList();
					issues.Sort(this.IdComparer.Invoke);
					break;

			}

			this.Display(issues);
		}
	}
}
