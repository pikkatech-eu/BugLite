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
			this._txDescription = new TextBox();
			this._txTitle = new TextBox();
			this._cxStatus = new ComboBox();
			this._lblIssue = new Label();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.label1 = new Label();
			this.label6 = new Label();
			this.label7 = new Label();
			this._cxSeverity = new ComboBox();
			this._cxPriority = new ComboBox();
			this._tlpUserControl = new TableLayoutPanel();
			this._tlpUserControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// _txDescription
			// 
			this._txDescription.Dock = DockStyle.Fill;
			this._txDescription.Location = new Point(131, 143);
			this._txDescription.Multiline = true;
			this._txDescription.Name = "_txDescription";
			this._txDescription.Size = new Size(425, 294);
			this._txDescription.TabIndex = 9;
			// 
			// _txTitle
			// 
			this._txTitle.Dock = DockStyle.Fill;
			this._txTitle.Location = new Point(131, 115);
			this._txTitle.Name = "_txTitle";
			this._txTitle.Size = new Size(425, 27);
			this._txTitle.TabIndex = 8;
			// 
			// _cxStatus
			// 
			this._cxStatus.Dock = DockStyle.Fill;
			this._cxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxStatus.FormattingEnabled = true;
			this._cxStatus.Location = new Point(131, 31);
			this._cxStatus.Name = "_cxStatus";
			this._cxStatus.Size = new Size(425, 28);
			this._cxStatus.TabIndex = 7;
			// 
			// _lblIssue
			// 
			this._lblIssue.AutoSize = true;
			this._lblIssue.Dock = DockStyle.Fill;
			this._lblIssue.Location = new Point(131, 0);
			this._lblIssue.Name = "_lblIssue";
			this._lblIssue.Size = new Size(425, 28);
			this._lblIssue.TabIndex = 5;
			this._lblIssue.Text = "0";
			this._lblIssue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = DockStyle.Right;
			this.label5.Location = new Point(17, 140);
			this.label5.Name = "label5";
			this.label5.Size = new Size(108, 300);
			this.label5.TabIndex = 4;
			this.label5.Text = "Description";
			this.label5.TextAlign = ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = DockStyle.Right;
			this.label4.Location = new Point(71, 112);
			this.label4.Name = "label4";
			this.label4.Size = new Size(54, 28);
			this.label4.TabIndex = 3;
			this.label4.Text = "Title";
			this.label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Right;
			this.label3.Location = new Point(62, 28);
			this.label3.Name = "label3";
			this.label3.Size = new Size(63, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Status";
			this.label3.TextAlign = ContentAlignment.MiddleRight;
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = DockStyle.Right;
			this.label6.Location = new Point(44, 56);
			this.label6.Name = "label6";
			this.label6.Size = new Size(81, 28);
			this.label6.TabIndex = 10;
			this.label6.Text = "Severity";
			this.label6.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = DockStyle.Right;
			this.label7.Location = new Point(44, 84);
			this.label7.Name = "label7";
			this.label7.Size = new Size(81, 28);
			this.label7.TabIndex = 11;
			this.label7.Text = "Priority";
			this.label7.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _cxSeverity
			// 
			this._cxSeverity.Dock = DockStyle.Fill;
			this._cxSeverity.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxSeverity.FormattingEnabled = true;
			this._cxSeverity.Location = new Point(131, 59);
			this._cxSeverity.Name = "_cxSeverity";
			this._cxSeverity.Size = new Size(425, 28);
			this._cxSeverity.TabIndex = 12;
			// 
			// _cxPriority
			// 
			this._cxPriority.Dock = DockStyle.Fill;
			this._cxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxPriority.FormattingEnabled = true;
			this._cxPriority.Location = new Point(131, 87);
			this._cxPriority.Name = "_cxPriority";
			this._cxPriority.Size = new Size(425, 28);
			this._cxPriority.TabIndex = 13;
			// 
			// _tlpUserControl
			// 
			this._tlpUserControl.ColumnCount = 2;
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpUserControl.Controls.Add(this._cxPriority, 1, 3);
			this._tlpUserControl.Controls.Add(this._cxSeverity, 1, 2);
			this._tlpUserControl.Controls.Add(this.label7, 0, 3);
			this._tlpUserControl.Controls.Add(this.label6, 0, 2);
			this._tlpUserControl.Controls.Add(this.label1, 0, 0);
			this._tlpUserControl.Controls.Add(this.label3, 0, 1);
			this._tlpUserControl.Controls.Add(this.label4, 0, 4);
			this._tlpUserControl.Controls.Add(this.label5, 0, 5);
			this._tlpUserControl.Controls.Add(this._lblIssue, 1, 0);
			this._tlpUserControl.Controls.Add(this._cxStatus, 1, 1);
			this._tlpUserControl.Controls.Add(this._txTitle, 1, 4);
			this._tlpUserControl.Controls.Add(this._txDescription, 1, 5);
			this._tlpUserControl.Dock = DockStyle.Fill;
			this._tlpUserControl.Location = new Point(0, 0);
			this._tlpUserControl.Margin = new Padding(0);
			this._tlpUserControl.Name = "_tlpUserControl";
			this._tlpUserControl.RowCount = 6;
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			this._tlpUserControl.Size = new Size(559, 440);
			this._tlpUserControl.TabIndex = 0;
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
			this.Size = new Size(559, 440);
			this._tlpUserControl.ResumeLayout(false);
			this._tlpUserControl.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private TextBox _txDescription;
		private TextBox _txTitle;
		private ComboBox _cxStatus;
		private Label _lblIssue;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label1;
		private Label label6;
		private Label label7;
		private ComboBox _cxSeverity;
		private ComboBox _cxPriority;
		private TableLayoutPanel _tlpUserControl;
	}
}
