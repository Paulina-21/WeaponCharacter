using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorCharacter
{
    class CharCatalog
    {
        private Dictionary<string, Character> D;
        public CharCatalog()
        {
            D=new Dictionary<string, Character>();
        }

        public Character Search(string name)
        {
            if (D.ContainsKey(name)) return D[name];
            else return null;
        }

        public void UpdateChar(Character character)
        {
            D[character.Name] = character;
        }

    }
}
