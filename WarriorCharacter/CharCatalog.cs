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

        public void RemoveChar(Character character)
        {
            D.Remove(character.Name);
        }

        public void UpdateChar(Character character)
        {
            D[character.Name] = character;
        }

    }
}
