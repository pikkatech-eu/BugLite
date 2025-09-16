using BugLite.Library.Management;
using BugLite.Library.Tools.Toml;

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

			this.SetTitle();
		}

		private void SetTitle()
		{
			Tomler tomler = new Tomler();

			string name = "BugLite";

			string versionFile = null;
			
			try
			{
				// for NSIS
				versionFile = "version.toml";
				tomler.Load(versionFile);
			}
			catch (Exception)
			{
				// for debug
				versionFile = "..\\..\\..\\version.toml";
				tomler.Load(versionFile);
			}
			
			string major	= tomler.GetValue("Version", "Major");
			string minor	= tomler.GetValue("Version", "Minor");
			string build	= tomler.GetValue("Version", "Build");
			string revision = tomler.GetValue("Version", "Revision");

			this.Text = $"{name} {major}.{minor}.{build}.{revision}";
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
			// this.OnProjectSaveAs(sender, e);
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
			this._lblProjectInfo.Text	= "";
			this._ctrlIssueCollection.Clear();
		}

		private void OnProjectLoad(object sender, EventArgs e)
		{
			OpenFileDialog dialog	= new OpenFileDialog();

			dialog.Filter			= "BugLite issue files (*.jissue)|*.jissue|JSON files (*.json)|*.json";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = dialog.FileName;

				JsonBugLiteManager.Instance.LoadProject(fileName);

				this._lblProjectInfo.Text	= JsonBugLiteManager.Instance.CurrentProject.Name;

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
