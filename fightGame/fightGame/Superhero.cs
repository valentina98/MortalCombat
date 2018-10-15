using System;
using System.Collections.Generic;
using System.Text;

namespace fightGame
{
    class Superhero : Hero
    {
        public Superhero(string name)
            : base(name)
        {
            this.Kind = "superhero";
        }
        public override int UseAttakingSpeciality(int rawDmg)
        {
            Random rnd = new Random();
            int chance = rnd.Next(100);
            if (chance < 20)
                rawDmg = this.GetHealthPoints()/2;
            return rawDmg;
        }
    }
}
