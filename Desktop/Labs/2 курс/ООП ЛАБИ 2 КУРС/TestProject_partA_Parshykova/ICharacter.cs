using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA;

namespace ProjectA
{
    public interface ICharacter
    {
        string Name { get; set; }
        int Age { get; set; }
        string Country { get; set; }
        int HP { get; set; }
        void Attack(int currentHP)
        {
            throw new NotImplementedException();
        }
    }
}
