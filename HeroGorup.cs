using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGPartySystemProject
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
        public void AddMember(params Hero[] newMember)
        {
            for (int i = 0; i < newMember.Length; i++)
            {
                group.Add(newMember[i]);
            }
        }
        public float GroupAttackInfo()
        {
            float allStrenght = 0;
            foreach (var hero in group)
            {
                allStrenght += hero.AttackPower();
            }
            return allStrenght;
        }

        public object Clone()
        {
            HeroGorup clone = new HeroGorup(this.GroupName); 
            clone.groupName = this.groupName;

            foreach(var hero in this.group)
            {
                clone.group.Add((Hero)hero.Clone());
            }

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
            return $"Group name: {GroupName}, party attack power: {GroupAttackInfo()}, party members: {peeps}";
        }
    }
}
