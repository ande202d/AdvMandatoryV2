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
        private static World instance;

        private World()
        {
            _playground = new int[10, 10];
            _objectsInWorld = new List<IObjectInWorld>();
        }

        /*
         *private World(int height, int width)
        {
            _playground = new int[height, width];
            _objectsInWorld = new List<IObjectInWorld>();
        }
         *
         */

        public static World Instance
        {
            get
            {
                if (instance == null) instance = new World();
                return instance;
            }
        }

        public void ChangeWorldSize(int height, int width)
        {
            _playground = null;
            _playground = new int[height, width];
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
            else
            {
                Console.WriteLine("\n\t\t\tObject position out of world\n");
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
