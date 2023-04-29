using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VistulaProjekt2
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
            heroName = "Xardas";
            heroHealth = 100;
            heroStrenght = random.Next(0, 1 * 6 + 1);
            this.mana = random.Next(0, 2 * 6 + 1);
        }
        public override int AttackPower()
        {
            return (mana + heroStrenght)*heroHealth;
        }
        public override string ToString()
        {
            return base.ToString()+$"{mana}";
        }
    }
}
