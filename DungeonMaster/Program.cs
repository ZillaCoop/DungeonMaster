using DungeonMaster.Models.HeroClasses;

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
            
        }


    }
}