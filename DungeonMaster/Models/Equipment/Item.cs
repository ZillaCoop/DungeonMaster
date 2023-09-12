using DungeonMaster.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Models.Equipment
{
    public abstract class Item
    {
        //Doesn't need to be changed after creation. Therefore no sets.
        public String Name { get; }
        public int RequiredLevel { get; }
        public Slot Slot { get; }

        //Protected so only derived classes can access or use the constructor
        protected Item(string name, int requiredLevel, Slot slot) {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }
    }
}
