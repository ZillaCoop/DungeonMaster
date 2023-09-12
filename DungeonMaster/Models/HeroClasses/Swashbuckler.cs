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
    internal class Swashbuckler : Hero


    {

        public Item EquippedWeapon { get; protected set; }

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
            if (item.Slot == Slot.Weapon)
            {
                EquippedWeapon = item;
            }
        }

        public override string Display()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine("Class: Barbarian");
            stringBuilder.AppendLine($"Level: {Level}");
            stringBuilder.AppendLine($"Strength: {LevelAttributes.Strength}");
            stringBuilder.AppendLine($"Dexterity: {LevelAttributes.Dexterity}");
            stringBuilder.AppendLine($"Intelligence: {LevelAttributes.Intelligence}");
            if (EquippedWeapon != null)
                stringBuilder.AppendLine($"Equipped Weapon: {EquippedWeapon.Name}");

            return stringBuilder.ToString();
        }
    }

    
}
