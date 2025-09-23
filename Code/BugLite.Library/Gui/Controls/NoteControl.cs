/***********************************************************************************
* File:         NoteControl.cs                                                     *
* Contents:     Class NoteControl                                                  *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-23 21:11                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using BugLite.Library.Domain;
using BugLite.Library.Gui.Interfaces;

namespace BugLite.Library.Gui.Controls
{
	public partial class NoteControl : UserControl, INoteDevice
	{
		public NoteControl()
		{
			InitializeComponent();

			this._lblDateTime.Text	= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Note Note
		{
			get
			{
				Note note	= new Note();
				note.Text	= this._txNote.Text;

				return note;
			}

			set
			{
				this._lblDateTime.Text	= value.Created.ToString("yyyy-MM-dd HH:mm:ss");
				this._txNote.Text		= value.Text;
			}
		}
	}
}
