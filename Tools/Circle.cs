using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    class Circle : ITool
    {
        private Point[] points;

        private Graphics _graphics;
        public Pen PenOfTool { get; set; }
        public int Radius { get; set; }
        public Circle(Bitmap bitmap)
        {
            _graphics = Graphics.FromImage(bitmap);
            PenOfTool = new Pen(Color.Black, 3);
        }

        public void Paint(Point prev, Point crnt)
        {
            _graphics.Clear(Color.White);
            int halfX = (prev.X - crnt.X) / 2;
            int halfY = (prev.Y - crnt.Y) / 2;
            int startX = prev.X >= crnt.X ? crnt.X + halfX : prev.X + Module(halfX);
            int startY = prev.Y >= crnt.Y ? crnt.Y + halfY : prev.Y + Module(halfY);
            Radius = FindRadius(prev, crnt);
            _graphics.DrawEllipse(PenOfTool, startX, startY, Radius, Radius);
        }
        private int Module(int a)
        {
            if (a < 0)
                return a * -1;
            return a;
        }

        private int FindRadius(Point a, Point b)
        {
            int radius = 0;
            int width = Module(a.X - b.X);
            int height = Module(a.Y - b.Y);

            radius = (int)Math.Sqrt(width * width + height * height);
            return radius;
            //if (width >= height)
            //{
            //    b.X = b.X >= a.X ? a.X + height : a.X - height;
            //}
            //else
            //    b.Y = b.Y >= a.Y ? a.Y + width : a.Y - width;
            //points = new Point[]
            //{
            //    a,
            //    new Point(b.X, a.Y),
            //    b,
            //    new Point(a.X, b.Y),
            //};
            //int startX = b.X >= a.X ? a.X : b.X;
            //int startY = b.Y >= a.Y ? a.Y : b.Y;
            //width = Module(a.X - b.X);
            //height = Module(a.Y - b.Y);
        }
    }
}
