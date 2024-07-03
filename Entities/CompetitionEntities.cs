using Microsoft.EntityFrameworkCore;
// add a reference to System.ComponentModel.DataAnnotations DLL
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class CompetitionEntities : DbContext
    {
        public DbSet<Competition> Competitions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            if (true)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                Console.WriteLine(Directory.GetCurrentDirectory());
                var connectionString = configuration.GetConnectionString("connection_string");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }

    public class Competition
    {
        public int CompetitionId { get; set; }
        public string Name { get; set; }
        public ICollection<Competitor> Competitors { get; set; } = new List<Competitor>();
    }
    
    [Table("Competitors")]
    public class Competitor
    {
        public int CompetitorId { get; set; }
        public string Name { get; set; }
        public int CompetitionId { get; set; }
        public virtual CompetitionEntities Competition { get; set; } = null!;
    }
}
