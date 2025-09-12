using BugLite.Library.Management;

namespace BugLite
{
	public partial class BugLiteForm : Form
	{
		public BugLiteForm()
		{
			InitializeComponent();

			// this._ctrlIssueCollection = new Library.Gui.Controls.IssueCollectionControl();

			Icon icon = Icon.ExtractAssociatedIcon("bugLite.ico");

			this.Icon = icon;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
		}

		private void OnProjectNew(object sender, EventArgs e)
		{
			JsonBugLiteManager.Instance.NewProject();
			this._lblProjectInfo.Text	= JsonBugLiteManager.Instance.CurrentProject.Name;
			this.OnProjectSaveAs(sender, e);
		}

		private void OnProjectEdit(object sender, EventArgs e)
		{
			JsonBugLiteManager.Instance.EditProject();
			this._lblProjectInfo.Text	= JsonBugLiteManager.Instance.CurrentProject.Name;
			JsonBugLiteManager.Instance.SaveProject(JsonBugLiteManager.Instance.CurrentProject.Name);
		}

		private void OnProjectClose(object sender, EventArgs e)
		{
			JsonBugLiteManager.Instance.CloseProject();
		}

		private void OnProjectLoad(object sender, EventArgs e)
		{
			OpenFileDialog dialog	= new OpenFileDialog();

			dialog.Filter			= "BugLite issue files (*.jissue)|*.jissue|JSON files (*.json)|*.json";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = dialog.FileName;

				JsonBugLiteManager.Instance.LoadProject(fileName);

				this._ctrlIssueCollection.Display(JsonBugLiteManager.Instance.CurrentProject.Issues.Values);
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
			// JsonBugLiteManager.Instance.AddIssue();
		}

		private void OnIssueEdit(object sender, EventArgs e)
		{
			// JsonBugLiteManager.Instance.ReplaceIssue();
		}

		private void OnIssueDelete(object sender, EventArgs e)
		{

		}

		private void OnToolsSettings(object sender, EventArgs e)
		{

		}

		private void OnHelpAbout(object sender, EventArgs e)
		{

		}
	}
}
