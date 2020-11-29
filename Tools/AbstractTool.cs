using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    abstract class AbstractTool
    {
        protected List<Point> _points;
        protected Pen _pen;
      
        public AbstractTool(Pen pen)
        {
            _points = new List<Point> { };
            _pen = pen;
        }

        public void SetPen(Pen pen)
        {
            if(pen.Width>1 && pen.Width <= 100)
            {
                _pen = pen;
            }
        }

        public abstract void Paint(Graphics graphics);

        public void ClearPoints()
        {
            _points = new List<Point> { };
        }

        public virtual void AddPoint(Point point)
        {
            if (_points.Count > 1)
            {
                _points.RemoveAt(1);
            }
            _points.Add(point);
        }


    }
}
