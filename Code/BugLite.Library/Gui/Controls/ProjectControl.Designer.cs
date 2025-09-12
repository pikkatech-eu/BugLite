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
			this.SuspendLayout();
			// 
			// _tlpUserControl
			// 
			this._tlpUserControl.ColumnCount = 2;
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this._tlpUserControl.Dock = DockStyle.Fill;
			this._tlpUserControl.Location = new Point(0, 0);
			this._tlpUserControl.Margin = new Padding(0);
			this._tlpUserControl.Name = "_tlpUserControl";
			this._tlpUserControl.RowCount = 2;
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			this._tlpUserControl.Size = new Size(320, 400);
			this._tlpUserControl.TabIndex = 0;
			// 
			// ProjectControl
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.Controls.Add(this._tlpUserControl);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Margin = new Padding(0);
			this.Name = "ProjectControl";
			this.Size = new Size(320, 400);
			this.ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel _tlpUserControl;
	}
}
