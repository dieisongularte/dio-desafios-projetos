using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_poo.src.Entities.Categories
{
    class Warrior : Heroi
    {
        public List<Weapons> Weapons { get; private set; }

        public Warrior(string name, string gender, int strength, int agility, int stamina, int magic, List<Weapons> weapons) : 
            base(name, gender, strength, agility, stamina, magic)
        {
            Weapons = weapons;
        }

        public override string ToString()
        {
            return base.ToString() + ImprimeWeapons();
        }

        private string ImprimeWeapons()
        {
            string str = $"\n---------Weapon({Weapons.Count})---------";
            foreach (var weapon in this.Weapons)
            {
                str += weapon.ToString() + "\n";
            }
            return str;
        }
    }
}
