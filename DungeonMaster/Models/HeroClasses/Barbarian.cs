﻿using DungeonMaster.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Models.HeroClasses
{
    internal class Barbarian : Hero
    {
        public Barbarian(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(5, 2, 1);
        }

        public override string Display()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine("Class: Barbarian");
            stringBuilder.AppendLine($"Level: {Level}");
            stringBuilder.AppendLine($"Strength: {LevelAttributes.Strength}");
            stringBuilder.AppendLine($"Dexterity: {LevelAttributes.Dexterity}");
            stringBuilder.AppendLine($"Intelligence: {LevelAttributes.Intelligence}");

            return stringBuilder.ToString();
        }

        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 3;
            LevelAttributes.Dexterity += 2;
            LevelAttributes.Intelligence += 1;
        }
    }
}
