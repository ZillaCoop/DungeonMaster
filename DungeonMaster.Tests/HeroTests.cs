using DungeonMaster.Models.HeroClasses;
using DungeonMaster.Models.Utilities;

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
        public void Barbarian_WhenLevelingUpFrom1To2_IncrementsAttributesCorrectly()
        {
            // Arrange 
            string name = "Findow the Mighty";

            // Act
            Hero hero = new Barbarian(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
            Assert.Equal(8, hero.LevelAttributes.Strength);
            Assert.Equal(4, hero.LevelAttributes.Dexterity);
            Assert.Equal(2, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void Archer_WhenLevelingUpFrom1To2_IncrementsAttributesCorrectly()
        {
            // Arrange 
            string name = "Gregory the Twitchy";

            // Act
            Hero hero = new Archer(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
            Assert.Equal(2, hero.LevelAttributes.Strength);
            Assert.Equal(12, hero.LevelAttributes.Dexterity);
            Assert.Equal(2, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void Swashbuckler_WhenLevelingUpFrom1To2_IncrementsAttributesCorrectly()
        {
            // Arrange 
            string name = "Swash the Buckler";

            // Act
            Hero hero = new Swashbuckler(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
            Assert.Equal(4, hero.LevelAttributes.Strength);
            Assert.Equal(12, hero.LevelAttributes.Dexterity);
            Assert.Equal(2, hero.LevelAttributes.Intelligence);
        }

        [Fact]
        public void Wizard_WhenLevelingUpFrom1To2_IncrementsAttributesCorrectly()
        {
            // Arrange 
            string name = "Merlyn the Swirlin";

            // Act
            Hero hero = new Wizard(name);
            hero.LevelUp();

            // Assert
            Assert.Equal(2, hero.Level);
            Assert.Equal(2, hero.LevelAttributes.Strength);
            Assert.Equal(2, hero.LevelAttributes.Dexterity);
            Assert.Equal(13, hero.LevelAttributes.Intelligence);
        }
    }
}