using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_poo.src.Entities
{
    public abstract class Weapons
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Atk { get; private set; }
        public int Acc { get; private set; }
        public int Crit { get; private set; }
        public int Cost { get; private set; }

        public Weapons(string name, string type, int atk, int acc, int crit, int cost)
        {
            Name = name;
            Type = type;
            Atk = atk;
            Acc = acc;
            Crit = crit;
            Cost = cost;
        }

        public abstract string Attack();
    }
}
