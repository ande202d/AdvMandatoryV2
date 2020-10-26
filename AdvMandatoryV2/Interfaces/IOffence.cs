using System;

namespace AdvMandatoryV2.Interfaces
{
    public interface IOffence
    {
        String Name { get; set; }
        int Damage { get; set; }
        int Range { get; set; }
    }
}