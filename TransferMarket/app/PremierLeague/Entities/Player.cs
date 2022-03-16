using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Entities
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public string PlayerLastName { get; set; }
        public int PlayerValue { get; set; }
        public int CountryID { get; set; }
        public int TeamID { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public bool State { get; set; }
        public Team Team { get; set; }
        public Country Country { get; set; }
    }
}
