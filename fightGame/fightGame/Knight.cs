using System;
using System.Collections.Generic;
using System.Text;

namespace fightGame
{
    class Knight : Hero
    {
        public Knight(string name)
            : base(name)
        {
            this.Kind = "knight";
        }
        public override int UseAttakingSpeciality(int rawDmg)
        {
            Random rnd = new Random();
            int chance = rnd.Next(100);
            if (chance < 10)
                rawDmg *= 2;
            return rawDmg;
        }
        public override int UseDefenceSpeciality(int reducedDmg)
        {
            Random rnd = new Random();
            int chance = rnd.Next(100);
            if (chance < 20)
                reducedDmg = 0;
            return reducedDmg;
        }
    }
}
