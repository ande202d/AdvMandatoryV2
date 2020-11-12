using System;
using System.Collections.Generic;
using System.Text;
using AdvMandatoryV2.Interfaces;

namespace AdvMandatoryV2.Decorator
{
    public abstract class DecoratorDefence : IDefence
    {
        protected IDefence component;

        public DecoratorDefence(IDefence item)
        {
            component = item;
        }

        public void SetComponent(IDefence item)
        {
            component = item;
        }

        public Position Pos
        {
            get
            {
                if (component != null) return component.Pos;
                else return new Position(99,99);
            }
            set { component.Pos = value; }
        }

        public string Name { get; set; }

        public virtual int Block
        {
            get
            {
                if (component != null) return component.Block;
                else return Block;
            }
            set { component.Block = value; }
        }

    }
}
