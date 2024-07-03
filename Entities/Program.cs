using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;

namespace Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new DbContextOptionsBuilder();
            IConfigurationRoot configuration = new ConfigurationBuilder()
                               .SetBasePath(Directory.GetCurrentDirectory())
                               .AddJsonFile("appsettings.json")
                               .Build();

            Console.WriteLine("bajs"+Environment.NewLine+Directory.GetCurrentDirectory());
            var connectionString = configuration.GetConnectionString("connection_string");
            builder.UseSqlServer(connectionString);

        }
    }
}