using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistulaProjekt2
{
    internal class Warrior : Hero
    {
        public Warrior(string heroName, int heroHealth, int heroStrenght) : base(heroName, heroHealth, heroStrenght)
        {
        }
        public Warrior()
        {
            HeroName = "Geralt";
            HeroHealth = 100;
            HeroStrenght = random.Next(0, 3 * 6 + 1);
        }
        public override float AttackPower()
        {
            if (HeroHealth < 5)
                return HeroStrenght;
            else
                return HeroHealth * HeroStrenght;
        }
    }
}
