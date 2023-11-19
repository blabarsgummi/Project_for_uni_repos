using ProjectA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Game
    {
        int GameLevel { get; set; }
        int GamePrice { get; set; }
        public Team Team { get; set; }
        public Game(Team team, int GameLevel, int GamePrice, Boss boss)
        {
            Team = team;
        }
    }
}
