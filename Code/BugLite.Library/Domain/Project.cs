/***********************************************************************************
* File:         Project.cs                                                         *
* Contents:     Class Project                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-12 10:01                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json;

namespace BugLite.Library.Domain
{
	/// <summary>
	/// Describes an issue project.
	/// LeanCore version.
	/// </summary>
	public class Project
	{
		#region Properties
		/// <summary>
		/// The name of the project.
		/// </summary>
		public string Name	{get;set;}	= "Default";

		/// <summary>
		/// A longer description.
		/// </summary>
		public string Description	{get;set;}	= "";

		/// <summary>
		/// Date/Time of project creation.
		/// </summary>
		public DateTime SubmittedOn	{get;set;} = DateTime.Now;

		/// <summary>
		/// Collection of the project's issues.
		/// Key: Issue ID
		/// Value: the issue.
		/// </summary>
		public Dictionary<int, Issue> Issues	{get;set;} = new Dictionary<int, Issue>();
		#endregion

		#region Serialization
		/// <summary>
		/// Converts the project to a JSON string.
		/// </summary>
		/// <returns>The JSON string, with indentation.</returns>
		public string ToJson()
		{
			var options = new JsonSerializerOptions {WriteIndented = true};
			return JsonSerializer.Serialize<Project>(this, options);
		}

		/// <summary>
		/// Creates a project from a JSON string.
		/// </summary>
		/// <param name="json">The JSON string to create from.</param>
		/// <returns>The project created.</returns>
		public static Project FromJson(string json)
		{
			return JsonSerializer.Deserialize<Project>(json);
		}

		/// <summary>
		/// Saves the project to a file.
		/// </summary>
		/// <param name="fileName">The name of the file to save under.</param>
		public void Save(string fileName)
		{
			using (StreamWriter writer = new StreamWriter(fileName))
			{
				string json	= this.ToJson();
				writer.Write(json);
			}
		}

		/// <summary>
		/// Loads a project feom a JSON file.
		/// </summary>
		/// <param name="fileName">The name of the file to create from.</param>
		/// <returns>An instance of Project, if succesful.s</returns>
		public static Project Load(string fileName)
		{
			using (StreamReader reader= new StreamReader(fileName))
			{
				string json	= reader.ReadToEnd();

				return FromJson(json);
			}
		}
		#endregion
	}
}
