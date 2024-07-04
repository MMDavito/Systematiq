using System;
using Entities;
using Libraries;

namespace Systematiq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            //var connectionString = builder.Configuration.GetConnectionString("MyAppCs");
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

        private static void CreateDbIfNotExists() { }

    }
}