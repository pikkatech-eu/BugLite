namespace BugLite.Library.Gui.Controls
{
	partial class NoteControl
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
			this._lblDateTime = new Label();
			this.label1 = new Label();
			this._txNote = new TextBox();
			this._tlpUserControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tlpUserControl
			// 
			this._tlpUserControl.ColumnCount = 1;
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			this._tlpUserControl.Controls.Add(this._lblDateTime, 0, 0);
			this._tlpUserControl.Controls.Add(this.label1, 0, 1);
			this._tlpUserControl.Controls.Add(this._txNote, 0, 2);
			this._tlpUserControl.Dock = DockStyle.Fill;
			this._tlpUserControl.Location = new Point(0, 0);
			this._tlpUserControl.Margin = new Padding(0);
			this._tlpUserControl.Name = "_tlpUserControl";
			this._tlpUserControl.RowCount = 3;
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpUserControl.Size = new Size(320, 400);
			this._tlpUserControl.TabIndex = 0;
			// 
			// _lblDateTime
			// 
			this._lblDateTime.AutoSize = true;
			this._lblDateTime.Dock = DockStyle.Fill;
			this._lblDateTime.Location = new Point(3, 0);
			this._lblDateTime.Name = "_lblDateTime";
			this._lblDateTime.Size = new Size(314, 28);
			this._lblDateTime.TabIndex = 0;
			this._lblDateTime.Text = "***";
			this._lblDateTime.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(0, 28);
			this.label1.Margin = new Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(320, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Note Text:";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// _txNote
			// 
			this._txNote.Dock = DockStyle.Fill;
			this._txNote.Location = new Point(3, 51);
			this._txNote.Multiline = true;
			this._txNote.Name = "_txNote";
			this._txNote.Size = new Size(314, 346);
			this._txNote.TabIndex = 2;
			// 
			// NoteControl
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.Controls.Add(this._tlpUserControl);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Margin = new Padding(0);
			this.Name = "NoteControl";
			this.Size = new Size(320, 400);
			this._tlpUserControl.ResumeLayout(false);
			this._tlpUserControl.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel _tlpUserControl;
		private Label _lblDateTime;
		private Label label1;
		private TextBox _txNote;
	}
}
