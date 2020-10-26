using System;
using System.Collections.Generic;
using System.Text;
using AdvMandatoryV2.Interfaces;

namespace AdvMandatoryV2
{
    public abstract class BaseCreature : ICreature
    {
        public Position Pos { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }

        public BaseCreature(Position pos, String name, int health, int damage)
        {
            Pos = pos;
            Name = name;
            Health = health;
            Damage = damage;
        }

        public int HitDamage()
        {
            Console.WriteLine($"{this} deals {Damage} damage");
            return Damage;
        }

        public void TakeHit(int receivedDamage)
        {
            Console.WriteLine($"{this} received {receivedDamage} damage");
            Health -= receivedDamage;
        }
    }
}
