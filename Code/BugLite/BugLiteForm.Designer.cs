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
			this.menuStrip1 = new MenuStrip();
			this.toolStrip1 = new ToolStrip();
			this.statusStrip1 = new StatusStrip();
			this._tlpBugLite = new TableLayoutPanel();
			this._ctrlIssueCollection = new BugLite.Library.Gui.Controls.IssueCollectionControl();
			this._tlpBugLite.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new Size(20, 20);
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(900, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new Size(20, 20);
			this.toolStrip1.Location = new Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new Size(900, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new Size(20, 20);
			this.statusStrip1.Location = new Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(900, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// _tlpBugLite
			// 
			this._tlpBugLite.ColumnCount = 2;
			this._tlpBugLite.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			this._tlpBugLite.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
			this._tlpBugLite.Controls.Add(this._ctrlIssueCollection, 1, 0);
			this._tlpBugLite.Dock = DockStyle.Fill;
			this._tlpBugLite.Location = new Point(0, 49);
			this._tlpBugLite.Name = "_tlpBugLite";
			this._tlpBugLite.RowCount = 1;
			this._tlpBugLite.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpBugLite.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			this._tlpBugLite.Size = new Size(900, 379);
			this._tlpBugLite.TabIndex = 3;
			// 
			// _ctrlIssueCollection
			// 
			this._ctrlIssueCollection.BackColor = Color.FromArgb(0, 48, 96);
			this._ctrlIssueCollection.Dock = DockStyle.Fill;
			this._ctrlIssueCollection.Font = new Font("Consolas", 10F);
			this._ctrlIssueCollection.ForeColor = Color.White;
			this._ctrlIssueCollection.Location = new Point(225, 0);
			this._ctrlIssueCollection.Margin = new Padding(0);
			this._ctrlIssueCollection.Name = "_ctrlIssueCollection";
			this._ctrlIssueCollection.Size = new Size(675, 379);
			this._ctrlIssueCollection.TabIndex = 0;
			// 
			// BugLiteForm
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(900, 450);
			this.Controls.Add(this._tlpBugLite);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new Font("Consolas", 10F);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "BugLiteForm";
			this.Text = "Bug Lite (LeanCore) 1.0.0.0";
			this.WindowState = FormWindowState.Maximized;
			this._tlpBugLite.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStrip toolStrip1;
		private StatusStrip statusStrip1;
		private TableLayoutPanel _tlpBugLite;
		private Library.Gui.Controls.IssueCollectionControl _ctrlIssueCollection;
	}
}
