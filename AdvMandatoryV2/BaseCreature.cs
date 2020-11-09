using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<IOffence> Offences { get; set; }
        public List<IDefence> Defences { get; set; }

        public BaseCreature(Position pos, String name, int health, int damage)
        {
            Pos = pos;
            Name = name;
            Health = health;
            Damage = damage;
            Offences = new List<IOffence>();
            Defences = new List<IDefence>();
        }

        public bool IsAlive()
        {
            if (Health > 0) return true;
            else
            {
                Console.WriteLine($"{this} is dead");
                return false;
            }
        }

        public virtual int HitDamage()
        {
            if (!IsAlive()) return 0;
            int dmgToDeal = 0;
            dmgToDeal += Damage;
            foreach (IOffence offence in Offences)
            {
                dmgToDeal += offence.Damage;
            }

            Console.WriteLine($"{this} deals {dmgToDeal} damage");
            return dmgToDeal;
        }

        public virtual void TakeHit(int receivedDamage)
        {
            if (IsAlive())
            {
                //int totalBlock = 0;
                //foreach (IDefence defence in Defences)
                //{
                //    totalBlock += defence.Block;
                //}

                //var query = (from defence1 in Defences select defence1.Block);
                int totalBlock = (from defence1 in Defences select defence1.Block).Sum();

                int dmgToTake = receivedDamage - totalBlock;

                Console.WriteLine($"{this} was struck with {receivedDamage}, but only took {(dmgToTake <= 0 ? "zero" : dmgToTake.ToString())} damage");
                Health -= dmgToTake <= 0 ? 0 : dmgToTake;
            }
        }
    }
}
