namespace BugLite
{
	partial class BugLiteForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._msBugLite = new MenuStrip();
			this.projectToolStripMenuItem = new ToolStripMenuItem();
			this.newToolStripMenuItem = new ToolStripMenuItem();
			this.editToolStripMenuItem = new ToolStripMenuItem();
			this.closeToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.loadToolStripMenuItem = new ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.quitToolStripMenuItem = new ToolStripMenuItem();
			this.issueToolStripMenuItem = new ToolStripMenuItem();
			this.newToolStripMenuItem1 = new ToolStripMenuItem();
			this.editToolStripMenuItem1 = new ToolStripMenuItem();
			this.deleteToolStripMenuItem = new ToolStripMenuItem();
			this.toolsToolStripMenuItem = new ToolStripMenuItem();
			this.settingsToolStripMenuItem = new ToolStripMenuItem();
			this.helpToolStripMenuItem = new ToolStripMenuItem();
			this.aboutToolStripMenuItem = new ToolStripMenuItem();
			this._tsBugLite = new ToolStrip();
			this._lblProjectInfo = new ToolStripLabel();
			this.statusStrip1 = new StatusStrip();
			this._tlpBugLite = new TableLayoutPanel();
			this._msBugLite.SuspendLayout();
			this._tsBugLite.SuspendLayout();
			this.SuspendLayout();
			// 
			// _msBugLite
			// 
			this._msBugLite.AutoSize = false;
			this._msBugLite.Font = new Font("Consolas", 12F);
			this._msBugLite.ImageScalingSize = new Size(20, 20);
			this._msBugLite.Items.AddRange(new ToolStripItem[] { this.projectToolStripMenuItem, this.issueToolStripMenuItem, this.toolsToolStripMenuItem, this.helpToolStripMenuItem });
			this._msBugLite.Location = new Point(0, 0);
			this._msBugLite.Name = "_msBugLite";
			this._msBugLite.Size = new Size(1115, 32);
			this._msBugLite.TabIndex = 0;
			this._msBugLite.Text = "menuStrip1";
			// 
			// projectToolStripMenuItem
			// 
			this.projectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.newToolStripMenuItem, this.editToolStripMenuItem, this.closeToolStripMenuItem, this.toolStripSeparator1, this.loadToolStripMenuItem, this.saveAsToolStripMenuItem, this.toolStripSeparator2, this.quitToolStripMenuItem });
			this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
			this.projectToolStripMenuItem.Size = new Size(101, 28);
			this.projectToolStripMenuItem.Text = "&Project";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new Size(224, 28);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += this.OnProjectNew;
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new Size(224, 28);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += this.OnProjectEdit;
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new Size(224, 28);
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += this.OnProjectClose;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(221, 6);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new Size(224, 28);
			this.loadToolStripMenuItem.Text = "&Load";
			this.loadToolStripMenuItem.Click += this.OnProjectLoad;
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new Size(224, 28);
			this.saveAsToolStripMenuItem.Text = "Save &As";
			this.saveAsToolStripMenuItem.Click += this.OnProjectSaveAs;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(221, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new Size(224, 28);
			this.quitToolStripMenuItem.Text = "&Quit";
			this.quitToolStripMenuItem.Click += this.OnProjectQuit;
			// 
			// issueToolStripMenuItem
			// 
			this.issueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.newToolStripMenuItem1, this.editToolStripMenuItem1, this.deleteToolStripMenuItem });
			this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
			this.issueToolStripMenuItem.Size = new Size(79, 28);
			this.issueToolStripMenuItem.Text = "&Issue";
			// 
			// newToolStripMenuItem1
			// 
			this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
			this.newToolStripMenuItem1.Size = new Size(224, 28);
			this.newToolStripMenuItem1.Text = "&New";
			this.newToolStripMenuItem1.Click += this.OnIssueNew;
			// 
			// editToolStripMenuItem1
			// 
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.Size = new Size(224, 28);
			this.editToolStripMenuItem1.Text = "&Edit";
			this.editToolStripMenuItem1.Click += this.OnIssueEdit;
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new Size(224, 28);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += this.OnIssueDelete;
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.settingsToolStripMenuItem });
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new Size(79, 28);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new Size(224, 28);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.Click += this.OnToolsSettings;
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.aboutToolStripMenuItem });
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new Size(68, 28);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new Size(224, 28);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += this.OnHelpAbout;
			// 
			// _tsBugLite
			// 
			this._tsBugLite.AutoSize = false;
			this._tsBugLite.ImageScalingSize = new Size(20, 20);
			this._tsBugLite.Items.AddRange(new ToolStripItem[] { this._lblProjectInfo });
			this._tsBugLite.Location = new Point(0, 32);
			this._tsBugLite.Name = "_tsBugLite";
			this._tsBugLite.Size = new Size(1115, 40);
			this._tsBugLite.TabIndex = 1;
			this._tsBugLite.Text = "toolStrip1";
			// 
			// _lblProjectInfo
			// 
			this._lblProjectInfo.Font = new Font("Consolas", 14F, FontStyle.Bold);
			this._lblProjectInfo.ForeColor = Color.MediumBlue;
			this._lblProjectInfo.Name = "_lblProjectInfo";
			this._lblProjectInfo.Size = new Size(103, 37);
			this._lblProjectInfo.Text = "Default";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new Size(20, 20);
			this.statusStrip1.Location = new Point(0, 554);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(1115, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// _tlpBugLite
			// 
			this._tlpBugLite.ColumnCount = 1;
			this._tlpBugLite.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpBugLite.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			this._tlpBugLite.Dock = DockStyle.Fill;
			this._tlpBugLite.Location = new Point(0, 72);
			this._tlpBugLite.Name = "_tlpBugLite";
			this._tlpBugLite.RowCount = 1;
			this._tlpBugLite.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpBugLite.Size = new Size(1115, 482);
			this._tlpBugLite.TabIndex = 3;
			// 
			// BugLiteForm
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(1115, 576);
			this.Controls.Add(this._tlpBugLite);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this._tsBugLite);
			this.Controls.Add(this._msBugLite);
			this.Font = new Font("Consolas", 10F);
			this.MainMenuStrip = this._msBugLite;
			this.Name = "BugLiteForm";
			this.Text = "Bug Lite (LeanCore) 1.0.0.0";
			this.WindowState = FormWindowState.Maximized;
			this._msBugLite.ResumeLayout(false);
			this._msBugLite.PerformLayout();
			this._tsBugLite.ResumeLayout(false);
			this._tsBugLite.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private MenuStrip _msBugLite;
		private ToolStrip _tsBugLite;
		private StatusStrip statusStrip1;
		private TableLayoutPanel _tlpBugLite;
		private Library.Gui.Controls.IssueCollectionControl _ctrlIssueCollection;
		private ToolStripLabel _lblProjectInfo;
		private ToolStripMenuItem projectToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem closeToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem loadToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem quitToolStripMenuItem;
		private ToolStripMenuItem issueToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem1;
		private ToolStripMenuItem editToolStripMenuItem1;
		private ToolStripMenuItem deleteToolStripMenuItem;
		private ToolStripMenuItem toolsToolStripMenuItem;
		private ToolStripMenuItem settingsToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
	}
}
