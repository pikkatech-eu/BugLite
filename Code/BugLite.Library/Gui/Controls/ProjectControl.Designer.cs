namespace BugLite.Library.Gui.Controls
{
	partial class ProjectControl
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
			this.label1 = new Label();
			this.label2 = new Label();
			this._txName = new TextBox();
			this._txDescription = new TextBox();
			this._tlpUserControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tlpUserControl
			// 
			this._tlpUserControl.ColumnCount = 2;
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpUserControl.Controls.Add(this.label1, 0, 0);
			this._tlpUserControl.Controls.Add(this.label2, 0, 1);
			this._tlpUserControl.Controls.Add(this._txName, 1, 0);
			this._tlpUserControl.Controls.Add(this._txDescription, 1, 1);
			this._tlpUserControl.Dock = DockStyle.Fill;
			this._tlpUserControl.Location = new Point(0, 0);
			this._tlpUserControl.Margin = new Padding(0);
			this._tlpUserControl.Name = "_tlpUserControl";
			this._tlpUserControl.RowCount = 3;
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpUserControl.RowStyles.Add(new RowStyle());
			this._tlpUserControl.Size = new Size(320, 400);
			this._tlpUserControl.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(122, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = DockStyle.Fill;
			this.label2.Location = new Point(3, 28);
			this.label2.Name = "label2";
			this.label2.Size = new Size(122, 372);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description";
			this.label2.TextAlign = ContentAlignment.TopRight;
			// 
			// _txName
			// 
			this._txName.Dock = DockStyle.Fill;
			this._txName.Location = new Point(131, 3);
			this._txName.Name = "_txName";
			this._txName.Size = new Size(186, 27);
			this._txName.TabIndex = 2;
			// 
			// _txDescription
			// 
			this._txDescription.Dock = DockStyle.Fill;
			this._txDescription.Location = new Point(131, 31);
			this._txDescription.Multiline = true;
			this._txDescription.Name = "_txDescription";
			this._txDescription.Size = new Size(186, 366);
			this._txDescription.TabIndex = 3;
			// 
			// ProjectControl
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.Controls.Add(this._tlpUserControl);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Margin = new Padding(0);
			this.Name = "ProjectControl";
			this.Size = new Size(320, 400);
			this._tlpUserControl.ResumeLayout(false);
			this._tlpUserControl.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel _tlpUserControl;
		private Label label1;
		private Label label2;
		private TextBox _txName;
		private TextBox _txDescription;
	}
}
