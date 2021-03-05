using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGHT_ARENA
{
    class Hero
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
//Creating properties for the heros
        private int atackMax;

        public int AtackMax
        {
            get { return atackMax; }
            set { atackMax = value; }
        }

        private int atackMin;

        public int AtackMin
        {
            get { return atackMin; }
            set { atackMin = value; }
        }

        private int defenceMax;

        public int DefenceMax
        {
            get { return defenceMax; }
            set { defenceMax = value; }
        }

        private int defenceMin;

        public int DefenceMin
        {
            get { return defenceMin; }
            set { defenceMin = value; }
        }

        private int hitpoints;

        public int Hitpoints
        {
            get { return hitpoints; }
            set { hitpoints = value; }
        }

        public Hero() { }

        public Hero(string name, int atackmax, int atackmin, int defencemax, int defencemin, int hitpoints)
        {
            this.name = name;
            this.atackMax = atackmax;
            this.atackMin = atackmin;
            this.defenceMax = defencemax;
            this.defenceMin = defencemin;
            this.hitpoints = hitpoints;

            
        }
        public int randomefect(int numMin, int numMax)
        {
            Random rdn = new Random();
            int res = rdn.Next(numMin, (numMax + 1));


            return res;
        }


    }
}
