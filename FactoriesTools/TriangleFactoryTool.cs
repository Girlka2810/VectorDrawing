using VectorDrawing.Tools;
using System.Drawing;

namespace VectorDrawing.FactoriesTools
{
    class TriangleFactoryTool : IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new TriangleTool(pen);
        }
    }

}
