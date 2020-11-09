using System;
using System.Collections.Generic;
using System.Text;
using AdvMandatoryV2;
using AdvMandatoryV2.Interfaces;

namespace TesterProject
{
    public class Sword : IOffence
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }

        public Sword(Position pos, string name, int damage, int range)
        {
            Pos = pos;
            Name = name;
            Damage = damage;
            Range = range;
        }

        public Position Pos { get; set; }
    }
}
