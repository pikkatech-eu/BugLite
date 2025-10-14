/***********************************************************************************
* File:         BugLiteForm.cs                                                     *
* Contents:     Class BugLiteForm                                                  *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-18 09:16                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;
using BugLite.Library.Gui.Dialogs;
using BugLite.Library.Management;

namespace BugLite
{
	public partial class BugLiteForm : Form
	{
		public BugLiteForm()
		{
			InitializeComponent();

			JsonBugLiteManager.Instance.Settings.RecentlyOpenedProjectsChanged += this.OnRecentlyOpenedProjectsChanged;
			this.SetTitle();

			this.OnRecentlyOpenedProjectsChanged(JsonBugLiteManager.Instance.Settings.RecentlyOpenedProjects);

			if (JsonBugLiteManager.Instance.Settings.AutoLoadLastProject && JsonBugLiteManager.Instance.Settings.RecentlyOpenedProjects.Count > 0)
			{
				this.LoadProject(JsonBugLiteManager.Instance.Settings.RecentlyOpenedProjects[0]);
			}
		}

		private void OnRecentlyOpenedProjectsChanged(List<string> paths)
		{
			List<ToolStripItem> items = new List<ToolStripItem>();

			this._menuItemRecentProjects.DropDownItems.Clear();

			foreach (string path in paths)
			{
				ToolStripItem item = this._menuItemRecentProjects.DropDownItems.Add(path);

				item.Click += this.RecentlyOpenedItemClicked;

				items.Add(item);
			}
		}

		private void RecentlyOpenedItemClicked(object? sender, EventArgs e)
		{
			string filePath = ((ToolStripItem)sender).Text;

			if (File.Exists(filePath))
			{
				this.LoadProject(filePath);
			}
			else
			{
				JsonBugLiteManager.Instance.Settings.RemoveRecentlyOpenedProject(filePath);
			}
		}

		private void SetTitle()
		{
			// TODO: to iron away #1
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
		}

		private void OnProjectNew(object sender, EventArgs e)
		{
			JsonBugLiteManager.Instance.NewProject();
			this._lblProjectInfo.Text	= JsonBugLiteManager.Instance.CurrentProject.Name;
			this._ctrlIssueCollection.Clear();
		}

		private void OnProjectEdit(object sender, EventArgs e)
		{
			if (JsonBugLiteManager.Instance.CurrentProject != null)
			{
				JsonBugLiteManager.Instance.EditProject();
				this._lblProjectInfo.Text	= JsonBugLiteManager.Instance.CurrentProject.Name;
				JsonBugLiteManager.Instance.SaveProject(JsonBugLiteManager.Instance.CurrentProject.Name);
			}
		}

		private void OnProjectClose(object sender, EventArgs e)
		{
			JsonBugLiteManager.Instance.CloseProject();
			this._lblProjectInfo.Text	= "";
			this._ctrlIssueCollection.Clear();
		}

		private void OnProjectLoad(object sender, EventArgs e)
		{
			OpenFileDialog dialog	= new OpenFileDialog();

			dialog.Filter			= "BugLite issue files (*.jissue)|*.jissue|JSON files (*.json)|*.json";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.LoadProject(dialog.FileName);
			}
		}

		private void OnProjectSaveAs(object sender, EventArgs e)
		{
			SaveFileDialog dialog	= new SaveFileDialog();
			dialog.Filter			= "BugLite issue files (*.jissue)|*.jissue|JSON files (*.json)|*.json";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				JsonBugLiteManager.Instance.ProjectPath = dialog.FileName;
				JsonBugLiteManager.Instance.SaveProject(JsonBugLiteManager.Instance.ProjectPath);
			}
		}

		private void OnProjectQuit(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnIssueNew(object sender, EventArgs e)
		{
			try
			{
				JsonBugLiteManager.Instance.AddIssue();
				this._ctrlIssueCollection.Display(JsonBugLiteManager.Instance.CurrentProject.Issues.Values);
			}
			catch (NullReferenceException nrx)
			{
				MessageBox.Show(nrx.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void OnIssueEdit(object sender, EventArgs e)
		{
			Issue issue = this._ctrlIssueCollection.SelectedIssue;

			if (issue != null)
			{
				JsonBugLiteManager.Instance.ReplaceIssue(issue);
				this._ctrlIssueCollection.Display(JsonBugLiteManager.Instance.CurrentProject.Issues.Values);
			}
		}

		private void OnIssueDelete(object sender, EventArgs e)
		{
			Issue issue = this._ctrlIssueCollection.SelectedIssue;

			if (issue != null)
			{
				JsonBugLiteManager.Instance.DeleteIssue(issue.IssueId);
				this._ctrlIssueCollection.Display(JsonBugLiteManager.Instance.CurrentProject.Issues.Values);
			}
		}

		private void OnToolsSettings(object sender, EventArgs e)
		{
			SettingsDialog dialog	= new SettingsDialog();
			dialog.Settings			= JsonBugLiteManager.Instance.Settings;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				JsonBugLiteManager.Instance.Settings = dialog.Settings;
				JsonBugLiteManager.Instance.Settings.Save();
			}
		}

		private void OnHelpAbout(object sender, EventArgs e)
		{

		}

		#region Internal Auxiliary
		internal void LoadProject(string fileName)
		{
			try
			{
				JsonBugLiteManager.Instance.LoadProject(fileName);

				this._lblProjectInfo.Text = JsonBugLiteManager.Instance.CurrentProject.Name;

				this._ctrlIssueCollection.Display(JsonBugLiteManager.Instance.CurrentProject.Issues.Values);
			}
			catch (Exception)
			{
				MessageBox.Show
								(
									$"Unable to open project {fileName}", 
									"The project will be removed from Recently Opened Projects", 
									MessageBoxButtons.OK, 
									MessageBoxIcon.Warning
								);

				JsonBugLiteManager.Instance.Settings.RemoveRecentlyOpenedProject(fileName);
			}
		}
		#endregion
	}
}
