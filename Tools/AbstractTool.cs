using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    class AbstractTool
    {
        protected List<Point> _points;
        
        public AbstractTool()
        {
            _points = new List<Point> { };
        }

        protected void Paint(Point prev, Point crnt)
        {
            throw new NotImplementedException();
        }

        public virtual void AddPoint(Point point)
        {
            if (_points.Count > 1)
            {
                _points.Insert(1, point);
                return;
            }
            _points.Add(point);
            return;
        }


    }
}
