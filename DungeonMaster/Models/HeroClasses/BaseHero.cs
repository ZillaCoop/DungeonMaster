using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Models.HeroClasses
{
    abstract class BaseHero
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1; //Sets default level to 1.

    }
}
