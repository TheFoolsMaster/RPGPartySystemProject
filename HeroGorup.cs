using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistulaProjekt2
{
    internal class HeroGorup : ICloneable
    {
        private string groupName;
        public string GroupName
        {
            get { return groupName; }set { groupName = value; }
        }
        private List<Hero> group = new List<Hero>();

        public HeroGorup(string name)
        {
            this.groupName = name;
        }
        public void AddMember(Hero newMember)
        {
            group.Add(newMember);
        }
        public int AllAttackInfo()
        {
            int allStrenght = 0;
            foreach (var hero in group)
            {
                allStrenght += hero.HeroStrenght;
            }
            return allStrenght;
        }

        public object Clone()
        {
            //deep clone
            HeroGorup clone = (HeroGorup) this.MemberwiseClone();
            clone.groupName = groupName;
            clone.group = group;
            return clone;
        }
        public Hero this[int key]
        {
            get { return group[key]; }
            set { group[key] = value; }
        }

        public override string ToString()
        {
            string peeps=""; 

            for (int i=0; i<group.Count; i++)
            {
                peeps += group[i].HeroName;

                if (i+1 != group.Count)
                    peeps += ", ";
            }
            return $"Group name: {GroupName}, party attack power: {AllAttackInfo()}, party members: {peeps}";
        }
    }
}
