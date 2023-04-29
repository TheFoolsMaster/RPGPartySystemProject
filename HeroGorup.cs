using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VistulaProjekt2
{
    internal class HeroGorup : ICloneable
    {
        public int lootest = 0;
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
            //HeroGorup clone = (HeroGorup)this.MemberwiseClone();
            HeroGorup clone = new HeroGorup(this.GroupName); 
            clone.groupName = this.groupName;
            //clone.group = this.group.ToList();
            //clone.group = this.group.ToList();
            //clone.group = this.group.ConvertAll(idk => (Hero)(book.title));
            //foreach(var hero in group)
            //clone.group.Add(new Hero());

            //group = new List<Hero>(this.group.Count);

            this.group.ForEach((item) =>
            {
                clone.group.Add((Hero)item.Clone());
            });


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
