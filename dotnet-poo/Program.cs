using System;
using System.Collections.Generic;
using dotnet_poo.src.Entities;
using dotnet_poo.src.Entities.Categories;
using dotnet_poo.src.Entities.Equipaments;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapons knife = new Knife("Knife", "Daggers", 5, 10, 2, 4);
            List<Weapons> list = new List<Weapons>() 
            { 
                knife
            };
            
            Heroi warrior = new Warrior("Arus", "Male", 10, 10, 10, 10, list);

            Console.WriteLine(warrior);
        }
    }
}
