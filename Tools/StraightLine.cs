using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    class StraightLine : ITool
    {
        public Pen PenOfTool { get; set; }
        public List<Point> points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private Graphics _graphics;


        public StraightLine(Bitmap bitmap)
        {
            _graphics = Graphics.FromImage(bitmap);
            PenOfTool = new Pen(Color.Black, 3);
        }

        public void Paint(Point prev, Point crnt)
        {
            _graphics.Clear(Color.White);


            Point[] points = new Point[]
            {
                prev,
                new Point(prev.X, prev.Y),
                crnt,
                new Point(crnt.X, crnt.Y),
            };
            _graphics.DrawPolygon(PenOfTool, points);
        }


    }
}
