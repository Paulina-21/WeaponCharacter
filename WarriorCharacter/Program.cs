using System;

namespace WarriorCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Weapon("Maaan", "Sword", 2.3, 0, 5.4, 0, null) ;
            Character character1 = new Character("Cata", "human", "Atack",50,  sword);
            Weapon sword2 = new Weapon("Maaan2", "Sword", 2.3, 0, 5.4, 0, null);
            Character character2 = new Character("Cata2", "human", "Atack", 50, sword);
            Character character3 = new Character("Cata3", "human", "Atack", 50, sword);

            CharCatalog charCatalog = new CharCatalog();
            WeaponCatalog weapon = new WeaponCatalog();

            charCatalog.AddChar(character1);

            charCatalog.Print();
            charCatalog.AddChar(character2);
            charCatalog.AddChar(character3);
            charCatalog.Print();
            charCatalog.RemoveChar(character2);
            charCatalog.Print();
            charCatalog.AddChar(character2);
            charCatalog.Print();

        }
    }
}
