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
        public void AddChar(Character character)
        {
            D.Add(character.Name, character);
        }
    }
}
