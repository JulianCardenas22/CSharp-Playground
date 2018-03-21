using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PlayGround.DesignPatterns.FactoryPattern
{
    class Point
    {
        public double x , y ;


        private Point(double x , double y)  {
            this.x = x;
            this.y = y;
        }

        public static Point OriginNew => new Point(0,0);
        public static Point Origin    =  new Point(0,0);

        public override string ToString(){
            return $"X:{x} , Y:{y}";
        }

        public static class Factory
        {
            public static Point NewPointCartesian(double x, double y){
                return new Point(x, y);
            }

            public static Point NewPointPolar(double rho, double theta){
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }

        }
    }
}
