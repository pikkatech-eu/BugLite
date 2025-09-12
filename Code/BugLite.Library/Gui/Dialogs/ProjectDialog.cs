/***********************************************************************************
* File:         ProjectDialog.cs                                                  *
* Contents:     Class ProjectDialog                                               *
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
	public partial class ProjectDialog : Form, IProjectDevice
	{
		public ProjectDialog()
		{
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Project Project
		{
			get
			{
				return this._ctrlProject.Project;
			}

			set
			{
				this._ctrlProject.Project = value;
			}
		}
	}
}
