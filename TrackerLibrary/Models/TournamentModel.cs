using System;
using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents the tournament info.
    /// </summary>
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnTournamentComplete;

        /// <summary>
        /// The unique identifier for the tournament.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The entry fee that players pay to enter this tournament.
        /// </summary>    
        public decimal EntryFee { get; set; }

        /// <summary>
        /// The list of the teams that have entered the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// The prizes that can be won in this particular tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The rounds that this tournament has.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }
    }
}
