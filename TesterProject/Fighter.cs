using System;
using System.Collections.Generic;
using System.Text;
using AdvMandatoryV2;

namespace TesterProject
{
    class Fighter : BaseCreature
    {
        public Fighter(Position pos, string name, int health, int damage) : base(pos, name, health, damage)
        {
        }

        public override string ToString()
        {
            return $"{Name} with {Health}hp";
        }
    }
}
