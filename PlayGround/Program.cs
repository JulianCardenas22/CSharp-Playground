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
using PlayGround.Fundamentals;
using PlayGround.GenericsType;
using PlayGround.Parallelism.TasksPlayGround;
using PlayGround.Json;

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
           var a = new Stuff();
            var sadsa = new JsonResult();

           var json= a.ToJsonString();
            var sdasd = sadsa.ToJsonString();
            Console.WriteLine(json);
            Console.WriteLine(sdasd);

            json.GetLength();
            var l = json.Reverse();
            Console.WriteLine(l);
        }

        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }
    }
}
