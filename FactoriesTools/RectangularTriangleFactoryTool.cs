using VectorDrawing.Tools;
using System.Drawing;


namespace VectorDrawing.FactoriesTools
{
    class RectangularTriangleFactoryTool
    {
        public AbstractTool Create(Pen pen)
        {
            return new RectangularTriangleTool(pen);
        }
    }
}
