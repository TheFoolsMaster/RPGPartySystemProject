using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPartySystemProject
{
    internal class JP : Hero
    {
        private int age;
        public int Age
        {
            get { return age; } set { age = value; }
        }
        public JP
            (string heroName, int heroHealth, int heroStrenght,int age) : base(heroName, heroHealth, heroStrenght)
        {
            this.age=age;
        }
        public JP()
        {
            HeroName = "Student";
            HeroHealth = 1;
            HeroStrenght = random.Next(0,2*6+1);
            age = 25;
        }
    }
}
