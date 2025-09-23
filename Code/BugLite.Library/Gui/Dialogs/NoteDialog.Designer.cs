namespace BugLite.Library.Gui.Dialogs
{
	partial class NoteDialog
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteDialog));
			this._btOK = new Button();
			this._btCancel = new Button();
			this._ctrlNote = new BugLite.Library.Gui.Controls.NoteControl();
			this.SuspendLayout();
			// 
			// _btOK
			// 
			this._btOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOK.BackColor = Color.FromArgb(0, 48, 96);
			this._btOK.DialogResult = DialogResult.OK;
			this._btOK.Location = new Point(9, 338);
			this._btOK.Margin = new Padding(0);
			this._btOK.Name = "_btOK";
			this._btOK.Size = new Size(80, 32);
			this._btOK.TabIndex = 0;
			this._btOK.Text = "OK";
			this._btOK.UseVisualStyleBackColor = false;
			// 
			// _btCancel
			// 
			this._btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btCancel.BackColor = Color.FromArgb(0, 48, 96);
			this._btCancel.DialogResult = DialogResult.Cancel;
			this._btCancel.Location = new Point(114, 338);
			this._btCancel.Margin = new Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new Size(80, 32);
			this._btCancel.TabIndex = 0;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = false;
			// 
			// _ctrlNote
			// 
			this._ctrlNote.BackColor = Color.FromArgb(0, 48, 96);
			this._ctrlNote.Dock = DockStyle.Top;
			this._ctrlNote.Font = new Font("Consolas", 10F);
			this._ctrlNote.ForeColor = Color.White;
			this._ctrlNote.Location = new Point(0, 0);
			this._ctrlNote.Margin = new Padding(0);
			this._ctrlNote.Name = "_ctrlNote";
			this._ctrlNote.Size = new Size(800, 322);
			this._ctrlNote.TabIndex = 1;
			// 
			// NoteDialog
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.ClientSize = new Size(800, 379);
			this.Controls.Add(this._ctrlNote);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOK);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "NoteDialog";
			this.Text = "Note Properties";
			this.ResumeLayout(false);
		}

		#endregion

		private Button _btOK;
		private Button _btCancel;
		private Controls.NoteControl _ctrlNote;
	}
}