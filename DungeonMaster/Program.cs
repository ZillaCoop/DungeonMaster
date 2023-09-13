using DungeonMaster.Models.Enums;
using DungeonMaster.Models.Equipment;
using DungeonMaster.Models.Exceptions;
using DungeonMaster.Models.HeroClasses;
using DungeonMaster.Models.Utilities;

namespace DungeonMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero jens = new Archer("Jens the Archer");
            Hero james = new Wizard("James the Wizard");
            Hero jonathan = new Barbarian("Jonathan the Barbarian");
            Hero jeffrey = new Swashbuckler("Jeffrey the Swashbuckler");
            
            Console.WriteLine("Base Classes");
            Console.WriteLine("------------");
            Console.WriteLine(jens.Display());
            Console.WriteLine(james.Display());
            Console.WriteLine(jonathan.Display());
            Console.WriteLine(jeffrey.Display());

            Console.WriteLine("Leveled Up");
            Console.WriteLine("----------");
            jens.LevelUp();
            Console.WriteLine(jens.Display());
            jonathan.LevelUp();
            jonathan.LevelUp();
            Console.WriteLine(jonathan.Display());

            Console.WriteLine("Equipping");
            Console.WriteLine("---------");
            Weapon bow = new Weapon("Long Bow", 1, WeaponType.Bow, 5);
            Armor plateArmor = new Armor("Plate Mail", 1, ArmorType.Plate, new HeroAttribute(5, 0, 0));
            Weapon sword = new Weapon("Sword", 1, WeaponType.Sword, 8);

            // Attempt to equip items. Can be improved.
            try
            {
                jens.Equip(bow); // Jens can equip a bow
                Console.WriteLine($"{bow.Name} equipped!");
                jonathan.Equip(plateArmor); // Jonathan can equip plate armor
                Console.WriteLine($"{plateArmor.Name} equipped!");
                jens.Equip(sword); // This will throw an exception as Jens can't equip a sword
            }
            catch (InvalidEquipmentException ex)
            {
                Console.WriteLine($"Error: {sword.Name} could not be equipped. {ex.Message}");
            }


        }


    }
}