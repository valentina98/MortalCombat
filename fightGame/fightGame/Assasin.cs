using System;
using System.Collections.Generic;
using System.Text;

namespace fightGame
{
    class Assasin : Hero
    {
        public Assasin(string name)
            : base(name)
        {
            this.Kind = "assasin";
        }
        public override int UseAttakingSpeciality(int rawDmg)
        {
            Random rnd = new Random();
            int chance = rnd.Next(100);
            if (chance < 30)
                rawDmg *= 3;
            return rawDmg;
        }
    }
}
