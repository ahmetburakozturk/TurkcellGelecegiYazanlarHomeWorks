using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Entities
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public int TeamValue { get; set; }
        public int CoachID { get; set; }
        public int CountryID { get; set; }
        public int LeagueID { get; set; }
        public int Budget { get; set; }
    }
}
