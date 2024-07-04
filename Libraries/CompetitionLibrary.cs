using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Libraries
{
    public class CompetitionLibrary
    {
        private CompetitionEntities competitionEntities;
        //TODO: Move all console logs to the view!
        public CompetitionLibrary()
        {
            competitionEntities = new CompetitionEntities();

            foreach (var competition in competitionEntities.Competitions)
            {
                Console.WriteLine($"Competition: {Environment.NewLine + competition.ToString() + Environment.NewLine} contains following players: ");
                var competitors = competitionEntities.Competitors.Where(competitor => competitor.CompetitionId == competition.CompetitionId);
                foreach (var competitor in competitors)
                {
                    Console.WriteLine($"\t{competitor.ToString()}");
                }
            }
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
