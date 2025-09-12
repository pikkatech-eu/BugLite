namespace BugLite.Library.Gui.Controls
{
	partial class IssueControl
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
			this._tlpUserControl = new TableLayoutPanel();
			this._lblProject = new Label();
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this._lblIssue = new Label();
			this._cxStatus = new ComboBox();
			this._txTitle = new TextBox();
			this._txDescription = new TextBox();
			this._tlpUserControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tlpUserControl
			// 
			this._tlpUserControl.ColumnCount = 2;
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpUserControl.Controls.Add(this._lblProject, 1, 1);
			this._tlpUserControl.Controls.Add(this.label1, 0, 0);
			this._tlpUserControl.Controls.Add(this.label2, 0, 1);
			this._tlpUserControl.Controls.Add(this.label3, 0, 2);
			this._tlpUserControl.Controls.Add(this.label4, 0, 3);
			this._tlpUserControl.Controls.Add(this.label5, 0, 4);
			this._tlpUserControl.Controls.Add(this._lblIssue, 1, 0);
			this._tlpUserControl.Controls.Add(this._cxStatus, 1, 2);
			this._tlpUserControl.Controls.Add(this._txTitle, 1, 3);
			this._tlpUserControl.Controls.Add(this._txDescription, 1, 4);
			this._tlpUserControl.Dock = DockStyle.Fill;
			this._tlpUserControl.Location = new Point(0, 0);
			this._tlpUserControl.Margin = new Padding(0);
			this._tlpUserControl.Name = "_tlpUserControl";
			this._tlpUserControl.RowCount = 5;
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpUserControl.Size = new Size(408, 400);
			this._tlpUserControl.TabIndex = 0;
			// 
			// _lblProject
			// 
			this._lblProject.AutoSize = true;
			this._lblProject.Dock = DockStyle.Fill;
			this._lblProject.Location = new Point(131, 28);
			this._lblProject.Name = "_lblProject";
			this._lblProject.Size = new Size(274, 28);
			this._lblProject.TabIndex = 6;
			this._lblProject.Text = "Default";
			this._lblProject.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Right;
			this.label1.Location = new Point(44, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(81, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Issue ID";
			this.label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = DockStyle.Right;
			this.label2.Location = new Point(53, 28);
			this.label2.Name = "label2";
			this.label2.Size = new Size(72, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Project";
			this.label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Right;
			this.label3.Location = new Point(62, 56);
			this.label3.Name = "label3";
			this.label3.Size = new Size(63, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Status";
			this.label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = DockStyle.Right;
			this.label4.Location = new Point(71, 84);
			this.label4.Name = "label4";
			this.label4.Size = new Size(54, 28);
			this.label4.TabIndex = 3;
			this.label4.Text = "Title";
			this.label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = DockStyle.Right;
			this.label5.Location = new Point(17, 112);
			this.label5.Name = "label5";
			this.label5.Size = new Size(108, 288);
			this.label5.TabIndex = 4;
			this.label5.Text = "Description";
			this.label5.TextAlign = ContentAlignment.TopRight;
			// 
			// _lblIssue
			// 
			this._lblIssue.AutoSize = true;
			this._lblIssue.Dock = DockStyle.Fill;
			this._lblIssue.Location = new Point(131, 0);
			this._lblIssue.Name = "_lblIssue";
			this._lblIssue.Size = new Size(274, 28);
			this._lblIssue.TabIndex = 5;
			this._lblIssue.Text = "0";
			this._lblIssue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// _cxStatus
			// 
			this._cxStatus.Dock = DockStyle.Fill;
			this._cxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxStatus.FormattingEnabled = true;
			this._cxStatus.Location = new Point(131, 59);
			this._cxStatus.Name = "_cxStatus";
			this._cxStatus.Size = new Size(274, 28);
			this._cxStatus.TabIndex = 7;
			// 
			// _txTitle
			// 
			this._txTitle.Dock = DockStyle.Fill;
			this._txTitle.Location = new Point(131, 87);
			this._txTitle.Name = "_txTitle";
			this._txTitle.Size = new Size(274, 27);
			this._txTitle.TabIndex = 8;
			// 
			// _txDescription
			// 
			this._txDescription.Dock = DockStyle.Fill;
			this._txDescription.Location = new Point(131, 115);
			this._txDescription.Multiline = true;
			this._txDescription.Name = "_txDescription";
			this._txDescription.Size = new Size(274, 282);
			this._txDescription.TabIndex = 9;
			// 
			// IssueControl
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.Controls.Add(this._tlpUserControl);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Margin = new Padding(0);
			this.Name = "IssueControl";
			this.Size = new Size(408, 400);
			this._tlpUserControl.ResumeLayout(false);
			this._tlpUserControl.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel _tlpUserControl;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label _lblIssue;
		private Label _lblProject;
		private ComboBox _cxStatus;
		private TextBox _txTitle;
		private TextBox _txDescription;
	}
}
