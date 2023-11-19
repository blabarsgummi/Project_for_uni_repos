using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA;

namespace ProjectA
{
    public class Boss
    {
        public int AttackFrequensy { get; set; }
        public int HP { get; set; }
        public int AttackPower { get; set; }
        public int AttackPlayers()
        {
            throw new NotImplementedException();
        }
        public Boss(int attackFrequensy, int health, int attackPower)
        {
            AttackFrequensy = attackFrequensy;
            HP = health;
            AttackPower = attackPower;
        }
    }
}
