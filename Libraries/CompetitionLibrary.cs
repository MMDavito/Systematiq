using System.Data.SqlTypes;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Libraries
{
    public class CompetitionLibrary
    {
        private readonly CompetitionEntities _competitionEntities;
        public CompetitionLibrary()
        {
            _competitionEntities = new CompetitionEntities();
        }

        public List<Competition> GetCompetitions()
        {
            var comps = _competitionEntities.Competitions.Include(c => c.Competitors);

            return comps.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="SqlNullValueException">If Competition with given ID does not exist</exception>
        public Competition GetCompetition(int id)
        {
            var comp = _competitionEntities.Competitions.Include(c => c.Competitors).FirstOrDefault(c => c.CompetitionId == id);
            return comp == null ? throw new SqlNullValueException($"Could not find competition with id: {id} in the database") : comp;
        }
    }
}
