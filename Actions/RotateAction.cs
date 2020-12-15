using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Actions
{
    class RotateAction : IAction
    {
        public PointF[] GetRotate(PointF[] points, PointF center, PointF startPoint, PointF endPoint)
        {
            PointF[] rotatedPoints = new PointF[points.Length];
            PointF startDelta = new PointF(startPoint.X - center.X, startPoint.Y - center.Y);
            PointF endDelta = new PointF(endPoint.X - center.X, endPoint.Y - center.Y);
            return rotatedPoints;
        }
    }
}
