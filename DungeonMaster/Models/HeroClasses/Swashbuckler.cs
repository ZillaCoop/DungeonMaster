using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.Exceptions;
using DungeonMaster.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Models.HeroClasses
{
    internal class Swashbuckler : Hero


    {

        protected override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.Dagger, WeaponType.Sword };
        protected override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };

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
            stringBuilder.AppendLine("Class: Swashbuckler");
            stringBuilder.AppendLine($"Level: {Level}");
            stringBuilder.AppendLine($"Strength: {LevelAttributes.Strength}");
            stringBuilder.AppendLine($"Dexterity: {LevelAttributes.Dexterity}");
            stringBuilder.AppendLine($"Intelligence: {LevelAttributes.Intelligence}");

            return stringBuilder.ToString();
        }
    }

    
}
