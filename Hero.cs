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
            this.heroHealth = heroHealth;
            this.heroStrenght = heroStrenght;
        }
        public int ModifyHeroHealth (int value)
        {
            if (HeroHealth+value < 0)
                return HeroHealth = 0;
            else if (HeroHealth + value > 100)
                return HeroHealth = 100;
            else
                return HeroHealth += value;
        }
        public virtual int AttackPower()
        {
            return (HeroHealth*HeroStrenght);
        }
        public override string ToString()
        {
            return $"{heroName},{heroHealth}%,{AttackPower()}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
