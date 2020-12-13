
using System.Drawing;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Ellipse;

namespace VectorDrawing.FactoriesTools
{
    class CircleFactoryTool : IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new CircleTool(pen);
        }
    }
}
