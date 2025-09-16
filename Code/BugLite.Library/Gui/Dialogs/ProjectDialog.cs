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
using BugLite.Library.Management;

namespace BugLite.Library.Gui.Dialogs
{
	/// <summary>
	/// Implements a GUI dialog to handle instances of Project.
	/// </summary>
	public partial class ProjectDialog : Form, IProjectDevice
	{
		#region Construction
		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProjectDialog()
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
				return this._ctrlProject.Project;
			}

			set
			{
				this._ctrlProject.Project = value;
			}
		}
		#endregion

		private void OnOk(object sender, EventArgs e)
		{
		}
	}
}
