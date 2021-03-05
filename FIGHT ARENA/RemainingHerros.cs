using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGHT_ARENA
{
    class RemainingHerros
    {

        public RemainingHerros() { }

        private static List<Hero> remaining = new List<Hero>();


        public List<Hero> Remaining 
        {
            get { return remaining;  }
        }

        public void addtolist(Hero hero)
        {
            remaining.Add(hero);
        }
        public void removefromlist(Hero hero)
        {
            remaining.Remove(hero);
        }
    }
}
