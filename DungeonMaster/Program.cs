using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.Exceptions;
using DungeonMaster.Models.HeroClasses;
using DungeonMaster.Models.Utilities;
using System;
using System.Linq;

namespace DungeonMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Swashbuckler("Jonathan");
            Weapon dagger = new Weapon("DaggerSwagger from Hell", 97, WeaponType.Dagger, 219);
            const string expectedMessage = "Weapon level requirement not met.";

            // Act
            hero.Equip(dagger);
        }

            /*
            // CHARACTER CREATION
            Console.WriteLine("Welcome to Dungeon Master!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Hero hero = null;

            while (hero == null)
            {
                Console.WriteLine($"Hello {name}! Pick a class: (1)Barbarian, (2)Archer, (3)Swashbuckler, (4)Wizard");
                string heroChoice = Console.ReadLine();

                switch (heroChoice)
                {
                    case "1":
                        hero = new Barbarian(name);
                        break;
                    case "2":
                        hero = new Archer(name);
                        break;
                    case "3":
                        hero = new Swashbuckler(name);
                        break;
                    case "4":
                        hero = new Wizard(name);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please pick a class number.");
                        break;
                }
            }

            Console.WriteLine($"Your {hero.GetType().Name} has been created! Here are your stats:");
            Console.WriteLine(hero.Display());
            hero.Damage();

            // GAMEPLAY
            while (true)
            {
                Console.WriteLine("You now have the opportunity to build your character. What do you want to do?");
                Console.WriteLine("(1) Level up");
                Console.WriteLine("(2) Equip weapon");
                Console.WriteLine("(3) Equip armor");
                Console.WriteLine("(4) Display stats");
                Console.WriteLine("(5) Exit");
                string response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        hero.LevelUp();
                        Console.WriteLine(hero.Display());
                        break;
                    case "2":
                        Console.WriteLine("What type of weapon do you want to equip?");
                        Console.WriteLine("(1) Bow (Lv. 1)");
                        Console.WriteLine("(2) Long Bow (Lv. 3)");
                        Console.WriteLine("(3) Sword (Lv. 1)");
                        Console.WriteLine("(4) Long Sword (Lv. 5)");
                        Console.WriteLine("(5) Staff (Lv. 1)");
                        Console.WriteLine("(6) Dagger (Lv. 1)");
                        Console.WriteLine("(7) Mace (Lv. 3)");
                        Console.WriteLine("(8) Hatchet (Lv. 2)");
                        string weaponResponse = Console.ReadLine();

                        if (weaponResponse == "1")
                        {
                            if (hero.ValidWeaponTypes.Contains(WeaponType.Bow))
                            {
                                Weapon bow = new Weapon("Bow", 1, WeaponType.Bow, 13);
                                hero.Equip(bow);
                                Console.WriteLine("Bow has been equipped!");
                            }
                            else
                            {
                                Console.WriteLine("You can't equip a bow in your current class or your not a high enough level.");
                            }


                        }
                        else if (weaponResponse == "2")
                        {
                            if (hero.Level >= 3 && hero.ValidWeaponTypes.Contains(WeaponType.Bow)) // Check hero's level
                            {
                                Weapon longBow = new Weapon("Long Bow", 3, WeaponType.Bow, 28);
                                hero.Equip(longBow);
                                Console.WriteLine("Long Bow has been equipped!");
                            }
                            else
                            {
                                Console.WriteLine("You need to be at least level 3 to equip a Long Bow.");
                            }
                        }
                        else if (weaponResponse == "3")
                        {
                            Weapon sword = new Weapon("Sword", 1, WeaponType.Sword, 15);
                            hero.Equip(sword);
                            Console.WriteLine("Sword has been equipped!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid weapon choice.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("What type of armor do you want to equip?");
                        Console.WriteLine("(1) Leather");
                        Console.WriteLine("(2) Plate Mail");
                        string armorResponse = Console.ReadLine();

                        if (armorResponse == "1")
                        {
                            Armor leather = new Armor("Leather", 1, ArmorType.Leather, new HeroAttribute(1, 10, 0));
                            hero.Equip(leather);
                            Console.WriteLine("Leather armor has been equipped!");
                        }
                        else if (armorResponse == "2")
                        {
                            Armor plateMail = new Armor("Plate Mail", 1, ArmorType.Plate, new HeroAttribute(5, 0, 0));
                            hero.Equip(plateMail);
                            Console.WriteLine("Plate Mail has been equipped!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid armor choice.");
                        }
                        break;
                    case "4":
                        Console.WriteLine(hero.Display());
                        break;
                    case "5":
                        Console.WriteLine("Exiting character building menu.");
                        return;
                    default:
                        Console.WriteLine("Please pick a correct number.");
                        break;
                }
            }*/
        }
            
    }
            

