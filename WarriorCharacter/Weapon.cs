using System;
namespace WarriorCharacter
{
    public class Weapon
    {
        private string name;
        private string type;
        private double rarity;
        private int level;
        private double damage;
        private int sockets;
        private string handedness;

        public Weapon(string name, string type, double rarity, int level, double damage, int sockets, string handedness)
        {
            this.name = name;
            this.type = type;
            this.rarity = rarity;
            this.level = level;
            this.damage = damage;
            this.sockets = sockets;
            this.handedness = handedness;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public double Rarity { get => rarity; set => rarity = value; }
        public int Level { get => level; set => level = value; }
        public double Damage { get => damage; set => damage = value; }
        public int Sockets { get => sockets; set => sockets = value; }
        public string Handedness { get => handedness; set => handedness = value; }
    }
}
