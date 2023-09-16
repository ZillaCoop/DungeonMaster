using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.HeroClasses;
using DungeonMaster.Models.Utilities;
using System.Xml.Linq;
using Xunit;

namespace DungeonMaster.Tests
{
    public class HeroTests
    {
        [Fact]
        public void Hero_Creation_InitializesName()
        {
            // Arrange 
            string name = "Findow the Mighty";

            // Act
            Hero hero = new Barbarian(name);

            // Assert
            Assert.Equal(name, hero.Name);
        }

        [Fact]
        public void Hero_Creation_InitializesLevelToOne()
        {
            // Arrange 
            string name = "Findow the Mighty";

            // Act
            Hero hero = new Barbarian(name);

            // Assert
            Assert.Equal(1, hero.Level);
        }

        [Fact]
        public void Hero_Creation_InitializesAttributes()
        {
            // Arrange 
            string name = "Findow the Mighty";

            // Act
            Hero hero = new Barbarian(name);

            // Assert
            Assert.Equal(5, hero.LevelAttributes.Strength);
            Assert.Equal(2, hero.LevelAttributes.Dexterity);
            Assert.Equal(1, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void Barbarian_WhenLevelingUpFrom1To2_IncrementsLevelCorrectly()
        {
            // Arrange 
            string name = "Findow the Mighty";

            // Act
            Hero hero = new Barbarian(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Barbarian_WhenLevelingUpFrom1To2_IncrementsStrengthCorrectly()
        {
            // Arrange 
            string name = "Findow the Mighty";

            // Act
            Hero hero = new Barbarian(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(8, hero.LevelAttributes.Strength);
        }

        [Fact]
        public void Barbarian_WhenLevelingUpFrom1To2_IncrementsDexterityCorrectly()
        {
            // Arrange 
            string name = "Findow the Mighty";

            // Act
            Hero hero = new Barbarian(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(4, hero.LevelAttributes.Dexterity);
        }

        [Fact]
        public void Barbarian_WhenLevelingUpFrom1To2_IncrementsIntelligenceCorrectly()
        {
            // Arrange 
            string name = "Findow the Mighty";

            // Act
            Hero hero = new Barbarian(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void Archer_WhenLevelingUpFrom1To2_IncrementsLevelCorrectly()
        {
            // Arrange 
            string name = "Gregory the Twitchy";

            // Act
            Hero hero = new Archer(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Archer_WhenLevelingUpFrom1To2_IncrementsStrengthCorrectly()
        {
            // Arrange 
            string name = "Gregory the Twitchy";

            // Act
            Hero hero = new Archer(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.LevelAttributes.Strength);
        }

        [Fact]
        public void Archer_WhenLevelingUpFrom1To2_IncrementsDexterityCorrectly()
        {
            // Arrange 
            string name = "Gregory the Twitchy";

            // Act
            Hero hero = new Archer(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(12, hero.LevelAttributes.Dexterity);
        }

        [Fact]
        public void Archer_WhenLevelingUpFrom1To2_IncrementsIntelligenceCorrectly()
        {
            // Arrange 
            string name = "Gregory the Twitchy";

            // Act
            Hero hero = new Archer(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void Swashbuckler_WhenLevelingUpFrom1To2_IncrementsLevelCorrectly()
        {
            // Arrange 
            string name = "Swash the Buckler";

            // Act
            Hero hero = new Swashbuckler(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Swashbuckler_WhenLevelingUpFrom1To2_IncrementsStrengthCorrectly()
        {
            // Arrange 
            string name = "Swash the Buckler";

            // Act
            Hero hero = new Swashbuckler(name);
            hero.LevelUp();

            // Assert


            Assert.Equal(4, hero.LevelAttributes.Strength);
        }

        [Fact]
        public void Swashbuckler_WhenLevelingUpFrom1To2_IncrementsDexterityCorrectly()
        {
            // Arrange 
            string name = "Swash the Buckler";

            // Act
            Hero hero = new Swashbuckler(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(12, hero.LevelAttributes.Dexterity);
        }

        [Fact]
        public void Swashbuckler_WhenLevelingUpFrom1To2_IncrementsIntelligenceCorrectly()
        {
            // Arrange 
            string name = "Swash the Buckler";

            // Act
            Hero hero = new Swashbuckler(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void Wizard_WhenLevelingUpFrom1To2_IncrementsLevelCorrectly()
        {
            // Arrange 
            string name = "Merlyn the Swirlin";

            // Act
            Hero hero = new Wizard(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Wizard_WhenLevelingUpFrom1To2_IncrementsStrengthCorrectly()
        {
            // Arrange 
            string name = "Merlyn the Swirlin";

            // Act
            Hero hero = new Wizard(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.LevelAttributes.Strength);
        }

        [Fact]
        public void Wizard_WhenLevelingUpFrom1To2_IncrementsDexterityCorrectly()
        {
            // Arrange 
            string name = "Merlyn the Swirlin";

            // Act
            Hero hero = new Wizard(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.LevelAttributes.Dexterity);
        }

        [Fact]
        public void Wizard_WhenLevelingUpFrom1To2_IncrementsIntelligenceCorrectly()
        {
            // Arrange 
            string name = "Merlyn the Swirlin";

            // Act
            Hero hero = new Wizard(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(13, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void TotalAttributes_CalculateStrengthCorrectly_WhenHeroHasNoEquipment()
        {
            // Arrange 
            string name = "Prince Charming";

            // Act
            Hero hero = new Wizard(name);

            // Assert
            Assert.Equal(1, hero.TotalAttributes().Strength);
        }

        [Fact]
        public void TotalAttributes_CalculateDexterityCorrectly_WhenHeroHasNoEquipment()
        {
            // Arrange 
            string name = "Prince Charming";

            // Act
            Hero hero = new Wizard(name);

            // Assert
            Assert.Equal(1, hero.TotalAttributes().Dexterity);
        }

        [Fact]
        public void TotalAttributes_CalculateIntelligenceCorrectly_WhenHeroHasNoEquipment()
        {
            // Arrange 
            string name = "Prince Charming";

            // Act
            Hero hero = new Wizard(name);

            // Assert
            Assert.Equal(8, hero.TotalAttributes().Intelligence);
        }

        [Fact]
        public void TotalAttributes_CalculateStrengthCorrectly_WhenHeroHasOnePieceOfArmor()
        {
            // Arrange 
            Hero hero = new Wizard("Prince Charming");
            Armor robeOfDoom = new Armor("Robe of Doom", 1, ArmorType.Cloth, new HeroAttribute(0, 1, 10), Slot.Body);

            // Act
            hero.Equip(robeOfDoom);

            // Assert
            Assert.Equal(1, hero.TotalAttributes().Strength);
        }

        [Fact]
        public void TotalAttributes_CalculateDexterityCorrectly_WhenHeroHasOnePieceOfArmor()
        {
            // Arrange 
            Hero hero = new Wizard("Prince Charming");
            Armor robeOfDoom = new Armor("Robe of Doom", 1, ArmorType.Cloth, new HeroAttribute(0, 1, 10), Slot.Body);

            // Act
            hero.Equip(robeOfDoom);

            // Assert
            Assert.Equal(2, hero.TotalAttributes().Dexterity);
        }

        [Fact]
        public void TotalAttributes_CalculateIntelligenceCorrectly_WhenHeroHasOnePieceOfArmor()
        {
            // Arrange 
            Hero hero = new Wizard("Prince Charming");
            Armor robeOfDoom = new Armor("Robe of Doom", 1, ArmorType.Cloth, new HeroAttribute(0, 1, 10), Slot.Body);

            // Act
            hero.Equip(robeOfDoom);

            // Assert
            Assert.Equal(18, hero.TotalAttributes().Intelligence);
        }

        [Fact]
        public void TotalAttributes_CalculateStrengthCorrectly_WhenHeroHasTwoPiecesOfArmor()
        {
            // Arrange 
            Hero hero = new Wizard("Prince Charming");
            Armor robeOfDoom = new Armor("Robe of Doom", 1, ArmorType.Cloth, new HeroAttribute(0, 1, 10), Slot.Body);
            Armor leggingsOfForgottenSouls = new Armor("Leggings of Forgotten Souls", 1, ArmorType.Cloth, new HeroAttribute(1, 1, 5), Slot.Legs);

            // Act
            hero.Equip(robeOfDoom);
            hero.Equip(leggingsOfForgottenSouls); 

            // Assert
            Assert.Equal(2, hero.TotalAttributes().Strength);
        }

        [Fact]
        public void TotalAttributes_CalculateDexterityCorrectly_WhenHeroHasTwoPiecesOfArmor()
        {
            // Arrange 
            Hero hero = new Wizard("Prince Charming");
            Armor robeOfDoom = new Armor("Robe of Doom", 1, ArmorType.Cloth, new HeroAttribute(0, 1, 10), Slot.Body);
            Armor leggingsOfForgottenSouls = new Armor("Leggings of Forgotten Souls", 1, ArmorType.Cloth, new HeroAttribute(1, 1, 5), Slot.Legs);

            // Act
            hero.Equip(robeOfDoom);
            hero.Equip(leggingsOfForgottenSouls);

            // Assert
            Assert.Equal(3, hero.TotalAttributes().Dexterity);
        }

        [Fact]
        public void TotalAttributes_CalculateIntelligenceCorrectly_WhenHeroHasTwoPiecesOfArmor()
        {
            // Arrange 
            Hero hero = new Wizard("Prince Charming");
            Armor robeOfDoom = new Armor("Robe of Doom", 1, ArmorType.Cloth, new HeroAttribute(0, 1, 10), Slot.Body);
            Armor leggingsOfForgottenSouls = new Armor("Leggings of Forgotten Souls", 1, ArmorType.Cloth, new HeroAttribute(1, 1, 5), Slot.Legs);

            // Act
            hero.Equip(robeOfDoom);
            hero.Equip(leggingsOfForgottenSouls);

            // Assert
            Assert.Equal(23, hero.TotalAttributes().Intelligence);
        }

        [Fact]
        public void TotalAttributes_CalculateStrengthCorrectly_WhenHeroReplacesAlreadyExistingArmor()
        {
            // Arrange 
            Hero hero = new Wizard("Prince Charming");
            Armor robeOfDoom = new Armor("Robe of Doom", 1, ArmorType.Cloth, new HeroAttribute(0, 1, 10), Slot.Body);
            Armor leggingsOfForgottenSouls = new Armor("Leggings of Forgotten Souls", 1, ArmorType.Cloth, new HeroAttribute(1, 1, 5), Slot.Legs);
            Armor robeOfDoomCollectorsEdition = new Armor("Robe of Doom: Collectors Edition", 1, ArmorType.Cloth, new HeroAttribute(2, 3, 15), Slot.Body);

            // Act
            hero.Equip(robeOfDoom);
            hero.Equip(leggingsOfForgottenSouls);
            hero.Equip(robeOfDoomCollectorsEdition);

            // Assert
            Assert.Equal(4, hero.TotalAttributes().Strength);
        }

        [Fact]
        public void TotalAttributes_CalculateDexterityCorrectly_WhenHeroReplacesAlreadyExistingArmor()
        {
            // Arrange 
            Hero hero = new Wizard("Prince Charming");
            Armor robeOfDoom = new Armor("Robe of Doom", 1, ArmorType.Cloth, new HeroAttribute(0, 1, 10), Slot.Body);
            Armor leggingsOfForgottenSouls = new Armor("Leggings of Forgotten Souls", 1, ArmorType.Cloth, new HeroAttribute(1, 1, 5), Slot.Legs);
            Armor robeOfDoomCollectorsEdition = new Armor("Robe of Doom: Collectors Edition", 1, ArmorType.Cloth, new HeroAttribute(2, 3, 15), Slot.Body);

            // Act
            hero.Equip(robeOfDoom);
            hero.Equip(leggingsOfForgottenSouls);
            hero.Equip(robeOfDoomCollectorsEdition);

            // Assert
            Assert.Equal(5, hero.TotalAttributes().Dexterity);
        }

        [Fact]
        public void TotalAttributes_CalculateIntelligenceCorrectly_WhenHeroReplacesAlreadyExistingArmor()
        {
            // Arrange 
            Hero hero = new Wizard("Prince Charming");
            Armor robeOfDoom = new Armor("Robe of Doom", 1, ArmorType.Cloth, new HeroAttribute(0, 1, 10), Slot.Body);
            Armor leggingsOfForgottenSouls = new Armor("Leggings of Forgotten Souls", 1, ArmorType.Cloth, new HeroAttribute(1, 1, 5), Slot.Legs);
            Armor robeOfDoomCollectorsEdition = new Armor("Robe of Doom: Collectors Edition", 1, ArmorType.Cloth, new HeroAttribute(2, 3, 15), Slot.Body);

            // Act
            hero.Equip(robeOfDoom);
            hero.Equip(leggingsOfForgottenSouls);
            hero.Equip(robeOfDoomCollectorsEdition);

            // Assert
            Assert.Equal(28, hero.TotalAttributes().Intelligence);
        }

    }
}
