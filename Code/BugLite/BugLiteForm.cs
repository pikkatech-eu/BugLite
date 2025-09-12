using BugLite.Library.Management;

namespace BugLite
{
	public partial class BugLiteForm : Form
	{
		public BugLiteForm()
		{
			InitializeComponent();

			Icon icon = Icon.ExtractAssociatedIcon("bugLite.ico");

			this.Icon = icon;
		}

		protected override void OnLoad(EventArgs e)
		{
		}

		private void OnProjectNew(object sender, EventArgs e)
		{

		}

		private void OnProjectEdit(object sender, EventArgs e)
		{

		}

		private void OnProjectClose(object sender, EventArgs e)
		{

		}

		private void OnProjectLoad(object sender, EventArgs e)
		{
			OpenFileDialog dialog	= new OpenFileDialog();

			dialog.Filter			= "BugLite issue files (*.jissue)|*.jissue|JSON files (*.json)|*.json";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = dialog.FileName;

				JsonBugLiteManager.Instance.LoadProject(fileName);
			}
		}

		private void OnProjectSaveAs(object sender, EventArgs e)
		{

		}

		private void OnProjectQuit(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnIssueNew(object sender, EventArgs e)
		{

		}

		private void OnIssueEdit(object sender, EventArgs e)
		{

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
