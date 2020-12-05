using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>() { new LineAdapter(new LegacyLine()), new RectangleAdapter(new LegacyRectangle()) };

            int x1 = 5, y1 = 10, x2 = -3, y2 = 2;

            shapes.ForEach(shape => shape.Draw(x1, y1, x2, y2));
        }
    }

    internal class RectangleAdapter : IShape
    {
        private readonly LegacyRectangle _legacyRectangle;

        public RectangleAdapter(LegacyRectangle legacyRectangle)
        {
            _legacyRectangle = legacyRectangle;
        }

        public void Draw(int x1, int y1, int x2, int y2)
        {
            int x = Math.Min(x1, x2);
            int y = Math.Min(y1, y2);
            int w = Math.Abs(x2 - x1);
            int h = Math.Abs(y2 - y1);
            _legacyRectangle.Draw(x, y, w, h);
        }
    }

    internal class LineAdapter : IShape
    {
        private readonly LegacyLine _legacyLine;

        public LineAdapter(LegacyLine legacyLine)
        {
            _legacyLine = legacyLine;
        }

        public void Draw(int x1, int y1, int x2, int y2)
        {
            _legacyLine.Draw(x1, y1, x2, y2);
        }
    }

    internal class LegacyRectangle
    {
        internal void Draw(int x, int y, int w, int h)
        {
            Console.WriteLine($"Drawing rectangle {x} {y} {w} {h}");
        }
    }

    internal class LegacyLine
    {
        internal void Draw(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($"Drawing line {x1} {y1} {x2} {y2}");
        }
    }

    internal interface IShape
    {
        void Draw(int x1, int y1, int x2, int y2);
    }


}
