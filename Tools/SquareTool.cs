using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorDrawing.Tools
{
    public class SquareTool 
    {
        // TODO: Переделать класс.
        public Point[] points { get; set; }
        private Graphics _graphics;
        public SquareTool(Bitmap bitmap)
        {
            _graphics = Graphics.FromImage(bitmap);
            PenOfTool = new Pen(Color.Black, 3);
        }
        public Pen PenOfTool { get; set; }
        

        public void Paint(Point prev, Point crnt)
        {

            _graphics.Clear(Color.White);
            int width = Module(prev.X - crnt.X);
            int height = Module(prev.Y - crnt.Y);
            if (width >= height)
            {
                crnt.X = crnt.X >= prev.X ? prev.X + height : prev.X - height;
            }
            else
                crnt.Y = crnt.Y >= prev.Y ? prev.Y + width : prev.Y - width;
            points = new Point[]
            {
                prev,
                new Point(crnt.X, prev.Y),
                crnt,
                new Point(prev.X, crnt.Y),
            };
            _graphics.DrawPolygon(PenOfTool, points);
        }

        private int Module(int a)
        {
            if (a < 0)
                return a * -1;
            return a;
        }
    }
}
