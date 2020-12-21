using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Tools;

namespace VectorDrawing.Actions
{
    class ScaleAction : IAction
    {
        public void UpdateToolPoints(AbstractTool tool, PointF startPoint, PointF endPoint)
        { 
            GraphicsPath path = tool.Path;
            RectangleF rectangle = path.GetBounds();
            PointF[] forMatrix = new PointF[]
            {
                rectangle.Location, 
                new PointF(rectangle.X+rectangle.Width, rectangle.Y),
                new PointF(rectangle.X, rectangle.Y+rectangle.Height)
            };
            PointF center = tool.Center;
            PointF firstVectorFromCenter = new PointF(center.X - startPoint.X, center.Y - startPoint.Y);
            PointF secondVectorFromCenter = new PointF(center.X - endPoint.X, center.Y - endPoint.Y);
            double moduleOfFirstVector = Math.Sqrt(firstVectorFromCenter.X * firstVectorFromCenter.X +
                firstVectorFromCenter.Y * firstVectorFromCenter.Y);
            double moduleOfSecondVector = Math.Sqrt(secondVectorFromCenter.X * secondVectorFromCenter.X +
                secondVectorFromCenter.Y * secondVectorFromCenter.Y);
            float scale = (float)(moduleOfSecondVector / moduleOfFirstVector);
            using (Matrix matrix = new Matrix(rectangle, forMatrix))
            {
                matrix.Scale(scale, scale);
                path.Transform(matrix);
            }
            tool.EndShapePoints = path.PathPoints;
            tool.TemporaryPoint = endPoint;
            tool.CalculateCenter();
        }
    }
}
