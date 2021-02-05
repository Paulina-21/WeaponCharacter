using System;

namespace WarriorCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Weapon("Maaan", "Sword", 2.3, 0, 5.4, 0, null) ;
            Character character1 = new Character("Cata", "human", "Atack",50,  sword);

        }
    }
}
