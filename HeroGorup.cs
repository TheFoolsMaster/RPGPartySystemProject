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
        public HeroGorup(string name, List<Hero> group)
        {
            this.groupName = name;

        }

        public object Clone()
        {

            return null;
        }
    }
}
