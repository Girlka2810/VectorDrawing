using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    public abstract class AbstractTool
    {
        protected List<Point> _points;
        protected Pen _pen;

        public AbstractTool(Pen pen)
        {
            _points = new List<Point> { };
            SetPen(pen);
        }

        public void SetPen(Pen pen)
        {
            if (pen.Width >= 1 && pen.Width <= 100)
            {
                _pen = pen;
            }
            else
            {
                throw new ArgumentException("Pen cannot have width less than 1 and greater than 100");
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