using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectA
{
    public class Leader: ICharacter
    {
        int HPForLeading { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void Attack(int currentHP)
        {
            throw new NotImplementedException();
        }
        Elements Element;

        public Leader(string name, Elements element, int age, int hpForLeading, int hp)
        {
            this.Name = name;
            this.Age = age;
            this.HPForLeading = hpForLeading;
            this.HP = hp;
            this.Element = element;

        }

    }
}
