using System;
using System.Collections.Generic;
using System.Text;
using AdvMandatoryV2.Interfaces;

namespace AdvMandatoryV2
{
    public class World
    {
        private int[,] _playground;
        private List<IObjectInWorld> _objectsInWorld;

        public World(int height, int width)
        {
            _playground = new int[height, width];
            _objectsInWorld = new List<IObjectInWorld>();
        }

        

        public int[,] Playground
        {
            get { return _playground;}
            set { _playground = value; }
        }

        public void AddObject(IObjectInWorld obj)
        {
            if (obj.Pos.X < _playground.GetLength(1) ||
                obj.Pos.Y < _playground.GetLength(0))
            {
                _objectsInWorld.Add(obj);
            }
        }


        #region Junk

        public void PrintNumberInfo()
        {
            Console.WriteLine($"Total: {_playground.Length}");
            Console.WriteLine($"Height: {_playground.GetLength(0)}");
            Console.WriteLine($"Width: {_playground.GetLength(1)}");
        }

        public void PrintObjectsInWorld()
        {
            Console.WriteLine("--------------------------------------------------");
            foreach (IObjectInWorld obj in _objectsInWorld)
            {
                Console.WriteLine($"{obj} is located at: {obj.Pos}");
            }
            Console.WriteLine("--------------------------------------------------");
        } 

        #endregion

    }
}
