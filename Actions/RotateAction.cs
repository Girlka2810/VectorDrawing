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
            PointF[] points = tool.EndShapePoints;
            PointF center = tool.Center;
            float angle = AngleCalculate(center, startPoint, endPoint);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddPolygon(points);
                using (var m = new Matrix())
                {
                    m.RotateAt(angle, center);
                    gp.Transform(m);
                }
                PointF[] rotatedPoints = gp.PathPoints;
                tool.EndShapePoints = rotatedPoints;
                tool.TemporaryPoint = endPoint;
            }
        }

        private float AngleCalculate(PointF center, PointF start, PointF end)
        {
            PointF startVector = new PointF(start.X - center.X, start.Y - center.Y);
            PointF endVector = new PointF(end.X - center.X, end.Y - center.Y);
            
            float multiplyVectors = startVector.X * endVector.X + startVector.Y * endVector.Y;
            double moduleStartVector = Math.Sqrt(startVector.X * startVector.X + startVector.Y * startVector.Y);
            double moduleEndVector = Math.Sqrt(endVector.X * endVector.X + endVector.Y * endVector.Y);
            float angle = (float) Math.Acos(multiplyVectors / moduleStartVector * moduleEndVector);
            return angle;
        }
    }
}
