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
            PointF center = tool.Center;
            PointF firstVectorFromCenter = new PointF(center.X - startPoint.X, center.Y - startPoint.Y);
            PointF secondVectorFromCenter = new PointF(center.X - endPoint.X, center.Y - endPoint.Y);
            PointF vector = new PointF(secondVectorFromCenter.X - firstVectorFromCenter.X, secondVectorFromCenter.Y - firstVectorFromCenter.Y);

            using (Matrix matrix = new Matrix())
            {
                matrix.Scale(vector.X, vector.Y);
                path.Transform(matrix);
            }
            tool.EndShapePoints = path.PathPoints;
            tool.TemporaryPoint = endPoint;
        }
    }
}
