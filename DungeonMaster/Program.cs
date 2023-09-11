using DungeonMaster.Models.HeroClasses;

namespace DungeonMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseHero jens = new Archer("Jens the Archer");
            
            Console.WriteLine(jens.Display());
        }


    }
}