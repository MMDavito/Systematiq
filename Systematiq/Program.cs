using System;
using Entities;
using Libraries;
using Microsoft.IdentityModel.Tokens;

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
        private static void Task2()
        {
            throw new NotImplementedException();
        }
        private static void Task3()
        {
            throw new NotImplementedException();
        }
    }
}