using PlayGround.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayGround.Helps;
using PlayGround.DesignPatterns.Prototype;
using PlayGround.DesignPatterns.Adapter;
using MoreLinq;

namespace PlayGround
{
    class Program {

        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
        {
            new Rectangule(1,1,10,10),
            new Rectangule(3,3,6,6)
        }; 


        static void Main(string[] args)
        {

            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }

        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }
    }
}
