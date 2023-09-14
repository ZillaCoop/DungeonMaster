﻿using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.Exceptions;
using DungeonMaster.Models.HeroClasses;
using DungeonMaster.Models.Utilities;

namespace DungeonMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CHARACTER CREATION
            Console.WriteLine("Welcome to Dungeon Master!"); 
            Console.WriteLine("What is your name?"); 
            string name = Console.ReadLine(); 
            
            Hero hero = null; 
            
            while (hero == null) { 
                Console.WriteLine($"Hello {name}! Pick a class: (1)Barbarian, (2)Archer, (3)Swashbuckler, (4)Wizard"); 
                string heroChoice = Console.ReadLine(); 
                
                switch (heroChoice) { 
                    case "1": 
                        hero = new Barbarian(name); 
                        break; 
                    case "2": 
                        hero = new Archer(name); 
                        break; 
                    case "3": hero = new Swashbuckler(name); 
                        break; 
                    case "4": hero = new Wizard(name); 
                        break; 
                    default: Console.WriteLine("Invalid choice. Please pick a class number."); 
                        break; 
                } 
            }
            
            Console.WriteLine($"Your {hero.GetType().Name} has been created! Here are your stats:"); 
            Console.WriteLine(hero.Display());

            //GAMEPLAY
            Console.WriteLine("You now have the opportunity to build your character. What do you want to do?");
            Console.WriteLine("(1)Level up");
            Console.WriteLine("(2)Equip weapon");
            Console.WriteLine("(3)Equip armor");
            string response;

            while(true) { 

                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        hero.LevelUp();
                        Console.WriteLine(hero.Display()); 
                        break;
                    default:
                        Console.WriteLine("Please pick a correct number.");
                        break;
                }

            }




        }


    }
}