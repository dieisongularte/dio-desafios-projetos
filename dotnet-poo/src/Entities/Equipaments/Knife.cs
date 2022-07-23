using System;

namespace dotnet_poo.src.Entities.Equipaments
{
    class Knife : Weapons
    {
        public Knife(string name, string type, int atk, int acc, int crit, int cost) : 
            base(name, type, atk, acc, crit, cost)
        {}

        public override string Attack()
        {
            return "\nAttack: Attack using Knife";
        }

        public override string ToString()
        {
            return $"\nName: {this.Name}" +
                   $"\nType: {this.Type}" +
                   $"\nAtk: {this.Atk}" +
                   $"\nAcc: {this.Acc}" +
                   $"\nCrit: {this.Crit}" +
                   $"\nCost: {this.Cost}" +
                   Attack();
        }
    }
}
