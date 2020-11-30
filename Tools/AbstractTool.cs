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
        protected List<Point> Points;
        protected Pen Pen;

        protected AbstractTool(Pen pen)
        {
            Points = new List<Point> { };
            SetPen(pen);
        }

        public void SetPen(Pen pen)
        {
            if (pen.Width >= 1 && pen.Width <= 100)
            {
                Pen = pen;
            }
            else
            {
                throw new ArgumentException("Pen cannot have width less than 1 and greater than 100");
            }
        }

        public abstract void Paint(Graphics graphics);

        public void ClearPoints()
        {
            Points = new List<Point> { };
        }

        public virtual void AddPoint(Point point)
        {
            if (Points.Count > 1)
            {
                Points.RemoveAt(1);
            }

            Points.Add(point);
        }
    }
}