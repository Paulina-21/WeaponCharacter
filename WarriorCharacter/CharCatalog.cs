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
            while(Search(character.Name) != null)
            {
                Console.WriteLine("This name already exist");
                character.Name =  Console.ReadLine();
            }
            D.Add(character.Name, character);
        }

        public void RemoveChar(Character character)
        {
            while (Search(character.Name) == null)
            {
                Console.WriteLine("Wrong name, write correct one");
                character.Name = Console.ReadLine();
            }
            D.Remove(character.Name);
        }

        public void UpdateChar(Character character)
        {
            if(Search(character.Name) != null) D[character.Name] = character;
            Console.WriteLine("This name doesnt exist");
        }

        public void Print()
        {
            foreach (var item in D.Values)
            {
                Console.WriteLine(item);
            }
        }


        public Character Search(string name)
        {
            if (D.ContainsKey(name)) return D[name];
            else return null;
        }
    }
}
