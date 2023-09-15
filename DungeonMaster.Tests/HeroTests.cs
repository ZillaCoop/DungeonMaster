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
    }
}