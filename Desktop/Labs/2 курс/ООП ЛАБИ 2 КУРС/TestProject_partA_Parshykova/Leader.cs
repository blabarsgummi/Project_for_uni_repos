using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestProject1.Tests1;
using ProjectA;


namespace ProjectA
{
    public class Leader : ICharacter
    {
        public int HPForLeading { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack(int currentHP)
        {
            throw new NotImplementedException();
        }
        public Elements Element;

        public Leader(string name, int age, int hpForLeading, int hp, Elements element)
        {
            this.Name = name;
            this.Age = age;
            this.HPForLeading = hpForLeading;
            this.HP = hp;
            this.Element = element;

        }

    }
}
