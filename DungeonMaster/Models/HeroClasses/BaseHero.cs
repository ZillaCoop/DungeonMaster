using DungeonMaster.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Models.HeroClasses
{
    public abstract class BaseHero
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1; //Sets default level to 1.
        public HeroAttribute LevelAttributes { get; set; }
        public BaseHero(string name)
        {
            Name = name;
            LevelAttributes = new HeroAttribute();

        }

        public abstract string Display();
        public abstract void LevelUp();


    }

    
}
