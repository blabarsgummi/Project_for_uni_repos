using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectA
{
    public  class Player: ICharacter
    {
        int currentHP { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void Attack(int currentHP)
        {
            throw new NotImplementedException();
        }
        Elements Element;
        public Player(string name, int age, int hp, Elements element)
        {
            this.Name = name;
            this.Age = age;
            this.HP = hp;
            this.Element = element;
        }
    }
}
