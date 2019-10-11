using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Respresents a team in the tournament.
    /// </summary>
   public class TeamModel
    {
        /// <summary>
        /// The team members of a team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The team's name.
        /// </summary>
        public string TeamName { get; set; }

    }
}
