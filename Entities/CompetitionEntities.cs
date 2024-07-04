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
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                //Console.WriteLine(Directory.GetCurrentDirectory());
                var connectionString = configuration.GetConnectionString("connection_string");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Adding unique constraint for competition.Name:
            modelBuilder.Entity<Competition>()
                .HasIndex(c => c.Name)
                .IsUnique();
            modelBuilder.Entity<Competition>().HasData(GetCompetitions());

            // Adding composite unique key so we only have one player per name and competition:
            // This also makes it harder to allow Nullable Competitor.CompetitionId?
            // Could have added some testcases to show what the DB allows and to document what it will respond.
            modelBuilder.Entity<Competitor>()
                .HasIndex(c => new { c.CompetitionId, c.Name })
                .IsUnique();
            modelBuilder.Entity<Competitor>().HasData(GetCompetitors());
        }

        private List<Competition> GetCompetitions()
        {
            return Enumerable.Range(1, 20)
                .Select(i => new Competition
                {
                    CompetitionId = i,
                    Name = $"Competition_{i}"
                }).ToList();
        }
        private List<Competitor> GetCompetitors()
        {
            var competitors = new List<Competitor>();
            int i = 1;
            for (int j = 1; j <= 20; j++)
            {
                competitors.Add(new Competitor { CompetitorId = i, Name = $"Karl_{j}", CompetitionId = j });
                i++;
                competitors.Add(new Competitor { CompetitorId = i, Name = $"Bertil_{j}", CompetitionId = j });
                i++;
            }
            return competitors;
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
