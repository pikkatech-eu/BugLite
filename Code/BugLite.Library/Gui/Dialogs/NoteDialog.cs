/***********************************************************************************
* File:         NoteDialog.cs                                                  *
* Contents:     Class NoteDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using BugLite.Library.Domain;
using BugLite.Library.Gui.Interfaces;

namespace BugLite.Library.Gui.Dialogs
{
	public partial class NoteDialog : Form, INoteDevice
	{
		public NoteDialog()
		{
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Note Note
		{
			get
			{
				return this._ctrlNote.Note;
			}

			set
			{
				this._ctrlNote.Note = value;
			}
		}
	}
}
