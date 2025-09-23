/***********************************************************************************
* File:         Note.cs                                                            *
* Contents:     Class Note                                                         *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-23 20:19                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace BugLite.Library.Domain
{
	public class Note
	{
		#region Properties
		public DateTime	Created	{get;set;}	= DateTime.Now;

		public string	Text	{get;set;} = "";
		#endregion
	}
}
