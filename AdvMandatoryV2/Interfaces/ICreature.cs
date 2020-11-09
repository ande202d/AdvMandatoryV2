using System;
using System.Collections.Generic;

namespace AdvMandatoryV2.Interfaces
{
    public interface ICreature : IObjectInWorld
    {
        int Health { get; set; }
        int Damage { get; set; }
        String Name { get; set; }

        List<IOffence> Offences { get; set; }
        List<IDefence> Defences { get; set; }

        int HitDamage();
        void TakeHit(int receivedDamage);

        bool IsAlive();

    }
}