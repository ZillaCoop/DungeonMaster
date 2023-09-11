using DungeonMaster.Models.HeroClasses;

namespace DungeonMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseHero jens = new Archer("Jens the Archer");
            BaseHero james = new Wizard("James the Wizard");
            BaseHero jonathan = new Barbarian("Jonathan the Barbarian");
            BaseHero jeffrey = new Swashbuckler("Jeffrey the Swashbuckler");
            
            Console.WriteLine(jens.Display());
            Console.WriteLine(james.Display());
            Console.WriteLine(jonathan.Display());
            Console.WriteLine(jeffrey.Display());
            
        }


    }
}