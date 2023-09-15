﻿using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Models.HeroClasses
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1; //Sets default level to 1.
        public HeroAttribute LevelAttributes { get; set; }

        public Weapon WeaponEquipment { get; set; }

        public abstract List<WeaponType> ValidWeaponTypes { get; }
        public abstract List<ArmorType> ValidArmorTypes { get; }


        //Creates "container" for equipment and assigning temporary null values
        public Dictionary<Slot, Item> Equipment { get; } = new Dictionary<Slot, Item>
        {
            { Slot.Weapon, null },
            { Slot.Head, null },
            { Slot.Body, null },
            { Slot.Legs, null }
        };  

       



        public Hero(string name)
        {
            Name = name;
            LevelAttributes = new HeroAttribute();
        }

        public abstract string Display();
        public abstract void LevelUp();
        public abstract void Equip(Item item); //Remember to add validation checks for the weapons.

        public double Damage()
        {
            double weaponDamage;

            if (Equipment[Slot.Weapon] is Weapon weapon)
            {
                weaponDamage = weapon.WeaponDamage + 1;
            }
            
                return 1; 
        }


    }

    
}
