using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    class SquareTest : AbstractTool
    {

        private Graphics _graphics;

        public SquareTest(Bitmap bitmap)
        {
            _graphics = Graphics.FromImage(bitmap);

        }
        public void Paint(Point prev, Point crnt)
        {
            Pen PenOfTool = new Pen(Color.Black, 3);
            _graphics.Clear(Color.White);
            int width = Math.Abs(prev.X - crnt.X);
            int height = Math.Abs(prev.Y - crnt.Y);
            if (width >= height)
            {
                crnt.X = crnt.X >= prev.X ? prev.X + height : prev.X - height;
            }
            else
                crnt.Y = crnt.Y >= prev.Y ? prev.Y + width : prev.Y - width;
            
            _graphics.DrawPolygon(PenOfTool, _points.ToArray());
        }

  

    }
}
