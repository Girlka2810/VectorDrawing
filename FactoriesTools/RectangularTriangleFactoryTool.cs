using VectorDrawing.Tools;
using System.Drawing;


namespace VectorDrawing.FactoriesTools
{
    class RectangularTriangleFactoryTool : IFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new RectangularTriangleTool(pen);
        }
    }
}
