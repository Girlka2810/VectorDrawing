using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using VectorDrawing.Tools;

namespace VectorDrawing.Actions
{
    public class RotateAction : IAction
    {
        public void UpdateToolPoints(AbstractTool tool, PointF startPoint, PointF endPoint)
        {
            PointF center = tool.Center;
            float angle = (float)AngleCalculate(center, startPoint, endPoint);
            GraphicsPath path = tool.Path;
            using (Matrix matrix= new Matrix())
            {
                matrix.RotateAt(angle, center);
                path.Transform(matrix);
            }
            PointF[] rotatedPoints = path.PathPoints;
            tool.EndShapePoints = rotatedPoints;
            tool.TemporaryPoint = endPoint;
        }

        private double AngleCalculate(PointF center, PointF start, PointF end)
        {
            PointF startVector = new PointF(start.X - center.X, start.Y - center.Y);
            PointF endVector = new PointF(end.X - center.X, end.Y - center.Y);
            
            double alpha = Math.Atan(startVector.Y / startVector.X);
            double beta = Math.Atan(endVector.Y / endVector.X);
            double angle = beta - alpha;
            
            return angle*(180/Math.PI);
        }
    }
}
