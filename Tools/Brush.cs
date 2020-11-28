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
        public Pen PenOfTool { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Paint(Point prev, Point crnt)
        {
            throw new NotImplementedException();
        }
        
    }
}
