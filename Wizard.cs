using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPGPartySystemProject
{
    internal class Wizard : Hero
    {
        private int mana;
        public int Mana
        {
            get { return mana; } set { mana = value; }
        }
        public Wizard(string heroName, int heroHealth, int heroStrenght, int mana) : base(heroName, heroHealth, heroStrenght)
        {
            this.mana = mana;
        }
        public Wizard()
        {
            HeroName = "Xardas";
            HeroHealth = 1;
            HeroStrenght += random.Next(1, 6 + 1);
            for (int dice = 0; dice < 2; dice++)
            {
                HeroStrenght += random.Next(1, 6 + 1);
            }
        }
        public override float AttackPower()
        {
            return (Mana + HeroStrenght)*HeroHealth;
        }
    }
}
