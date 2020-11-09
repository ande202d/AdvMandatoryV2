using System;

namespace AdvMandatoryV2.Interfaces
{
    public interface IOffence : IObjectInWorld
    {
        String Name { get; set; }
        int Damage { get; set; }
        int Range { get; set; }
    }
}