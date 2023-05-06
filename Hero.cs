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

        private string? heroName;
        private float heroHealth; //stored in % range of value from 0 to 1
        private int heroStrenght;

        public string? HeroName
        {
            get { return heroName; } set { heroName = value; }
        }
        public float HeroHealth
        {
            get { return heroHealth*100; } set { heroHealth = value/100;}
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
            this.HeroName = heroName;
            this.HeroHealth = heroHealth;
            this.HeroStrenght = heroStrenght;
        }
        public float ModifyHeroHealth (int value)
        {
            if (HeroHealth+value < 0)
                return HeroHealth = 0;
            else if (HeroHealth + value > 100)
                return HeroHealth = 100;
            else
                return HeroHealth += value;
        }
        public virtual float AttackPower()
        {
            return (HeroHealth*HeroStrenght);
        }
        public override string ToString()
        {
            return $"{HeroName},{HeroHealth}%,{AttackPower()}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
