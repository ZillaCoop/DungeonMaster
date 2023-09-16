﻿using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.Exceptions;
using DungeonMaster.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Models.HeroClasses
{
    public class Swashbuckler : Hero


    {

        public override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.Dagger, WeaponType.Sword };
        public override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };

        public Swashbuckler(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(2, 6, 1);
        }


        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 2;
            LevelAttributes.Dexterity += 6;
            LevelAttributes.Intelligence += 1;
        }
        
        public override void Equip(Item item)
            {
                if (item is Weapon weapon)
                {
                    if (!ValidWeaponTypes.Contains(weapon.WeaponType))
                    {
                        throw new InvalidWeaponException("Invalid weapon type.");
                    }

                    if (weapon.RequiredLevel > Level)
                    {
                        throw new InvalidWeaponException("Weapon level requirement not met.");
                    }

                    Equipment[item.Slot] = item;
                }
                else if (item is Armor armor)
                {
                    if (!ValidArmorTypes.Contains(armor.ArmorType))
                    {
                        throw new InvalidArmorException("Invalid armor type.");
                    }

                    if (armor.RequiredLevel > Level)
                    {
                        throw new InvalidArmorException("Armor level requirement not met.");
                    }

                    Equipment[item.Slot] = item;
                }
                else
                {
                    throw new ArgumentException("Item must be a valid weapon or armor.");
                }
            }
    

    public override string Display()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine("Class: Swashbuckler");
            stringBuilder.AppendLine($"Level: {Level}");
            stringBuilder.AppendLine($"Strength: {LevelAttributes.Strength}");
            stringBuilder.AppendLine($"Dexterity: {LevelAttributes.Dexterity}");
            stringBuilder.AppendLine($"Intelligence: {LevelAttributes.Intelligence}");
            stringBuilder.AppendLine($"Damage: {TotalDamage()}");

            return stringBuilder.ToString();
        }
    }

    
}
