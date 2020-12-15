using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorDrawing.Actions
{
    public interface IAction
    {
        PointF[] GetMove(PointF[] points, PointF startPoint, PointF endPoint);

        PointF[] GetRotate(PointF[] points, PointF center, PointF startPoint, PointF endPoint);

    }
}
