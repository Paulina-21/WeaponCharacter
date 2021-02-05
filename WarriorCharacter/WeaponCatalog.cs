using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorCharacter
{
    class WeaponCatalog
    {
        private Dictionary<string, Weapon> D;
        public WeaponCatalog()
        {
            D = new Dictionary<string, Weapon>();
        }
        public void AddWeapon(Weapon weapon)
        {
            while (Search(weapon.Name) != null)
            {
                Console.WriteLine("This name already exist");
                weapon.Name = Console.ReadLine();
            }
            D.Add(weapon.Name, weapon);
        }

        public void RemoveWeapon(Weapon weapon)
        {
            while (Search(weapon.Name) == null)
            {
                Console.WriteLine("Wrong name, write correct one");
                weapon.Name = Console.ReadLine();
            }
            D.Remove(weapon.Name);
        }

        public void UpdateWeapon(Weapon weapon)
        {
            if (Search(weapon.Name) != null) D[weapon.Name] = weapon;
            Console.WriteLine("This name doesnt exist");
        }

        public void Print()
        {
            foreach (var item in D.Values)
            {
                Console.WriteLine(item);
            }
        }

        public Weapon Search(string name)
        {
            if (D.ContainsKey(name)) return D[name];
            else return null;
        }
    }
}
