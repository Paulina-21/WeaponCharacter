using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorCharacter
{
    class Character
    {
        public Character(string n, string r, string cl, double hp, Weapon w)
        {
            Name = n;
            Race = r;
            Class = cl;
            HP = hp;
            WeaponName = w.Name;
        }

        public string Name { set; get; }
        public string Race { set; get; }
        public string Class { set; get; }
        public double HP { set; get; }
        public string WeaponName { set; get; }

    }
}
