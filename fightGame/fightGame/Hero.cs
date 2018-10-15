using System;
using System.Collections.Generic;
using System.Text;

namespace fightGame
{
    abstract class Hero
    {
        private string name;
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        private string kind;
        public string Kind
        {
            get { return kind; }
            protected set { kind = value; }
        }
        private int HealthPoints { get; set; } = 2000;
        private int AttackPoints { get; set; } = 100;
        private int ArmorPoints { get; set; } = 20;

        public Hero(string givenName)
        {
            this.Name = givenName;
        }
        public int Attack()
        {
            Random rnd = new Random();
            int rawDmg = Convert.ToInt32(this.AttackPoints * rnd.Next(80, 121) / 100);
            rawDmg = UseAttakingSpeciality(rawDmg);
            return rawDmg;
        }
        public virtual int UseAttakingSpeciality(int rawDmg)
        {
            return rawDmg;
        }
        public void Defend(int rawDmg)
        {
            Random rnd = new Random();
            int reducedDmg = Convert.ToInt32(rawDmg - this.ArmorPoints * (rnd.Next(80, 121) / 100));
            reducedDmg = UseDefenceSpeciality(reducedDmg);
            this.HealthPoints -= reducedDmg;
        }
        public virtual int UseDefenceSpeciality(int reducedDmg)
        {
            return reducedDmg;
        }
        public int GetHealthPoints()
        {
            return this.HealthPoints;
        }
        public bool HearthBeating()
        {
            if (this.HealthPoints <= 0)
                return false;
            else return true;//////////////
        }
    }
}
