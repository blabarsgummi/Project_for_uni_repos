using ProjectA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Team
    {
        string TeamName { get; set; }
        int GeneralHP()
        {
            throw new NotImplementedException();
        }
        public Leader Leader { get; set; } 
        public List<Player> Players; 
        public Team(string name, Leader leader)
        {
            TeamName = name;
            Leader = leader;
            Players = new List<Player>();
        }
    }

}
