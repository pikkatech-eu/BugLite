using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugLite.Library.Domain;

namespace BugLite.Tests
{
	public static class Program
	{
		public static void Main()
		{
			Console.WriteLine("Hello BugLite!");

			Project project = new Project();

			project.ProjectId	= 729;
			project.Name = "Test project";
			project.Description	= "Pryde chamber romulus dust proudstar jackpot tinkerer stick cannonball speedball. " +
								  "X-factor echo lukecage moonknight madthinker blackheart annihilus ricochet scrambler " +
								  "microchip warbound vision.";


			Issue issue1 = new Issue();
			issue1.IssueId	= 42;
			issue1.ProjectId = project.ProjectId;
			issue1.Title	= "First Issue";
			issue1.Details	= "Enchantress destiny invaders deathlok warpath mojo whirlwind cuckoos";
			issue1.Status	= Library.Domain.Enumerations.IssueStatus.Open;

			project.Issues.Add(issue1.IssueId, issue1);

			// TODO: add an issue, convert to JSON and back again
		}
	}
}
