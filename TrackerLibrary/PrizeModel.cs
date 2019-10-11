using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the prizes that the winners will get.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The place that the team got to.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name of the place won.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The amount of the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The percentage of the prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
