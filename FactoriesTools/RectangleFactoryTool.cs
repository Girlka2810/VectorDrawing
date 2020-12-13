using System.Drawing;
using VectorDrawing.Tools;

namespace VectorDrawing.FactoriesTools
{
    class RectangleFactoryTool : IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new RectangleTool(pen);
        }
    }
}
