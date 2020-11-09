using System;
using System.Collections.Generic;
using System.Text;
using AdvMandatoryV2;
using AdvMandatoryV2.Interfaces;

namespace TesterProject
{
    class Shield : IDefence
    {
        public Position Pos { get; set; }
        public string Name { get; set; }
        public int Block { get; set; }

        public Shield(Position pos, string name, int block)
        {
            Pos = pos;
            Name = name;
            Block = block;
        }

        public override string ToString()
        {
            return $"{Name} with {Block} block";
        }
    }
}
