using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.Actions
{
    public interface IAction
    {
        void UpdateToolPoints(AbstractTool tool, PointF startPoint, PointF endPoint);
    }
}
