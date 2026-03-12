/***********************************************************************************
* File:         Priority.cs                                                        *
* Contents:     Enum Priority                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-11 17:35                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json.Serialization;

namespace Jissue.Domain.Enumerations
{
	/// <summary>
	/// Priority of an issue.
	/// </summary>
	public enum Priority
	{
		None		= 0,	// #FFFFFF
		Lowest		= 1,	// #21FF00
		Low			= 2,	// #00E7A0
		LowMedium	= 3,	// #00D1EA
		Medium		= 4,	// #0071ED
		Medium2		= 5,	// #000FF0
		Medium3		= 6,	// #5400F3
		MediumHigh	= 7,	// #BA00F6
		High		= 8,	// #F900CD
		VeryHigh	= 9,	// #FC0068
		Highest		= 10	// #FF0000
	}
}
