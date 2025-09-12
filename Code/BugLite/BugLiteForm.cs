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
	}
}
