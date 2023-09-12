using DungeonMaster.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Models.Equipment
{
    public class Weapon : Item
    {
        public WeaponType WeaponType { get; }
        public int WeaponDamage { get; }

        public Weapon(string name, int requiredLevel, WeaponType weaponType, int weaponDamage) : base(name, requiredLevel, Slot.Weapon)
        {
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }

        


    }
}
