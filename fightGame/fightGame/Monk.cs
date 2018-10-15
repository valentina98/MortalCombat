using System;
using System.Collections.Generic;
using System.Text;

namespace fightGame
{
    class Monk : Hero
    {
        public Monk(string name)
            : base(name)
        {
            this.Kind = "monk";
        }
        public override int UseDefenceSpeciality(int reducedDmg)
        {
            Random rnd = new Random();
            int chance = rnd.Next(100);
            if (chance < 30)
                reducedDmg = 0;
            return reducedDmg;
        }
    }
}
