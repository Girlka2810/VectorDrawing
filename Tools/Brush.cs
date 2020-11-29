using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    public class Brush : ITool
    {
        Bitmap  mainBm;
        Graphics  graphics;
        Pen brush = new Pen(Color.Black);

        public Pen PenOfTool { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Point> points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Point> ITool.points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Paint(int x, int y)
        {
           mainBm.SetPixel(x,y,Color.Black);
            
        }

        public void Paint(Point prev, Point crnt)
        {
            throw new NotImplementedException();
        }
    }
}
