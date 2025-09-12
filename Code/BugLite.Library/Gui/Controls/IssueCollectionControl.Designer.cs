namespace BugLite.Library.Gui.Controls
{
	partial class IssueCollectionControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._tlpUserControl = new TableLayoutPanel();
			this._lvIssues = new ListView();
			this.IssueId = new ColumnHeader();
			this.ProjectName = new ColumnHeader();
			this.IssueStatus = new ColumnHeader();
			this.IssueTitle = new ColumnHeader();
			this.IssueDetails = new ColumnHeader();
			this._cmsIssues = new ContextMenuStrip(this.components);
			this.newIssueToolStripMenuItem = new ToolStripMenuItem();
			this.editIssueToolStripMenuItem = new ToolStripMenuItem();
			this.deleteIssueToolStripMenuItem = new ToolStripMenuItem();
			this._tlpUserControl.SuspendLayout();
			this._cmsIssues.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tlpUserControl
			// 
			this._tlpUserControl.ColumnCount = 1;
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			this._tlpUserControl.Controls.Add(this._lvIssues, 0, 0);
			this._tlpUserControl.Dock = DockStyle.Fill;
			this._tlpUserControl.Location = new Point(0, 0);
			this._tlpUserControl.Margin = new Padding(0);
			this._tlpUserControl.Name = "_tlpUserControl";
			this._tlpUserControl.RowCount = 1;
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpUserControl.Size = new Size(638, 400);
			this._tlpUserControl.TabIndex = 0;
			// 
			// _lvIssues
			// 
			this._lvIssues.Columns.AddRange(new ColumnHeader[] { this.IssueId, this.ProjectName, this.IssueStatus, this.IssueTitle, this.IssueDetails });
			this._lvIssues.ContextMenuStrip = this._cmsIssues;
			this._lvIssues.Dock = DockStyle.Fill;
			this._lvIssues.FullRowSelect = true;
			this._lvIssues.Location = new Point(3, 3);
			this._lvIssues.Name = "_lvIssues";
			this._lvIssues.Size = new Size(632, 394);
			this._lvIssues.TabIndex = 2;
			this._lvIssues.UseCompatibleStateImageBehavior = false;
			this._lvIssues.View = View.Details;
			// 
			// IssueId
			// 
			this.IssueId.Text = "ID";
			// 
			// ProjectName
			// 
			this.ProjectName.Text = "Project";
			// 
			// IssueStatus
			// 
			this.IssueStatus.Text = "Status";
			// 
			// IssueTitle
			// 
			this.IssueTitle.Text = "Title";
			// 
			// IssueDetails
			// 
			this.IssueDetails.Text = "Details";
			// 
			// _cmsIssues
			// 
			this._cmsIssues.Font = new Font("Consolas", 10F);
			this._cmsIssues.ImageScalingSize = new Size(20, 20);
			this._cmsIssues.Items.AddRange(new ToolStripItem[] { this.newIssueToolStripMenuItem, this.editIssueToolStripMenuItem, this.deleteIssueToolStripMenuItem });
			this._cmsIssues.Name = "_cmsIssues";
			this._cmsIssues.Size = new Size(187, 76);
			// 
			// newIssueToolStripMenuItem
			// 
			this.newIssueToolStripMenuItem.Name = "newIssueToolStripMenuItem";
			this.newIssueToolStripMenuItem.Size = new Size(186, 24);
			this.newIssueToolStripMenuItem.Text = "&New Issue";
			this.newIssueToolStripMenuItem.Click += this.OnIssueNew;
			// 
			// editIssueToolStripMenuItem
			// 
			this.editIssueToolStripMenuItem.Name = "editIssueToolStripMenuItem";
			this.editIssueToolStripMenuItem.Size = new Size(186, 24);
			this.editIssueToolStripMenuItem.Text = "&Edit Issue";
			this.editIssueToolStripMenuItem.Click += this.OnIssueEdit;
			// 
			// deleteIssueToolStripMenuItem
			// 
			this.deleteIssueToolStripMenuItem.Name = "deleteIssueToolStripMenuItem";
			this.deleteIssueToolStripMenuItem.Size = new Size(186, 24);
			this.deleteIssueToolStripMenuItem.Text = "&Delete Issue";
			this.deleteIssueToolStripMenuItem.Click += this.OnIssueDelete;
			// 
			// IssueCollectionControl
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.Controls.Add(this._tlpUserControl);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Margin = new Padding(0);
			this.Name = "IssueCollectionControl";
			this.Size = new Size(638, 400);
			this._tlpUserControl.ResumeLayout(false);
			this._cmsIssues.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel _tlpUserControl;
		private ListView _lvIssues;
		private ColumnHeader IssueId;
		private ColumnHeader ProjectName;
		private ColumnHeader IssueTitle;
		private ColumnHeader IssueDetails;
		private ColumnHeader IssueStatus;
		private ContextMenuStrip _cmsIssues;
		private ToolStripMenuItem newIssueToolStripMenuItem;
		private ToolStripMenuItem editIssueToolStripMenuItem;
		private ToolStripMenuItem deleteIssueToolStripMenuItem;
	}
}
