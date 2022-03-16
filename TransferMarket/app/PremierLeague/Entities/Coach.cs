using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Entities
{
    public class Coach
    {
        public int CoachID { get; set; }
        public string CoachName { get; set; }
        public string CoachLastName { get; set; }
        public int Value { get; set; }
        public int CountryID { get; set; }
        public int Age { get; set; }
    }
}
