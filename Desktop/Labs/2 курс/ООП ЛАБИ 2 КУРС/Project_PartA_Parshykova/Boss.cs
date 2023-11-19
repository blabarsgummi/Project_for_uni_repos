using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Boss
    {
        int AttackFrequensy { get; set; }
        int Health { get; set; }
        int AttackPower { get; set; }
        int AttackPlayers()
        {
            throw new NotImplementedException();
        }
        public Boss(int attackFrequensy, int health, int attackPower)
        {
            AttackFrequensy = attackFrequensy;
            Health = health;
            AttackPower = attackPower;
        }
    }
}
