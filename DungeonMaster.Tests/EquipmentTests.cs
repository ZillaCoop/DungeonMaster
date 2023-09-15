using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.HeroClasses;
using DungeonMaster.Models.Utilities;

namespace DungeonMaster.Tests
{
    public class EquipmentTests
    {
        [Fact]
        public void Weapon_Creation_InitializesName()
        {
            // Arrange 
            string weaponName = "Long Bow";

            // Act
            Weapon longBow = new Weapon(weaponName, 2, WeaponType.Bow, 15);

            // Assert
            Assert.Equal("Long Bow", longBow.Name);
        }

        [Fact]
        public void Weapon_Creation_InitializesRequiredLevel()
        {
            // Arrange 
            string weaponName = "Long Bow";

            // Act
            Weapon longBow = new Weapon(weaponName, 2, WeaponType.Bow, 15);

            // Assert
            Assert.Equal(2, longBow.RequiredLevel);
        }

        [Fact]
        public void Weapon_Creation_InitializesSlot()
        {
            // Arrange 
            string weaponName = "Long Bow";

            // Act
            Weapon longBow = new Weapon(weaponName, 2, WeaponType.Bow, 15);

            // Assert
            Assert.Equal(Slot.Weapon, longBow.Slot);
        }

        [Fact]
        public void Weapon_Creation_InitializesWeaponType()
        {
            // Arrange 
            string weaponName = "Long Bow";

            // Act
            Weapon longBow = new Weapon(weaponName, 2, WeaponType.Bow, 15);

            // Assert
            Assert.Equal(WeaponType.Bow, longBow.WeaponType);
        }

        [Fact]
        public void Weapon_Creation_InitializesDamage()
        {
            // Arrange 
            string weaponName = "Long Bow";

            // Act
            Weapon longBow = new Weapon(weaponName, 2, WeaponType.Bow, 15);

            // Assert
            Assert.Equal(15, longBow.WeaponDamage);
        }
    }


}