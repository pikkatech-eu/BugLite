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
			this._cxStatus = new ComboBox();
			this._lblIssue = new Label();
			this.label5 = new Label();
			this.label3 = new Label();
			this.label1 = new Label();
			this._cxSeverity = new ComboBox();
			this._cxPriority = new ComboBox();
			this._tlpMain = new TableLayoutPanel();
			this.label6 = new Label();
			this.label2 = new Label();
			this.label4 = new Label();
			this._txTitle = new TextBox();
			this._tcIssue = new TabControl();
			this._tpIssueMain = new TabPage();
			this._tpAdditional = new TabPage();
			this._tpNotes = new TabPage();
			this._tlpMain.SuspendLayout();
			this._tcIssue.SuspendLayout();
			this._tpIssueMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// _txDescription
			// 
			this._tlpMain.SetColumnSpan(this._txDescription, 3);
			this._txDescription.Dock = DockStyle.Fill;
			this._txDescription.Location = new Point(131, 107);
			this._txDescription.Multiline = true;
			this._txDescription.Name = "_txDescription";
			this._txDescription.Size = new Size(417, 297);
			this._txDescription.TabIndex = 9;
			// 
			// _cxStatus
			// 
			this._cxStatus.Dock = DockStyle.Fill;
			this._cxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxStatus.FormattingEnabled = true;
			this._cxStatus.Location = new Point(131, 51);
			this._cxStatus.Name = "_cxStatus";
			this._cxStatus.Size = new Size(134, 28);
			this._cxStatus.TabIndex = 7;
			// 
			// _lblIssue
			// 
			this._lblIssue.AutoSize = true;
			this._lblIssue.Dock = DockStyle.Fill;
			this._lblIssue.Location = new Point(131, 0);
			this._lblIssue.Name = "_lblIssue";
			this._lblIssue.Size = new Size(134, 28);
			this._lblIssue.TabIndex = 5;
			this._lblIssue.Text = "0";
			this._lblIssue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = DockStyle.Right;
			this.label5.Location = new Point(17, 104);
			this.label5.Name = "label5";
			this.label5.Size = new Size(108, 303);
			this.label5.TabIndex = 4;
			this.label5.Text = "Description";
			this.label5.TextAlign = ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Left;
			this.label3.Location = new Point(131, 28);
			this.label3.Name = "label3";
			this.label3.Size = new Size(63, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Status";
			this.label3.TextAlign = ContentAlignment.MiddleLeft;
			this.label3.UseCompatibleTextRendering = true;
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
			// _cxSeverity
			// 
			this._cxSeverity.Dock = DockStyle.Fill;
			this._cxSeverity.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxSeverity.FormattingEnabled = true;
			this._cxSeverity.Location = new Point(271, 51);
			this._cxSeverity.Name = "_cxSeverity";
			this._cxSeverity.Size = new Size(134, 28);
			this._cxSeverity.TabIndex = 12;
			// 
			// _cxPriority
			// 
			this._cxPriority.Dock = DockStyle.Fill;
			this._cxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxPriority.FormattingEnabled = true;
			this._cxPriority.Location = new Point(411, 51);
			this._cxPriority.Name = "_cxPriority";
			this._cxPriority.Size = new Size(137, 28);
			this._cxPriority.TabIndex = 13;
			// 
			// _tlpMain
			// 
			this._tlpMain.ColumnCount = 4;
			this._tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
			this._tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			this._tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			this._tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			this._tlpMain.Controls.Add(this.label6, 3, 1);
			this._tlpMain.Controls.Add(this.label2, 2, 1);
			this._tlpMain.Controls.Add(this._cxPriority, 3, 2);
			this._tlpMain.Controls.Add(this._cxSeverity, 2, 2);
			this._tlpMain.Controls.Add(this.label1, 0, 0);
			this._tlpMain.Controls.Add(this.label3, 1, 1);
			this._tlpMain.Controls.Add(this.label4, 0, 3);
			this._tlpMain.Controls.Add(this.label5, 0, 4);
			this._tlpMain.Controls.Add(this._lblIssue, 1, 0);
			this._tlpMain.Controls.Add(this._cxStatus, 1, 2);
			this._tlpMain.Controls.Add(this._txTitle, 1, 3);
			this._tlpMain.Controls.Add(this._txDescription, 1, 4);
			this._tlpMain.Dock = DockStyle.Fill;
			this._tlpMain.Location = new Point(0, 0);
			this._tlpMain.Margin = new Padding(0);
			this._tlpMain.Name = "_tlpMain";
			this._tlpMain.RowCount = 5;
			this._tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			this._tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
			this._tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
			this._tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpMain.Size = new Size(551, 407);
			this._tlpMain.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = DockStyle.Left;
			this.label6.Location = new Point(411, 28);
			this.label6.Name = "label6";
			this.label6.Size = new Size(82, 20);
			this.label6.TabIndex = 15;
			this.label6.Text = "Priority";
			this.label6.TextAlign = ContentAlignment.MiddleLeft;
			this.label6.UseCompatibleTextRendering = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = DockStyle.Left;
			this.label2.Location = new Point(271, 28);
			this.label2.Name = "label2";
			this.label2.Size = new Size(82, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "Severity";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			this.label2.UseCompatibleTextRendering = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = DockStyle.Right;
			this.label4.Location = new Point(71, 75);
			this.label4.Name = "label4";
			this.label4.Size = new Size(54, 29);
			this.label4.TabIndex = 3;
			this.label4.Text = "Title";
			this.label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _txTitle
			// 
			this._tlpMain.SetColumnSpan(this._txTitle, 3);
			this._txTitle.Dock = DockStyle.Fill;
			this._txTitle.Location = new Point(131, 78);
			this._txTitle.Name = "_txTitle";
			this._txTitle.Size = new Size(417, 27);
			this._txTitle.TabIndex = 8;
			// 
			// _tcIssue
			// 
			this._tcIssue.Controls.Add(this._tpIssueMain);
			this._tcIssue.Controls.Add(this._tpAdditional);
			this._tcIssue.Controls.Add(this._tpNotes);
			this._tcIssue.Dock = DockStyle.Fill;
			this._tcIssue.Location = new Point(0, 0);
			this._tcIssue.Margin = new Padding(0);
			this._tcIssue.Name = "_tcIssue";
			this._tcIssue.SelectedIndex = 0;
			this._tcIssue.Size = new Size(559, 440);
			this._tcIssue.TabIndex = 1;
			// 
			// _tpIssueMain
			// 
			this._tpIssueMain.Controls.Add(this._tlpMain);
			this._tpIssueMain.Location = new Point(4, 29);
			this._tpIssueMain.Margin = new Padding(0);
			this._tpIssueMain.Name = "_tpIssueMain";
			this._tpIssueMain.Size = new Size(551, 407);
			this._tpIssueMain.TabIndex = 0;
			this._tpIssueMain.Text = "Main";
			this._tpIssueMain.UseVisualStyleBackColor = true;
			// 
			// _tpAdditional
			// 
			this._tpAdditional.Location = new Point(4, 29);
			this._tpAdditional.Margin = new Padding(0);
			this._tpAdditional.Name = "_tpAdditional";
			this._tpAdditional.Size = new Size(551, 407);
			this._tpAdditional.TabIndex = 1;
			this._tpAdditional.Text = "Additional";
			this._tpAdditional.UseVisualStyleBackColor = true;
			// 
			// _tpNotes
			// 
			this._tpNotes.Location = new Point(4, 29);
			this._tpNotes.Margin = new Padding(0);
			this._tpNotes.Name = "_tpNotes";
			this._tpNotes.Size = new Size(551, 407);
			this._tpNotes.TabIndex = 2;
			this._tpNotes.Text = "Notes";
			this._tpNotes.UseVisualStyleBackColor = true;
			// 
			// IssueControl
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.Controls.Add(this._tcIssue);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Margin = new Padding(0);
			this.Name = "IssueControl";
			this.Size = new Size(559, 440);
			this._tlpMain.ResumeLayout(false);
			this._tlpMain.PerformLayout();
			this._tcIssue.ResumeLayout(false);
			this._tpIssueMain.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private TextBox _txDescription;
		private ComboBox _cxStatus;
		private Label _lblIssue;
		private Label label5;
		private Label label3;
		private Label label1;
		private ComboBox _cxSeverity;
		private ComboBox _cxPriority;
		private TableLayoutPanel _tlpMain;
		private Label label4;
		private TextBox _txTitle;
		private Label label2;
		private Label label6;
		private TabControl _tcIssue;
		private TabPage _tpIssueMain;
		private TabPage _tpAdditional;
		private TabPage _tpNotes;
	}
}
