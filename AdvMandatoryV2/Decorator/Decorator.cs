using System;
using System.Collections.Generic;
using System.Text;
using AdvMandatoryV2.Interfaces;

namespace AdvMandatoryV2.Decorator
{
    public abstract class Decorator : IDefence
    {
        protected IDefence component;

        public Decorator(IDefence item)
        {
            component = item;
        }

        public void SetComponent(IDefence item)
        {
            component = item;
        }

        public Position Pos { get; set; }

        public string Name { get; set; }

        public virtual int Block
        {
            get
            {
                if (component != null) return component.Block;
                else return Block;
            }
            set { Block = value; }
        }

    }
}
