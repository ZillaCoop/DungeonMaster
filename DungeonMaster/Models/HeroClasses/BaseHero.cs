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

        public BaseHero(string name)
        {
            Name = name;
        }

        public string Display()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}");

            return stringBuilder.ToString();
        }

    }

    
}
