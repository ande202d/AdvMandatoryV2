﻿using System;
using System.Collections.Generic;
using System.Text;
using AdvMandatoryV2.Interfaces;

namespace AdvMandatoryV2.Decorator
{
    public class DefenceBlockEnhance : DecoratorDefence
    {
        public DefenceBlockEnhance(IDefence item) : base(item)
        {
            
        }
        public override int Block
        {
            get
            {
                return base.Block * 5;
            }
            set { base.Block = value; }
        }

        public IDefence GetBase
        {
            get { return base.component; }
        }
    }
}
