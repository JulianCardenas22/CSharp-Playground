using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.DesignPatterns.Adapter
{
    public class Line {
        public Point start, end;

        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

    }

    public class VectorObject : Collection<Line> {
    }

    public class Rectangule : VectorObject
    {
        public Rectangule(int x, int y,int width, int height)
        {
            Add(new Line(new Point(x, y), new Point(x + width, y)));
            Add(new Line(new Point(x + width, y), new Point(x + width, y + height)));
            Add(new Line(new Point(x, y), new Point(x + width, y)));
            Add(new Line(new Point(x, y + height), new Point(x + height, y + height)));
        }
    }

   public class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
