using System;
using System.Collections.Generic;
using System.Text;

namespace fightGame
{
    class Warrior : Hero
    {
        public Warrior(string name)
            : base(name)
        {
            this.Kind = "warrior";
        }
    }
}
