﻿using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.Exceptions;
using DungeonMaster.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Models.HeroClasses
{
    public class Archer : Hero
    {
        public override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.Bow };
        public override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };


        public Archer(string name) : base(name) {
            LevelAttributes = new HeroAttribute(1, 7, 1);
        }


        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 1;
            LevelAttributes.Dexterity += 5;
            LevelAttributes.Intelligence += 1;
        }

        public override void Equip(Item item)
        {
            if (item is Weapon weapon)
            {
                if (!ValidWeaponTypes.Contains(weapon.WeaponType))
                {
                    throw new InvalidWeaponException("Invalid weapon type or level requirement.");
                }

                Equipment[item.Slot] = item;
            }
            else if (item is Armor armor)
            {
                if (!ValidArmorTypes.Contains(armor.ArmorType))
                {
                    throw new InvalidArmorException("Invalid armor type or level requirement.");
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
            stringBuilder.AppendLine("Class: Archer");
            stringBuilder.AppendLine($"Level: {Level}");
            stringBuilder.AppendLine($"Strength: {LevelAttributes.Strength}");
            stringBuilder.AppendLine($"Dexterity: {LevelAttributes.Dexterity}");
            stringBuilder.AppendLine($"Intelligence: {LevelAttributes.Intelligence}");

            return stringBuilder.ToString();
        }
    }
}
