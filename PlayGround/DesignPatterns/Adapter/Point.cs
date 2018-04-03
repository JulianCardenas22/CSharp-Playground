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

    public class LineToPointAdapter : Collection<Point>
    {
        private static int count;
        public LineToPointAdapter(Line line)
        {
            Console.WriteLine($"{count++}: Generating points for line [{line.start.x} ,{line.start.y}]-[{line.end.y},{line.end.y}] ");

            int left = Math.Min(line.start.x, line.end.x);
            int right = Math.Max(line.start.x, line.end.x);
            int top = Math.Min(line.start.y, line.end.y);
            int bottom = Math.Max(line.start.y, line.end.y);

            int dx = right - left;
            int dy = line.end.y - line.start.y;

            if(dx == 0){
                for (int y = top; y <= bottom; ++y){
                    Add(new Point(left, y));
                }
            }
            else if (dy == 0){
                for (int x = left;  x <= right; ++x){
                    Add(new Point(x, top));
                }
            }

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
