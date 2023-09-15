using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.Exceptions;
using DungeonMaster.Models.HeroClasses;
using DungeonMaster.Models.Utilities;

namespace DungeonMaster.Tests
{
    public class ArmorTests
    {
        [Fact]
        public void Armor_Creation_InitializesName()
        {
            // Arrange 
            string ArmorName = "Leather Helm";

            // Act
            Armor leatherHelm = new Armor(ArmorName, 2, ArmorType.Leather, new HeroAttribute(3, 2, 3), Slot.Head);

            // Assert
            Assert.Equal("Leather Helm", leatherHelm.Name);
        }

        [Fact]
        public void Armor_Creation_InitializesRequiredLevel()
        {
            // Arrange 
            string ArmorName = "Leather Helm";

            // Act
            Armor leatherHelm = new Armor(ArmorName, 2, ArmorType.Leather, new HeroAttribute(3, 2, 3), Slot.Head);

            // Assert
            Assert.Equal(2, leatherHelm.RequiredLevel);
        }

        [Fact]
        public void Armor_Creation_InitializesSlot()
        {
            // Arrange 
            string ArmorName = "Leather Helm";

            // Act
            Armor leatherHelm = new Armor(ArmorName, 2, ArmorType.Leather, new HeroAttribute(3, 2, 3), Slot.Head);

            // Assert
            Assert.Equal(Slot.Head, leatherHelm.Slot);
        }

        [Fact]
        public void Armor_Creation_InitializesArmorType()
        {
            // Arrange 
            string ArmorName = "Leather Helm";

            // Act
            Armor leatherHelm = new Armor(ArmorName, 2, ArmorType.Leather, new HeroAttribute(3, 2, 3), Slot.Head);

            // Assert
            Assert.Equal(ArmorType.Leather, leatherHelm.ArmorType);
        }

        [Fact]
        public void Armor_Creation_InitializesStrengthAttribute()
        {
            // Arrange 
            string armorName = "Leather Helm";

            // Act
            Armor leatherHelm = new Armor(armorName, 2, ArmorType.Leather, new HeroAttribute(3, 2, 3), Slot.Head);

            // Assert
            Assert.Equal(3, leatherHelm.ArmorAttribute.Strength);
        }

        [Fact]
        public void Armor_Creation_InitializesDexterityAttribute()
        {
            // Arrange 
            string armorName = "Leather Helm";

            // Act
            Armor leatherHelm = new Armor(armorName, 2, ArmorType.Leather, new HeroAttribute(3, 2, 3), Slot.Head);

            // Assert
            Assert.Equal(2, leatherHelm.ArmorAttribute.Dexterity);
        }

        [Fact]
        public void Armor_Creation_InitializesIntelligenceAttribute()
        {
            // Arrange 
            string armorName = "Leather Helm";

            // Act
            Armor leatherHelm = new Armor(armorName, 2, ArmorType.Leather, new HeroAttribute(3, 2, 3), Slot.Head);

            // Assert
            Assert.Equal(3, leatherHelm.ArmorAttribute.Intelligence);
        }

        [Fact]
        public void Equip_ValidAmorCanBeEquipped_WhenArmorIsValid()
        {
            // Arrange 
            Hero hero = new Swashbuckler("Jonathan");
            Armor leatherHelm = new Armor("Common Leather Helm", 1, ArmorType.Leather, new HeroAttribute(1, 0, 0), Slot.Head);

            // Act
            hero.Equip(leatherHelm);

            // Assert
            Assert.Equal(leatherHelm, hero.Equipment[leatherHelm.Slot]);
        }

        [Fact]
        public void Equip_ThrowsInvalidArmorException_WhenEquippingInvalidArmorOutsideOfLevel()
        {
            // Arrange 
            Hero hero = new Swashbuckler("Jonathan");
            Armor leatherHelm = new Armor("Leather Helm", 2, ArmorType.Leather, new HeroAttribute(3, 2, 3), Slot.Head);
            const string expectedMessage = "Armor level requirement not met.";

            // Act and Assert
            var exception = Assert.Throws<InvalidArmorException>(() => hero.Equip(leatherHelm));
            string actualMessage = exception.Message.Trim();

            // Assert
            Assert.Equal(expectedMessage, actualMessage);
        }

        [Fact]
        public void Equip_ThrowsInvalidArmorException_WhenEquippingInvalidArmorOutsideOfArmorType()
        {
            // Arrange 
            Hero hero = new Swashbuckler("Jonathan");
            Armor plateHelm = new Armor("Plate Helm", 1, ArmorType.Plate, new HeroAttribute(3, 2, 3), Slot.Head);
            const string expectedMessage = "Invalid armor type.";

            // Act and Assert
            var exception = Assert.Throws<InvalidArmorException>(() => hero.Equip(plateHelm));
            string actualMessage = exception.Message.Trim();

            // Assert
            Assert.Equal(expectedMessage, actualMessage);
        }

    }


}