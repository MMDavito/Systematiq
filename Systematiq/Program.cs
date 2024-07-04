using Entities;
using Libraries;
using Microsoft.IdentityModel.Tokens;
using System.Data.SqlClient;
using System.Data;

namespace Systematiq
{
	internal class Program
	{
		private static string _welcomeMessage = $"Welcome, to continue follow following instruction:";
		private static string _instructionMessage = $"Choose 1 of the following options and end with pressing Enter" +
			$"{Environment.NewLine}1: Task 1 using EFCore" +
			$"{Environment.NewLine}2: Task 2 using ADO" +
			$"{Environment.NewLine}3: Task 3 sort Random numbers in swedish" +
			$"{Environment.NewLine}c: Close application";
		static void Main(string[] args)
		{
			// See https://aka.ms/new-console-template for more information
			Console.WriteLine(_welcomeMessage);
			while (true)
			{
				Console.WriteLine(_instructionMessage);

				var input = Console.ReadLine()!;
				int numberInput = 0;
				bool validInput = true;
				if (input.IsNullOrEmpty()) Console.WriteLine("Empty input!");
				else if (!int.TryParse(input, out numberInput))
				{
					if (input.ToLower().Equals("c")) break;
					else validInput = false;
				}
				else if (int.Parse(input) == 1) Task1();
				else if (int.Parse(input) == 2) Task2();
				else if (int.Parse(input) == 3) Task3();
				else validInput = false;

				if (!validInput) Console.WriteLine("Invalid input!");
				Console.WriteLine(Environment.NewLine);
				continue;
			}
		}

		/// <summary>
		/// Solves task 1:
		/// Use EFCORE and Linq to solve problem 1
		/// </summary>
		private static void Task1()
		{
			var lib = new CompetitionLibrary();

			Console.WriteLine("Fetching all comps:");
			var competitions = lib.GetCompetitions();
			foreach (Competition competition in competitions)
			{
				Console.WriteLine($"Competition: {competition.ToString()}, contains the following competitors:");
				foreach (Competitor competitor in competition.Competitors)
				{
					Console.WriteLine($"\t{competitor.ToString()}");
				}
			}
			Console.WriteLine("**************************");
			Console.WriteLine("Competition 20:");
			var comp20 = lib.GetCompetition(20);
			Console.WriteLine($"Competition: {comp20.ToString()}, contains the following competitors:");
			foreach (Competitor competitor in comp20.Competitors)
			{
				Console.WriteLine($"\t{competitor.ToString()}");
			}
		}

		/// <summary>
		/// Uses ADO to read all competitions and their related competitors from the DB.
		/// </summary>
		private static void Task2()
		{
			string connectionString = "Server=localhost\\SQLEXPRESS;Database=systematiq_competition;Trusted_Connection=True;TrustServerCertificate=True;";
			string queryString =
				@"SELECT Competitions.CompetitionId, Competitions.Name, Competitors.CompetitorId, Competitors.Name  
				FROM Competitions
				LEFT JOIN Competitors 
					ON Competitions.CompetitionId = Competitors.CompetitionId
				ORDER BY Competitions.CompetitionId;";

			var table = new DataTable();

			using (SqlConnection connection = new(connectionString))
			{
				SqlCommand command = new(queryString, connection);
				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					int lastRead = -1;
					List<Competitor> competitors = new List<Competitor>();
					while (reader.Read())
					{
						if ((int)reader[0] != lastRead)
						{
							if (lastRead != -1)
							{
								foreach (Competitor competitor in competitors)
								{
									Console.WriteLine($"\t{competitor.ToString()}");
								}
							}
							Console.WriteLine($"Competition: name: {reader[1]}, id: {reader[0]}, contains the following competitors:");
							lastRead = (int)reader[0];
							competitors = new List<Competitor>();
						}
						if (reader[3] == DBNull.Value) continue;
						competitors.Add(new Competitor { CompetitorId = (int)reader[2], Name = (string)reader[3] });
					}
					reader.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}

		/// <summary>
		/// Make a random list of 25 integers with values between 1 and 25
		/// Translate this to swedish, e.g. 1 == "Ett" and then sort it in alphabetical order.
		/// 
		/// Will not this always generate the same order?
		/// I will make 100 random integers instead and sort them so it actually does something than present a static view.
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		private static void Task3()
		{
			var rand = new Random();
			var swedishNumberHelper = new SwedishNumberHelper();

			Console.WriteLine("");
			int numberOfIntegers = 100;
			var unsortedNumbers = new List<int>();
			for (int i = 0; i < numberOfIntegers; i++)
			{
				unsortedNumbers.Add(rand.Next(1, 26));
			}
			Console.WriteLine("Original List:");
			Console.WriteLine(string.Join(", ", unsortedNumbers));
			var tuples = swedishNumberHelper.SortNumbersInSwedish(unsortedNumbers);

			Console.WriteLine($"{Environment.NewLine}List sorted by Swedish number representation:");
			var sortedNumbers = tuples.Select(tuple => tuple.Item2).ToList();
			Console.WriteLine(string.Join(", ", sortedNumbers));

			Console.WriteLine("Do you want them printed in swedish, type 'y' followed by enter, else just enter");
			string? input = Console.ReadLine();
			if (input.IsNullOrEmpty() || !input.ToLower().Equals("y")) return;

			Console.WriteLine($"{Environment.NewLine}Sorted and printed in swedish:");
			var sortedSwedish = tuples.Select(tuple => tuple.Item1).ToList();
			Console.WriteLine(string.Join(Environment.NewLine, sortedSwedish));
		}
	}
}