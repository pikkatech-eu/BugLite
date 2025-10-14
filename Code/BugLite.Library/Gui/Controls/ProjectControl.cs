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
	/// <summary>
	/// Implements a GUI control to handle instances of Project.
	/// </summary>
	public partial class ProjectControl : UserControl, IProjectDevice
	{
		#region Construction
		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProjectControl()
		{
			InitializeComponent();
		} 
		#endregion

		#region IProjectDevice
		/// <summary>
		/// Gets an instance of Project from GUI and sets it to GUI.
		/// </summary>
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
				if (value != null)
				{
					this._txName.Text			= value.Name;
					this._txDescription.Text	= value.Description;
				}
			}
		}
		#endregion
	}
}
