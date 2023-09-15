﻿using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.Exceptions;
using DungeonMaster.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DungeonMaster.Models.HeroClasses
{
    public class Wizard : Hero
    {

        public override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.Staff, WeaponType.Wand };
        public override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Cloth };

        public Wizard(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(1, 1, 8);
        }

        

        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 1;
            LevelAttributes.Dexterity += 1;
            LevelAttributes.Intelligence += 5;
        }

        public override void Equip(Item item)
        {
            if (item is Weapon weapon && ValidWeaponTypes.Contains(weapon.WeaponType))
            {
                Equipment[item.Slot] = item;
            }
            else if (item is Armor armor && ValidArmorTypes.Contains(armor.ArmorType))
            {
                Equipment[item.Slot] = item;
            }
            else
            {
                throw new InvalidEquipmentException("Invalid equipment type or level requirement.");
            }
        }

        public override string Display()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine("Class: Wizard");
            stringBuilder.AppendLine($"Level: {Level}");
            stringBuilder.AppendLine($"Strength: {LevelAttributes.Strength}");
            stringBuilder.AppendLine($"Dexterity: {LevelAttributes.Dexterity}");
            stringBuilder.AppendLine($"Intelligence: {LevelAttributes.Intelligence}");

            return stringBuilder.ToString();
        }

    }
}
