﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPartySystemProject
{
    internal class Warrior : Hero
    {
        public Warrior(string heroName, int heroHealth, int heroStrenght) : base(heroName, heroHealth, heroStrenght)
        {
        }
        public Warrior()
        {
            HeroName = "Geralt";
            HeroHealth = 1;
            for(int dice = 0; dice < 3;dice++)
            {
                HeroStrenght += random.Next(1,6 + 1);
            }

        }
        public override float AttackPower()
        {
            if (HeroHealth < 0.05)
                return HeroStrenght;
            else
                return HeroHealth * HeroStrenght;
        }
    }
}
