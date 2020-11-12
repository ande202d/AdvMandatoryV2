using System;
using System.Collections.Generic;
using System.Text;
using AdvMandatoryV2;
using AdvMandatoryV2.Decorator;

namespace TesterProject
{
    public class Tester
    {
        public void Start()
        {
            World world = World.Instance;
            world.ChangeWorldSize(5,8);
            world.PrintNumberInfo();

            Fighter f1 = new Fighter(new Position(3,5), "Fighter1", 100, 15);
            Fighter f2 = new Fighter(new Position(4,6), "Fighter2", 200, 18);
            Fighter f3 = new Fighter(new Position(1,2), "Fighter3", 300, 23);
            world.AddObject(f1);
            world.AddObject(f2);
            world.AddObject(f3);

            world.PrintObjectsInWorld();

            f1.TakeHit(f2.HitDamage());

            world.PrintObjectsInWorld();

            Sword s1 = new Sword(new Position(2,2), "Sword1", 10, 5);

            world.AddObject(s1);

            f1.Offences.Add(s1);

            f2.TakeHit(f1.HitDamage());

            world.PrintObjectsInWorld();

            Shield shield1 = new Shield(new Position(2,2), "Shield1", 12);
            
            DefenceBlockEnhance fiveTimesBlock = new DefenceBlockEnhance(shield1);

            Console.WriteLine(shield1);
            Console.WriteLine(fiveTimesBlock.Block);
            //fiveTimesBlock.GetBase.Block = 20;
            Console.WriteLine(shield1);
        }
    }
}
