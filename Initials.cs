using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistulaProjekt2
{
    internal class Initials : Hero
    {
        private int age;
        public int Age
        {
            get { return age; } set { age = value; }
        }
        public Initials(string heroName, int heroHealth, int heroStrenght,int age) : base(heroName, heroHealth, heroStrenght)
        {
            this.age=age;
        }
        public Initials()
        {
            heroName = "Student";
            heroHealth = 100;
            heroStrenght = random.Next(0,2*6+1);
            age = 21;
        }
    }
}
