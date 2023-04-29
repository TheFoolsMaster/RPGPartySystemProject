using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistulaProjekt2
{
    internal class Warrior : Hero, ICloneable
    {
        public Warrior(string heroName, int heroHealth, int heroStrenght) : base(heroName, heroHealth, heroStrenght)
        {
        }
        public Warrior()
        {
            heroName = "Geralt";
            heroHealth = 100;
            heroStrenght = random.Next(0, 3 * 6 + 1);
        }
        public override int AttackPower()
        {
            if (heroHealth < 5)
                return heroStrenght;
            else
                return heroStrenght * heroHealth;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
