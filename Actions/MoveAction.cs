using System.Drawing;
using System.Drawing.Drawing2D;
using VectorDrawing.Tools;

namespace VectorDrawing.Actions
{
    public class MoveAction: IAction
    {
        public void UpdateToolPoints(AbstractTool tool, PointF startPoint, PointF endPoint)
        {
            GraphicsPath path = tool.Path;
            using (Matrix matrix = new Matrix())
            {
                float deltaX = endPoint.X - startPoint.X;
                float deltaY = endPoint.Y - startPoint.Y;
                matrix.Translate(deltaX, deltaY);
                path.Transform(matrix);
            }
    
            tool.EndShapePoints = path.PathPoints;
            tool.TemporaryPoint = endPoint;
        }
    }
}
