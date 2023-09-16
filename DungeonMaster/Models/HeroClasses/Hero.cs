using DungeonMaster.Models.Enums;
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

        public HeroAttribute TotalAttributes() { 
            HeroAttribute totalAttributes = new HeroAttribute();

            foreach (var item in Equipment.Values)
            {
                if (item is Armor armor)
                {
                    totalAttributes.Strength += armor.ArmorAttribute.Strength;
                    totalAttributes.Dexterity += armor.ArmorAttribute.Dexterity;
                    totalAttributes.Intelligence += armor.ArmorAttribute.Intelligence;
                }
            }

            totalAttributes.Strength += LevelAttributes.Strength;
            totalAttributes.Dexterity += LevelAttributes.Dexterity;
            totalAttributes.Intelligence += LevelAttributes.Intelligence;

            return totalAttributes;
            
        }

        public double TotalDamage()
        {
            double damagingAttribute = GetDamagingAttribute();
            double weaponDamage = 0;

            if(Equipment.ContainsKey(Slot.Weapon))
            {
                Weapon? weapon = Equipment[Slot.Weapon] as Weapon;
                if (weapon != null)
                {
                    weaponDamage = weapon.WeaponDamage;
                }
                else weaponDamage = 1.0;
            }

            double totalDamage = weaponDamage * (1 + damagingAttribute/100);
            double roundedTotalDamage = Math.Round(totalDamage, 1);

            return roundedTotalDamage;
        }

        public double GetDamagingAttribute()
        {
            switch (this)
            {
                case Barbarian:
                    return TotalAttributes().Strength;
                case Wizard:
                    return TotalAttributes().Intelligence;
                case Swashbuckler:
                case Archer:
                    return TotalAttributes().Dexterity;
                default:
                    throw new InvalidOperationException("Invalid Hero class.");
            }
        }


        public abstract string Display();
        public abstract void LevelUp();
        public abstract void Equip(Item item);


    }

    
}
