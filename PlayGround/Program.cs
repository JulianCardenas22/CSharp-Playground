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
using PlayGround.DesignPatterns.DecoratorPattern;

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
            var obj = new ConcreteDecorator1(
                      new ConcreteDecorator2(
                      new ConcreteDecorator2(
                      new ConcreteComponent())));

            var a = obj.MethodA();
            var b = a;
            
        }

        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }
    }
}
