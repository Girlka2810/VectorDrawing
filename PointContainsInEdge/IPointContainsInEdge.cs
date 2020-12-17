using System.Drawing;

namespace VectorDrawing.PointContainsInEdge
{
    public interface IPointContainsInEdge
    {
        bool Contain(PointF start, PointF end, PointF checkPoint, double accuracy);
    }
}