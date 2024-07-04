using System;
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
        }

        private static void CreateDbIfNotExists() { }

    }
}