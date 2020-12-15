using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Actions
{
    public class RotateAction : IAction
    {
        public PointF[] GetMove(PointF[] points, PointF startPoint, PointF endPoint)
        {
            throw new NotImplementedException();
        }

        public PointF[] GetRotate(PointF[] points, PointF center, PointF startPoint, PointF endPoint)
        {
            PointF[] rotatedPoints = new PointF[points.Length];
            float deltaX = startPoint.X - center.X;
            float deltaY = startPoint.Y - center.Y;
            double radius = Math.Sqrt(deltaX*deltaX + deltaY*deltaY);
            deltaX = endPoint.X - center.X;
            deltaY = endPoint.Y - center.Y;
            double endRadius = Math.Sqrt(deltaX*deltaX + deltaY*deltaY);


            return rotatedPoints;
        }
    }
}
