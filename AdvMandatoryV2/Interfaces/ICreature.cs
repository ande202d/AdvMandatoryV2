using System;

namespace AdvMandatoryV2.Interfaces
{
    public interface ICreature : IObjectInWorld
    {
        int Health { get; set; }
        int Damage { get; set; }
        String Name { get; set; }

        int HitDamage();
        void TakeHit(int receivedDamage);

    }
}