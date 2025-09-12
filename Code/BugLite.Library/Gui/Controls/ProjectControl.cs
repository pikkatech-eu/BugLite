/***********************************************************************************
* File:         ProjectControl.cs                                                  *
* Contents:     Class ProjectControl                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 23:06                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using BugLite.Library.Domain;
using BugLite.Library.Gui.Interfaces;
using System.ComponentModel;

namespace BugLite.Library.Gui.Controls
{
	public partial class ProjectControl : UserControl, IProjectDevice
	{
		public ProjectControl()
		{
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Project Project
		{
			get
			{
				Project project		= new Project();
				project.Name		= this._txName.Text;
				project.Description	= this._txDescription.Text;

				return project;
			}

			set
			{
				this._txName.Text			= value.Name;
				this._txDescription.Text	= value.Description;
			}
		}
	}
}
