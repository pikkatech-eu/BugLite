/***********************************************************************************
* File:         Settings.cs                                                        *
* Contents:     Class Settings                                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-11 14:06                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Management
{
	public static class Settings
	{
		private static readonly string DEFAULT_PROJECT_REPOSITORY	= "default_project.xml";

		public static string ProjectRepository
		{
			get
			{
				return DEFAULT_PROJECT_REPOSITORY;
			}
		}

	}
}
