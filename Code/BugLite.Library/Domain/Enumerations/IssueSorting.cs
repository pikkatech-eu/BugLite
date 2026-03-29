/***********************************************************************************
* File:         IssueSorting.cs                                                    *
* Contents:     Enum IssueSorting                                                  *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-29 13:30                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json.Serialization;

namespace BugLite.Library.Domain.Enumerations
{
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum IssueSorting
	{
		None = 0,
		Id = 1,
		CreationDate = 2,
		ModificationDate = 3,
		Status = 4,
		Severity = 5,
		Priority = 6
	}
}
