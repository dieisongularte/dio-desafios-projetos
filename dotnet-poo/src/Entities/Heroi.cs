using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_poo.src.Entities
{
    public abstract class Heroi
    {
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public int Strength { get; private set; }
        public int Agility { get; private set; }
        public int Stamina { get; private set; }
        public int Magic { get; private set; }

        public Heroi(string name, string gender, int strength, int agility, int stamina, int magic)
        {
            Name = name;
            Gender = gender;
            Strength = strength;
            Agility = agility;
            Stamina = stamina;
            Magic = magic;
        }

        public override string ToString()
        {
            return "\n---------Heroi---------" +
                   $"\nName: {Name}" +
                   $"\nGender: {Gender}" +
                   $"\nStrength: {Strength}" +
                   $"\nAgility: {Agility}" +
                   $"\nStamina: {Stamina}" +
                   $"\nMagic: {Magic}";
        }
    }
}
