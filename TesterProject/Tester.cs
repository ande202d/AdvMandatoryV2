using System;
using System.Collections.Generic;
using System.Text;
using AdvMandatoryV2;

namespace TesterProject
{
    public class Tester
    {
        public void Start()
        {
            World world = new World(4,8);
            world.PrintNumberInfo();

            Fighter f1 = new Fighter(new Position(3,5), "Fighter1", 100, 15);
            Fighter f2 = new Fighter(new Position(4,6), "Fighter2", 200, 18);
            Fighter f3 = new Fighter(new Position(1,2), "Fighter3", 300, 23);
            world.AddObject(f1);
            world.AddObject(f2);
            world.AddObject(f3);

            world.PrintObjectsInWorld();
        }
    }
}
