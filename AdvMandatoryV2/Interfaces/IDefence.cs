using System;

namespace AdvMandatoryV2.Interfaces
{
    public interface IDefence : IObjectInWorld
    {
        String Name { get; set; }
        int Block { get; set; }
    }
}