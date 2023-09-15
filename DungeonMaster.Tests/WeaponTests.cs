using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.Exceptions;
using DungeonMaster.Models.HeroClasses;
using DungeonMaster.Models.Utilities;

namespace DungeonMaster.Tests
{
    public class WeaponTests
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

        [Fact]
        public void Equip_ValidWeaponCanBeEquipped_WhenWeaponIsValid()
        {
            // Arrange 
            Hero hero = new Swashbuckler("Jonathan");
            Weapon dagger = new Weapon("Common Dagger", 1, WeaponType.Dagger, 3);

            // Act
            hero.Equip(dagger);

            // Assert
            Assert.Equal(dagger, hero.Equipment[dagger.Slot]);
        }

        [Fact]
        public void Equip_ThrowsInvalidWeaponException_WhenEquippingInvalidWeaponOutsideOfLevel()
        {
            // Arrange 
            Hero hero = new Swashbuckler("Jonathan");
            Weapon dagger = new Weapon("DaggerSwagger from Hell", 97, WeaponType.Dagger, 219);
            const string expectedMessage = "Weapon level requirement not met.";

            // Act and Assert
            var exception = Assert.Throws<InvalidWeaponException>(() => hero.Equip(dagger));
            string actualMessage = exception.Message.Trim();

            // Assert
            Assert.Equal(expectedMessage, actualMessage);
        }

        [Fact]
        public void Equip_ThrowsInvalidWeaponException_WhenEquippingInvalidWeaponOutsideOfWeaponType()
        {
            // Arrange 
            Hero hero = new Swashbuckler("Jonathan");
            Weapon hatchet = new Weapon("Heavenly Hatchet", 1, WeaponType.Hatchet, 9);
            const string expectedMessage = "Invalid weapon type.";

            // Act and Assert
            var exception = Assert.Throws<InvalidWeaponException>(() => hero.Equip(hatchet));
            string actualMessage = exception.Message.Trim();

            // Assert
            Assert.Equal(expectedMessage, actualMessage);
        }


    }




}