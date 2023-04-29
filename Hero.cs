using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace VistulaProjekt2
{
    abstract class Hero : ICloneable
    {
        #region Properites

        protected string? heroName;
        protected int heroHealth; // wip
        protected int heroStrenght;

        public string? HeroName
        {
            get { return heroName; } set { heroName = value; }
        }
        public int HeroHealth
        {
            get { return heroHealth; } set { heroHealth = value;}
        }
        public int HeroStrenght
        {
            get { return heroStrenght; } set { heroStrenght=value;}
        }

        protected Random random = new Random();
        #endregion
        protected Hero()
        { 

        }
        protected Hero(string heroName, int heroHealth, int heroStrenght)
        {
            this.heroName = heroName;
            if (heroHealth < 0)
                this.heroHealth = 0;
            else if (heroHealth > 100)
                this.heroHealth = 100;
            this.heroStrenght = heroStrenght;
        }
        public int ModifyHeroHealth (int value)
        {
            if (heroHealth < 0)
                return heroHealth = 0;
            else if (heroHealth > 100)
                return heroHealth = 100;
            else
                return heroHealth += value;
        }
        public virtual int AttackPower()
        {
            return heroHealth*heroStrenght;
        }
        public override string ToString()
        {
            return $"{heroName},{heroHealth}%,{heroStrenght}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
