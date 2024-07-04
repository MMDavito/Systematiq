using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Libraries
{
    public class CompetitionLibrary
    {
        private readonly CompetitionEntities _competitionEntities;
        //TODO: Move all console logs to the view!
        public CompetitionLibrary()
        {
            _competitionEntities = new CompetitionEntities();
        }

        public List<Competition> GetCompetitions()
        {
            var comps = _competitionEntities.Competitions.Include(c => c.Competitors);
            /*
            //foreach (var competition in _competitionEntities.Competitions)
            foreach (var competition in comps)
            {
                Console.WriteLine($"Competition: {Environment.NewLine + competition.ToString() + Environment.NewLine} contains following players: ");
                var competitors = competition.Competitors;
                //var competitors = competitionEntities.Competitors.Where(competitor => competitor.CompetitionId == competition.CompetitionId);
                foreach (var competitor in competitors)
                {
                    Console.WriteLine($"\t{competitor.ToString()}");
                }
            }
            */
            return comps.ToList();
        }
        public Competition GetCompetition(int id)
        {
            var comp = _competitionEntities.Competitions.Include(c => c.Competitors).FirstOrDefault(c => c.CompetitionId == id);
            return comp;
        }
        //public CompetitionEntities GetCompetitionEntities () {     }
        /*
         Will contain: 
            En metod som hämtar en lista med alla tävlingar i databasen.
            En metod som kan hämta en specifik tävling, tar ett id som parameter.
            
            Använd LINQ för dessa ”queries”.
         */

    }
}
