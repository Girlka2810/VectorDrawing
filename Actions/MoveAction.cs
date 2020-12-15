using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Actions
{
    public class MoveAction: IAction
    {
        public PointF[] GetMove(PointF[] points, PointF startPoint, PointF endPoint)
        {
            PointF[] movedPoints = new PointF[points.Length];
            float deltaX = endPoint.X - startPoint.X;
            float deltaY = endPoint.Y - startPoint.Y;
            for (int i = 0; i < points.Length; i++)
            {
                movedPoints[i].X = points[i].X + deltaX;
                movedPoints[i].Y = points[i].Y + deltaY;
            }
            return movedPoints;
        }

        public PointF[] GetRotate(PointF[] points, PointF center, PointF startPoint, PointF endPoint)
        {
            throw new NotImplementedException();
        }
    }
}
