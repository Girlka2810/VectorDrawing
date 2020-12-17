using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.Actions
{
    public class MoveAction: IAction
    {
        public void UpdateToolPoints(AbstractTool tool, PointF startPoint, PointF endPoint)
        {
            PointF[] points = tool.EndShapePoints;
            PointF[] movedPoints = new PointF[points.Length];
            float deltaX = endPoint.X - startPoint.X;
            float deltaY = endPoint.Y - startPoint.Y;
            for (int i = 0; i < points.Length; i++)
            {
                movedPoints[i].X = points[i].X + deltaX;
                movedPoints[i].Y = points[i].Y + deltaY;
            }
            tool.EndShapePoints = movedPoints;
            tool.TemporaryPoint = endPoint;
        }
    }
}
