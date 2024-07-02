using Microsoft.EntityFrameworkCore;
// add a reference to System.ComponentModel.DataAnnotations DLL
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;


namespace Entities
{
    public class CompetitionEntities : DbContext
    {
        public DbSet<Competition> Competitions { get; set; }
    }

    public class Competition
    {
        public int CompetitionId { get; set; }
        public string Name { get; set; }
        public ICollection<Competitor> Competitors { get; set; } = new List<Competitor>();
    }
    public class Competitor
    {
        public int CompetitorId { get; set; }
        public string Name { get; set; }
        public int CompetitionId { get; set; }
        public virtual CompetitionEntities Competition { get; set; } = null!;
    }
}
