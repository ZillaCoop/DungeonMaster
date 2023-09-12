using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Models.Equipment
{
    public class Armor : Item
    {
        public ArmorType ArmorType { get; }
        public HeroAttribute ArmorAttribute { get; }

        public Armor(string name, int requiredLevel, ArmorType armorType, HeroAttribute armorAttribute) : base(name, requiredLevel, Slot.Body)
        {
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;
        }
    }
}
